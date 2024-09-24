using Booking.Models;
using Booking.Models.Data;
using Booking.Models.Repo;
using Booking.viewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Booking.Controllers
{
    
    public class BookingController : Controller
    {
        private readonly UserManager<User> _manager;
        private readonly ICityRepo _cityRepo;
        private readonly IHotelRepo _hotelRepo;
        private readonly AppDbContext _context;

        public BookingController(UserManager<User> manager,ICityRepo cityRepo,IHotelRepo hotelRepo,AppDbContext context)
        {
            this._manager = manager;
            this._cityRepo = cityRepo;
            this._hotelRepo = hotelRepo;
            this._context = context;
        }
        //public async Task<IActionResult> Book()
        //{
        //    BookViewModel model = new BookViewModel();
        //    model.Cities = _cityRepo.GetCities();
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        model.User = await _manager.FindByNameAsync(User.Identity.Name);
        //    }

        //    return View(model);
        //}
        [HttpGet]
        public async Task<IActionResult> BookFilght()
        {
            BookFlightViewModel model = new BookFlightViewModel();
            model.Cities = _cityRepo.GetCities();
            model.TypeOfTrip = TypeOfTrip.RoundTrip;
            if (User.Identity.IsAuthenticated)
            {
                model.User = await _manager.FindByNameAsync(User.Identity.Name);
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BookFilght(BookFlightViewModel model)
        {
            User user = await _manager.FindByNameAsync(User.Identity.Name);
            model.User = user;
            if (ModelState.IsValid)
            {
                UserTrip userTrip = new UserTrip();
                userTrip.UserId = user.Id;
                userTrip.NoOfAdults = model.NoOfAdult;
                userTrip.NoOfChildern = model.NoOfChildern;
                userTrip.NoOfInfant = model.NoOfInfant;
                userTrip.DepartingDate = model.DepartingDate;

                if(model.TypeOfTrip == TypeOfTrip.RoundTrip)
                {
                   Trip Round= await _context.Trips.FirstOrDefaultAsync(round => (round.From == model.From) && (round.To == model.To) && (round.IsRoundTrip == true));
                    if (Round != null)
                    {
                        userTrip.TripId = Round.Id;
                        userTrip.ReturningDate = model.ReturningDate;
                        if (IsUserBookTripsInSameDate(user.Id, Round.Id, model.DepartingDate))
                        {
                            ModelState.AddModelError("", "You already booked a trip in this date");
                        }
                        else
                        {
                            

                            try
                            {
                                
                                
                                ConfirmationViewModel confirmationViewModel = new ConfirmationViewModel();
                                confirmationViewModel.User = user;  
                                confirmationViewModel.Trip = Round;
                                confirmationViewModel.UserTrip = userTrip;
                                return View("Confirm", confirmationViewModel);
                                //return RedirectToAction("Confirm",new {userId = user.Id, tripId = Round.Id,depart = userTrip.DepartingDate});

                            }
                            catch
                            {
                                return RedirectToAction("Index","Home");
                            }
                            
                            
                        }

                    }
                    else
                    {
                        ModelState.AddModelError("To", "select city you travel To");
                        ModelState.AddModelError("From", "select city you travel from");
                        model.Cities = _cityRepo.GetCities();
                        return View(model);
                    }
                }
                else
                {
                    Trip oneWay = await _context.Trips.FirstOrDefaultAsync(Way => (Way.From == model.From) && (Way.To == model.To)&&(Way.IsRoundTrip == false));
                    if (oneWay != null)
                    {
                        userTrip.TripId = oneWay.Id;
                        if (IsUserBookTripsInSameDate(user.Id, oneWay.Id, model.DepartingDate))
                        {
                            ModelState.AddModelError("", "You already booked a trip in this date");
                        }
                        else
                        {
                            

                            try
                            {
                               
                                
                                ConfirmationViewModel confirmationViewModel = new ConfirmationViewModel();
                                confirmationViewModel.User = user;
                                confirmationViewModel.Trip = oneWay;
                                confirmationViewModel.UserTrip = userTrip;
                                return View("Confirm", confirmationViewModel);
                                //return RedirectToAction("Confirm", new { userId = user.Id, tripId = oneWay.Id, depart = userTrip.DepartingDate });

                            }
                            catch
                            {
                                return RedirectToAction("Index", "Home");
                            }
                        }

                    }
                    else
                    {
                        ModelState.AddModelError("To", "select city you travel To");
                        ModelState.AddModelError("From", "select city you travel from");
                        model.Cities = _cityRepo.GetCities();
                        return View(model);
                    }
                }

            }
            model.Cities = _cityRepo.GetCities();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> BookHotel(string cityName, string hotelName)
        {
            BookHotelViewModel model = new BookHotelViewModel();
            model.Cities = _cityRepo.GetCitiesWithCountryAndHotels();
            model.CityName = cityName;
            model.HotelName = hotelName;
            if (User.Identity.IsAuthenticated)
            {
                model.User = await _manager.FindByNameAsync(User.Identity.Name);
            }

            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BookHotel(BookHotelViewModel model)
        {
            User user = await _manager.FindByNameAsync(User.Identity.Name);
            model.User = user;
            var hotel = await _context.Hotels.Include(h => h.Rooms).FirstOrDefaultAsync(h => h.Name == model.HotelName);
            if (hotel == null)
            {
                ModelState.AddModelError("", "Choose a hotel");
            }
            else
            {
                if (ModelState.IsValid)
                {

                    


                    SelectTypeOfRoomViewModel selectType = new SelectTypeOfRoomViewModel();
                    selectType.User = user;
                    selectType.HotelName = model.HotelName;
                    selectType.HotelId = hotel.Id;
                    selectType.CityName = model.CityName;
                    selectType.NoOfRooms = model.NoOfRooms;
                    selectType.CheckIn = model.CheckIn;
                    selectType.CheckOut  = model.CheckOut;
                    selectType.NoOfAdults = model.NoOfAdult;
                    selectType.NoOfChildern = model.NoOfChildern;
                    selectType.Rooms = hotel.Rooms;
                    return View("SelectType", selectType);


                }
            }
            model.Cities = _cityRepo.GetCitiesWithCountryAndHotels();
            return View(model);
        }


        [HttpGet]
        public IActionResult HotelsPerCity(string City)
        {

            var hotels = _context.Hotels.Include(hotel => hotel.City).Where(hotel => hotel.City.Name == City).ToList();
            return PartialView  ("Hotels",hotels);
        }


        private bool IsUserBookTripsInSameDate(string userId, int tripId, DateTime depart)
        {
            var oldOne = _context.UserTrips.Where(userTrip => (userTrip.UserId == userId) && (userTrip.TripId == tripId))
                .FirstOrDefault(userTrip => userTrip.DepartingDate.Date == depart.Date );
            
           
                if (oldOne != null)
                {
                    if (depart.Year == oldOne.DepartingDate.Year && depart.Month == oldOne.DepartingDate.Month && depart.Day == oldOne.DepartingDate.Day)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                   
                }
           
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Confirm(UserTrip userTrip)
        {
           var trips = _context.UserTrips.Where(u => u.TripId == userTrip.TripId).Where(u => u.DepartingDate.Date == userTrip.DepartingDate.Date);
            var totalNUmber = 0;
            foreach(var Trip in trips)
            {
                totalNUmber += Trip.NoOfAdults + Trip.NoOfChildern;
            }
            var trip = _context.Trips.FirstOrDefault(t => t.Id == userTrip.TripId);
            if (totalNUmber >= trip.MaxNumberOfPassenger)
            {
                TempData["Fail"] = "the flignt exceed the max No of passenger";
            }
            else
            {
                _context.Add(userTrip);
                _context.SaveChanges();
                TempData["Success"] = "Successful book";
            }
            return RedirectToAction("BookFilght");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(List<int> BookedId, SelectTypeOfRoomViewModel model)
        {
            //var enumrator = BookedId.GetEnumerator();
            var dictionary= new Dictionary<int, int>();
            DetailsViewModel viewModel = new DetailsViewModel();
            //var booked = new BookedRoom();
            //booked.UserId = model.UserId;
            //booked.HotelId = model.HotelId;
            //booked.StartDate = model.CheckIn;
            //booked.EndDate = model.CheckOut;

            for (int i =0;i < model.NoOfRooms; i++)
            {
                if (dictionary.ContainsKey(BookedId[i]))
                {
                    dictionary[BookedId[i]] = dictionary[BookedId[i]] + 1;
                }
                else
                {
                    dictionary[BookedId[i]] = 1;
                }
                
                //enumrator.MoveNext();

            }
            int numberOfResident = 0;
            foreach (var key in dictionary.Keys)
            {
                var hotelRoom = _context.HotelRooms.FirstOrDefault(hotel => (hotel.HotelId == model.HotelId )&& (hotel.RoomId == key));

                var userBookedRooms = _context.BookedRooms.Where(bookedRoom => (bookedRoom.HotelId == model.HotelId)
                && (bookedRoom.RoomId == key) && (bookedRoom.UserId == model.UserId) && (bookedRoom.EndDate.Date >= model.CheckIn.Date));
                if (userBookedRooms.Any())
                {
                    TempData["Fail"] = $"User already book this Room";
                    return RedirectToAction("BookHotel", new { hotelName = model.HotelName, cityName = model.CityName });
                }


                var bookedRooms = _context.BookedRooms.Where(bookedRoom => (bookedRoom.HotelId == model.HotelId)
                && (bookedRoom.RoomId == key) && (bookedRoom.EndDate.Date >= model.CheckIn.Date)).Select(x => x.NoOfRooms).Sum();
                if(hotelRoom.TotalNoOfThisRoomPerHotel < bookedRooms + dictionary[key])
                {
                    var TpypOfRoomThatAllBooked = _context.Rooms.FirstOrDefault(room => room.Id == key);
                   
                    TempData["Fail"] = $"all Rooms of type {TpypOfRoomThatAllBooked.Type} and {TpypOfRoomThatAllBooked.BedNo} {TpypOfRoomThatAllBooked.BedType} booked";
                    return RedirectToAction("BookHotel", new { hotelName = model.HotelName, cityName = model.CityName });
                    
                }
                viewModel.TotalPrice += (hotelRoom.PricePerNight * dictionary[key]);
                var Room = _context.Rooms.FirstOrDefault(room => room.Id == key);
                numberOfResident += (Room.ResidentNo * dictionary[key]);

            }
            if(model.NoOfAdults + model.NoOfChildern > numberOfResident)
            {
                TempData["Fail"] = $"The number of resident is larger than the available number";
                return RedirectToAction("BookHotel", new { hotelName = model.HotelName, cityName = model.CityName });
            }
            
            viewModel.User = await _manager.FindByNameAsync(User.Identity.Name);
            
            viewModel.HotelId = model.HotelId;
            viewModel.CityName = model.CityName;
            viewModel.HotelName = model.HotelName;
            viewModel.RoomsId = dictionary;
            viewModel.CheckIn = model.CheckIn;
            viewModel.CheckOut = model.CheckOut;
            viewModel.NoOfChildren = model.NoOfChildern;

            viewModel.NoOfAdults = model.NoOfAdults;

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmHotel(Dictionary<int,int> RoomsId, DetailsViewModel model)
        {
            BookedRoom[] bookedRooms = new BookedRoom[RoomsId.Keys.Count];
            int index = 0;

            foreach(var key in RoomsId.Keys)
            {
                bookedRooms[index] = new BookedRoom()
                {
                    UserId = model.UserId,
                    HotelId = model.HotelId,
                    RoomId = key,
                    NoOfRooms = RoomsId[key],
                    StartDate = model.CheckIn,
                    EndDate = model.CheckOut

                };
                index++;
            }
            _context.AddRange(bookedRooms);
            _context.SaveChanges();
            TempData["Success"] = "Successful book";
            return RedirectToAction("BookHotel");
        }



    }
}
