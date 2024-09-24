using Booking.Models.Data;
using Booking.Models.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Models.Configuration
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.ToTable("Hotels");
            
            builder.HasKey(x => x.Id);

            builder.HasMany<Room>(hotel => hotel.Rooms)
                .WithMany(room => room.Hotels).UsingEntity<HotelRoom>(); 

            builder.HasOne<City>(hotel => hotel.City)
                .WithMany(City => City.Hotels).HasForeignKey(hotel => hotel.CityId);


            Hotel[] hotels = new Hotel[]
            {
                new Hotel {Id = 1, Name = "Hotel Malte - Astotel",Image = "CitiesHotels/ParisHotels/1.Hotel Malte - Astotel.4.jpg" ,CityId = 1, StarsNo= 4},
                new Hotel {Id = 2, Name = "Hotel Astoria - Astotel",Image = "CitiesHotels/ParisHotels/2.Hotel Astoria - Astotel.3.jpg" ,CityId = 1, StarsNo= 3},
                new Hotel {Id = 3, Name = "Novotel Paris Les Halles",Image = "CitiesHotels/ParisHotels/3.Novotel Paris Les Halles.4.jpg" ,CityId = 1, StarsNo= 4},
                new Hotel {Id = 4, Name = "La Maison Favart",Image = "CitiesHotels/ParisHotels/4.La Maison Favart.4.jpg" ,CityId = 1, StarsNo= 4},
                new Hotel {Id = 5, Name = "Hotel Maison Mere",Image = "CitiesHotels/ParisHotels/5.Hotel Maison Mere.4.jpg" ,CityId = 1, StarsNo= 4},
                new Hotel {Id = 6, Name = "Grand Hotel du Palais Royal",Image = "CitiesHotels/ParisHotels/6.Grand Hotel du Palais Royal.5.jpg" ,CityId = 1, StarsNo= 5},
                new Hotel {Id = 7, Name = "Hotel La Comtesse",Image = "CitiesHotels/ParisHotels/7.Hotel La Comtesse.4.jpg" ,CityId = 1, StarsNo= 4},
                new Hotel {Id = 8, Name = "Hotel Joke - Astotel",Image = "CitiesHotels/ParisHotels/8.Hotel Joke - Astotel.3.jpg" ,CityId = 1, StarsNo= 3},
                new Hotel {Id = 9, Name = "Generator Paris",Image = "CitiesHotels/ParisHotels/9.Generator Paris.5.jpg" ,CityId = 1, StarsNo= 5},
                new Hotel {Id = 10, Name = "Hotel des Arts - Montmartre",Image = "CitiesHotels/ParisHotels/10.Hotel des Arts - Montmartre.4.jpg" ,CityId = 1, StarsNo= 4},



                new Hotel {Id = 11, Name = "Shangri-La The Shard",Image = "CitiesHotels/LondonHotels/1.Shangri-La The Shard.5.webp" ,CityId = 2, StarsNo= 5},
                new Hotel {Id = 12, Name = "The Montcalm Royal",Image = "CitiesHotels/LondonHotels/2.The Montcalm Royal.5.jpg" ,CityId = 2, StarsNo= 5},
                new Hotel {Id = 13, Name = "Royal Lancaster",Image = "CitiesHotels/LondonHotels/3.Royal Lancaster.5.jpg" ,CityId = 2, StarsNo= 5},
                new Hotel {Id = 14, Name = "The Chesterfield Mayfair",Image = "CitiesHotels/LondonHotels/4.The Chesterfield Mayfair.4.jpg" ,CityId = 2, StarsNo= 4},
                new Hotel {Id = 15, Name = "St. Ermin's Hotel",Image = "CitiesHotels/LondonHotels/5.St. Ermin's Hotel.4.jpg" ,CityId = 2, StarsNo= 4},
                new Hotel {Id = 16, Name = "The Savoy",Image = "CitiesHotels/LondonHotels/6.The Savoy.5.jpg" ,CityId = 2, StarsNo= 5},
                new Hotel {Id = 17, Name = "The Bloomsbury",Image = "CitiesHotels/LondonHotels/7.The Bloomsbury.5.jpg" ,CityId = 2, StarsNo= 5},
                new Hotel {Id = 18, Name = "The Kensington",Image = "CitiesHotels/LondonHotels/8.The Kensington.5.jpg" ,CityId = 2, StarsNo= 5},
                new Hotel {Id = 19, Name = "The Montague on The Gardens",Image = "CitiesHotels/LondonHotels/9.The Montague on The Gardens.4.jpg" ,CityId = 2, StarsNo= 4},
                new Hotel {Id = 20, Name = "Conrad London St. James",Image = "CitiesHotels/LondonHotels/10.Conrad London St. James.5.jpg" ,CityId = 2, StarsNo= 5},


                new Hotel {Id = 21 ,Name = "Hotel Schweizerhof Bern",Image = "CitiesHotels/BernHotels/1.Hotel Schweizerhof Bern & Spa.5.jpg" ,CityId = 7, StarsNo= 5},
                new Hotel {Id = 22 ,Name = "Hotel Jardin Bern",Image = "CitiesHotels/BernHotels/2.Hotel Jardin Bern.3.jpg" ,CityId = 7, StarsNo= 3},
                new Hotel {Id = 23 ,Name = "NH Bern The Bristol",Image = "CitiesHotels/BernHotels/3.NH Bern The Bristol.4.jpg" ,CityId = 7, StarsNo= 4},
                new Hotel {Id = 24 ,Name = "Bellevue Palace",Image = "CitiesHotels/BernHotels/4.Bellevue Palace.5.jpg" ,CityId = 7, StarsNo= 5},
                new Hotel {Id = 25 ,Name = "Hotel Savoy",Image = "CitiesHotels/BernHotels/5.Hotel Savoy.4.jpg" ,CityId = 7, StarsNo= 4},
                new Hotel {Id = 26 ,Name = "Swissotel Kursaal Bern",Image = "CitiesHotels/BernHotels/6.Swissotel Kursaal Bern.4.jpg" ,CityId = 7, StarsNo= 4},
                new Hotel {Id = 27 ,Name = "Hotel Baren am Bundesplatz",Image = "CitiesHotels/BernHotels/7.Hotel Baren am Bundesplatz.4.jpg" ,CityId = 7, StarsNo= 4},
                new Hotel {Id = 28 ,Name = "Best Western Plus Hotel",Image = "CitiesHotels/BernHotels/8.Best Western Plus Hotel Bern.4.jpg" ,CityId = 7, StarsNo= 4},
                new Hotel {Id = 29 ,Name = "Holiday Inn Bern",Image = "CitiesHotels/BernHotels/9.Holiday Inn Bern - Westside, an IHG hotel.4.jpg" ,CityId = 7, StarsNo= 4},
                new Hotel {Id = 30 ,Name = "Novotel Bern Expo",Image = "CitiesHotels/BernHotels/10.Novotel Bern Expo.4.jpg" ,CityId = 7, StarsNo= 4},







                new Hotel {Id = 31 ,Name = "Ambassade Hotel",Image = "CitiesHotels/AmsterdamHotels/1.Ambassade Hotel.4.jpg" ,CityId = 6, StarsNo= 4},
                new Hotel {Id = 32 ,Name = "Monet Garden Hotel Amsterdam",Image = "CitiesHotels/AmsterdamHotels/2.Monet Garden Hotel Amsterdam.4.jpg" ,CityId = 6, StarsNo= 4},
                new Hotel {Id = 33 ,Name = "Hotel Jakarta Amsterdam",Image = "CitiesHotels/AmsterdamHotels/3.Hotel Jakarta Amsterdam.4.jpg" ,CityId = 6, StarsNo= 4},
                new Hotel {Id = 34 ,Name = "Banks Mansion",Image = "CitiesHotels/AmsterdamHotels/4.Banks Mansion.4.jpg" ,CityId = 6, StarsNo= 4},
                new Hotel {Id = 35 ,Name = "Met Hotel",Image = "CitiesHotels/AmsterdamHotels/5.Met Hotel.3.jpg" ,CityId = 6, StarsNo= 3},
                new Hotel {Id = 36 ,Name = "The Toren",Image = "CitiesHotels/AmsterdamHotels/6.The Toren.4.jpg" ,CityId = 6, StarsNo= 4},
                new Hotel {Id = 37 ,Name = "Eden Hotel Amsterdam",Image = "CitiesHotels/AmsterdamHotels/7.Eden Hotel Amsterdam.4.jpg" ,CityId = 6, StarsNo= 4},
                new Hotel {Id = 38 ,Name = "NH City Centre Amsterdam",Image = "CitiesHotels/AmsterdamHotels/8.NH City Centre Amsterdam.4.jpg" ,CityId = 6, StarsNo= 4},
                new Hotel {Id = 39 ,Name = "Hotel Estherea",Image = "CitiesHotels/AmsterdamHotels/9.Hotel Estherea.4.jpg" ,CityId = 6, StarsNo= 4},
                new Hotel {Id = 40 ,Name = "The Manor Amsterdam",Image = "CitiesHotels/AmsterdamHotels/10.The Manor Amsterdam.4.jpg" ,CityId = 6, StarsNo= 4},





                new Hotel {Id = 41 ,Name = "The Mandala Hotel",Image = "CitiesHotels/BerlinHotels/1.The Mandala Hotel.5.jpg" ,CityId = 11, StarsNo= 5},
                new Hotel {Id = 42 ,Name = "Grand Hyatt Berlin",Image = "CitiesHotels/BerlinHotels/2.Grand Hyatt Berlin.5.jpg" ,CityId = 11, StarsNo= 5},
                new Hotel {Id = 43 ,Name = "Hotel Zoo Berlin",Image = "CitiesHotels/BerlinHotels/3.Hotel Zoo Berlin.5.jpg" ,CityId = 11, StarsNo= 5},
                new Hotel {Id = 44 ,Name = "Mercure Hotel MOA Berlin",Image = "CitiesHotels/BerlinHotels/4.Mercure Hotel MOA Berlin.4.jpg" ,CityId = 11, StarsNo= 4},
                new Hotel {Id = 45 ,Name = "Steigenberger Hotel",Image = "CitiesHotels/BerlinHotels/5.Steigenberger Hotel Am Kanzleramt.5.jpg" ,CityId = 11, StarsNo= 5},
                new Hotel {Id = 46 ,Name = "The Circus Hotel",Image = "CitiesHotels/BerlinHotels/6.The Circus Hotel.3.jpg" ,CityId = 11, StarsNo= 3},
                new Hotel {Id = 47 ,Name = "Ludwig Van Beethoven",Image = "CitiesHotels/BerlinHotels/7.Ludwig Van Beethoven Hotel.3.jpg" ,CityId = 11, StarsNo= 3},
                new Hotel {Id = 48 ,Name = "Park Inn by Radisson",Image = "CitiesHotels/BerlinHotels/8.Park Inn by Radisson Berlin Alexanderplatz Hotel.4.jpg" ,CityId = 11, StarsNo= 4},
                new Hotel {Id = 49 ,Name = "Meliá Berlin",Image = "CitiesHotels/BerlinHotels/9.Meliá Berlin.4.jpg" ,CityId = 11, StarsNo= 4},
                new Hotel {Id = 50 ,Name = "Hotel Palace Berlin",Image = "CitiesHotels/BerlinHotels/10.Hotel Palace Berlin.5.jpg" ,CityId = 11, StarsNo= 5},








                new Hotel {Id = 51 ,Name = "The Social Athens Hotel",Image = "CitiesHotels/AthensHotels/1.The Social Athens Hotel.4.jpg" ,CityId = 12, StarsNo= 4},
                new Hotel {Id = 52 ,Name = "Electra Metropolis Athens",Image = "CitiesHotels/AthensHotels/2.Electra Metropolis Athens.5.jpg" ,CityId = 12, StarsNo= 5},
                new Hotel {Id = 53 ,Name = "Herodion Hotel",Image = "CitiesHotels/AthensHotels/3.Herodion Hotel.4.jpg" ,CityId = 12, StarsNo= 4},
                new Hotel {Id = 54 ,Name = "InnAthens",Image = "CitiesHotels/AthensHotels/4.InnAthens.4.jpg" ,CityId = 12, StarsNo= 4},
                new Hotel {Id = 55 ,Name = "The Athens Gate Hotel",Image = "CitiesHotels/AthensHotels/5.The Athens Gate Hotel.4.jpg" ,CityId = 12, StarsNo= 4},
                new Hotel {Id = 56 ,Name = "Electra Palace Athens",Image = "CitiesHotels/AthensHotels/6.Electra Palace Athens.5.jpg" ,CityId = 12, StarsNo= 5},
                new Hotel {Id = 57 ,Name = "Plaka Hotel",Image = "CitiesHotels/AthensHotels/7.Plaka Hotel.3.jpg" ,CityId = 12, StarsNo= 3},
                new Hotel {Id = 58 ,Name = "Ivis4 Boutique Hotel",Image = "CitiesHotels/AthensHotels/8.Ivis4 Boutique Hotel.4.jpg" ,CityId = 12, StarsNo= 4},
                new Hotel {Id = 59 ,Name = "Hotel Grande Bretagne",Image = "CitiesHotels/AthensHotels/9.Hotel Grande Bretagne.5.jpg" ,CityId = 12, StarsNo= 5},
                new Hotel {Id = 60 ,Name = "Brown Acropol",Image = "CitiesHotels/AthensHotels/10.Brown Acropol.4.jpg" ,CityId = 12, StarsNo= 4},


                new Hotel { Id = 61, Name = "Palazzo Veneziano", Image = "CitiesHotels/VeniceHotels/1.Palazzo Veneziano.4.jpg", CityId = 5, StarsNo = 4 },
                new Hotel { Id = 62, Name = "Hotel Saturnia & International Venezia", Image = "CitiesHotels/VeniceHotels/2.Hotel Saturnia & International Venezia.4.jpg", CityId = 5, StarsNo = 4 },
                new Hotel { Id = 63, Name = "Hotel Antiche Figure", Image = "CitiesHotels/VeniceHotels/3.Hotel Antiche Figure.3.jpg", CityId = 5, StarsNo = 3 },
                new Hotel { Id = 64, Name = "Hotel Moresco", Image = "CitiesHotels/VeniceHotels/4.Hotel Moresco.4.jpg", CityId = 5, StarsNo = 4 },
                new Hotel { Id = 65, Name = "Rosa Salva", Image = "CitiesHotels/VeniceHotels/5.Rosa Salva.3.jpg", CityId = 5, StarsNo = 3 },
                new Hotel { Id = 66, Name = "Hotel Palazzo Stern", Image = "CitiesHotels/VeniceHotels/6.Hotel Palazzo Stern.4.jpg", CityId = 5, StarsNo = 4 },
                new Hotel { Id = 67, Name = "Ruzzini Palace", Image = "CitiesHotels/VeniceHotels/7.Ruzzini Palace.4.jpg", CityId = 5, StarsNo = 4 },
                new Hotel { Id = 68, Name = "Hotel Bucintoro", Image = "CitiesHotels/VeniceHotels/8.Hotel Bucintoro.4.jpg", CityId = 5, StarsNo = 4 },
                new Hotel { Id = 69, Name = "Hotel Savoia & Jolanda", Image = "CitiesHotels/VeniceHotels/9.Hotel Savoia & Jolanda.4.jpg", CityId = 5, StarsNo = 4 },
                new Hotel { Id = 70, Name = "Palazzo Canova", Image = "CitiesHotels/VeniceHotels/10.H10 Palazzo Canova.4.jpg ", CityId = 5, StarsNo = 4 },





                new Hotel {Id = 71, Name = "The Harmonie", Image = "CitiesHotels/ViennaHotels/1.The Harmonie.4.jpeg", CityId = 10, StarsNo = 4 },
                new Hotel {Id = 72, Name = "Austria Classic",Image = "CitiesHotels/ViennaHotels/2.Austria Classic.3.jpg" ,CityId =10, StarsNo= 3},
                new Hotel {Id = 73, Name = "hotel kaiserhof wien",Image = "CitiesHotels/ViennaHotels/3.hotel kaiserhof wien.4.jpg" ,CityId = 10, StarsNo= 4},
                new Hotel {Id = 74, Name = "Boutique Hotel am Stephansplatz",Image= "CitiesHotels/ViennaHotels/4.Boutique Hotel am Stephansplatz.4.jpg" ,CityId = 10, StarsNo= 4},
                new Hotel {Id = 75, Name = "BoutiqueHOTEL Donauwalzer",Image = "CitiesHotels/ViennaHotels/5.BoutiqueHOTEL Donauwalzer.3.jpg" ,CityId = 10, StarsNo= 3},
                new Hotel {Id = 76, Name = "Hotel Imperial Vienna",Image = "CitiesHotels/ViennaHotels/6.Hotel Imperial Vienna.5.jpg" ,CityId = 10, StarsNo= 5},
                new Hotel {Id = 77, Name = " Hotel Rathaus Wein & Design",Image = "CitiesHotels/ViennaHotels/7.Hotel Rathaus Wein & Design.4.jpg" ,CityId = 10, StarsNo= 4},
                new Hotel {Id = 78, Name = "Andaz Vienna Am Belvedere",Image = "CitiesHotels/ViennaHotels/8.Andaz Vienna Am Belvedere.5.jpg" ,CityId = 10, StarsNo= 5},
                new Hotel {Id = 79, Name = "Hollmann Beletage Design & Boutique",Image = "CitiesHotels/ViennaHotels/9.Hollmann Beletage Design & Boutique.4.jpg" ,CityId = 10, StarsNo= 4},
                new Hotel {Id = 80, Name = " Hilton Vienna Plaza",Image = "CitiesHotels/ViennaHotels/10.Hilton Vienna Plaza.5.jpg" ,CityId = 10, StarsNo= 5},



                new Hotel {Id = 81, Name = "Corpo Santo Historical",Image = "CitiesHotels/LisbonHotels/1.Corpo Santo Historical.5.jpg" ,CityId = 8, StarsNo= 5},
                new Hotel {Id = 82, Name = "Hotel Da Baixa",Image = "CitiesHotels/LisbonHotels/2.Hotel Da Baixa.4.jpg" ,CityId = 8, StarsNo= 4},
                new Hotel {Id = 83, Name = "Hotel Avenida Palace",Image = "CitiesHotels/LisbonHotels/3.Hotel Avenida Palace.5.jpg" ,CityId = 8, StarsNo= 5},
                new Hotel {Id = 84, Name = "Blue Liberdade",Image = "CitiesHotels/LisbonHotels/4.Blue Liberdade.3.jpg" ,CityId = 8, StarsNo= 3},
                new Hotel {Id = 85, Name = " Jupiter Lisboa ",Image = "CitiesHotels/LisbonHotels/5.Jupiter Lisboa.4.jpg" ,CityId = 8, StarsNo= 4},
                new Hotel {Id = 86, Name = "Hotel Santa Justa",Image = "CitiesHotels/LisbonHotels/6.Hotel Santa Justa.4.jpg" ,CityId = 8, StarsNo= 4},
                new Hotel {Id = 87, Name = "Republica Bed & Breakfast & Arts",Image = "CitiesHotels/LisbonHotels/7.Republica Bed & Breakfast & Arts.3.jpg" ,CityId = 8, StarsNo=3},
                new Hotel {Id = 88, Name = "Hotel Britania Art Deco",Image = "CitiesHotels/LisbonHotels/8.Hotel Britania Art Deco.4.jpg" ,CityId = 8, StarsNo= 4},
                new Hotel {Id = 89, Name = "1908 Lisboa",Image = "CitiesHotels/LisbonHotels/9.1908 Lisboa.4.jpg" ,CityId = 8, StarsNo= 4},
                new Hotel {Id = 90, Name = "Brown's Central",Image = "CitiesHotels/LisbonHotels/10.Brown's Central.4.jpg" ,CityId = 8, StarsNo= 4},





                new Hotel {Id = 91, Name = "The Resident Liverpool",Image = "CitiesHotels/LiverpoolHotels/1.The Resident Liverpool.4.jpg" ,CityId = 3, StarsNo= 4},
                new Hotel {Id = 92, Name = "Hope Street Hotel",Image = "CitiesHotels/LiverpoolHotels/2.Hope Street Hotel.4.jpg" ,CityId = 3, StarsNo= 4},
                new Hotel {Id = 93, Name = "Pullman Liverpool",Image = "CitiesHotels/LiverpoolHotels/3.Pullman Liverpool.4.jpg" ,CityId = 3, StarsNo= 4},
                new Hotel {Id = 94, Name = "INNSiDE by Melia Liverpool",Image = "CitiesHotels/LiverpoolHotels/4.INNSiDE by Melia Liverpool.4.jpg" ,CityId = 3, StarsNo= 4},
                new Hotel {Id = 95, Name = "Titanic Hotel Liverpool",Image = "CitiesHotels/LiverpoolHotels/5.Titanic Hotel Liverpool.4.jpg" ,CityId = 3, StarsNo= 4},
                new Hotel {Id = 96, Name = "Quest Liverpool City Centre",Image = "CitiesHotels/LiverpoolHotels/6.Quest Liverpool City Centre.4.jpg" ,CityId = 3, StarsNo= 4},
                new Hotel {Id = 97, Name = "Novotel Liverpool Paddington Village",Image = "CitiesHotels/LiverpoolHotels/7.Novotel Liverpool Paddington Village.4.jpg" ,CityId = 3, StarsNo= 4},
                new Hotel {Id = 98, Name = "Hard Days Night Hotel",Image = "CitiesHotels/LiverpoolHotels/8.Hard Days Night Hotel.4.jpg" ,CityId = 3, StarsNo= 4},
                new Hotel {Id = 99, Name = "Malmaison Liverpool",Image = "CitiesHotels/LiverpoolHotels/9.Malmaison Liverpool.4.jpg" ,CityId = 3, StarsNo= 4},
                new Hotel {Id = 100, Name = "Travelodge Liverpool Central",Image = "CitiesHotels/LiverpoolHotels/10.Travelodge Liverpool Central.3.jpg" ,CityId = 3, StarsNo= 3},






                new Hotel {Id = 101, Name = "Hotel Artemide",Image = "CitiesHotels/RomeHotels/1.Hotel Artemide.4.jpg" ,CityId = 4, StarsNo= 4},
                new Hotel {Id = 102, Name = "Hotel Colosseum",Image = "CitiesHotels/RomeHotels/2.Hotel Colosseum.3.jpg" ,CityId = 4, StarsNo= 3},

                new Hotel {Id = 103, Name = "Hotel Barocco",Image = "CitiesHotels/RomeHotels/3.Hotel Barocco.4.jpg" ,CityId = 4, StarsNo= 4},

                new Hotel {Id = 104, Name = "Hotel Santa Maria",Image = "CitiesHotels/RomeHotels/4.Hotel Santa Maria.3.jpg " ,CityId = 4, StarsNo= 3},

                new Hotel {Id = 105, Name = "iQ Hotel Roma",Image = "CitiesHotels/RomeHotels/5.iQ Hotel Roma.4.jpg" ,CityId = 4, StarsNo= 4},

                new Hotel {Id = 106, Name = "Domidea Hotel",Image = "CitiesHotels/RomeHotels/6.Domidea Hotel.4.jpg" ,CityId = 4, StarsNo= 4},

                new Hotel {Id = 107, Name = "Dharma Boutique Hotel & Spa",Image = "CitiesHotels/RomeHotels/7.Dharma Boutique Hotel & Spa.4.jpg" ,CityId = 4, StarsNo= 4},

                new Hotel {Id = 108, Name = "Rome Life Hotel",Image = "CitiesHotels/RomeHotels/8.Rome Life Hotel.4.jpg" ,CityId = 4, StarsNo= 4},

                new Hotel {Id = 109, Name = "Hotel Savoy Roma",Image = "CitiesHotels/RomeHotels/9.Hotel Savoy Roma.4.jpg" ,CityId = 4, StarsNo= 4},

                new Hotel {Id = 110, Name = "Roma Palazzo Cinquecento",Image = "CitiesHotels/RomeHotels/10.Roma Palazzo Cinquecento.5.jpg" ,CityId = 4, StarsNo= 5},




                new Hotel {Id = 111, Name = "Bank Hotel",Image = "CitiesHotels/StockholmHotels/1.Bank Hotel.5.jpg" ,CityId = 9, StarsNo= 5},
                new Hotel {Id = 112, Name = "Hotel Rival",Image = "CitiesHotels/StockholmHotels/2.Hotel Rival.4.jpg" ,CityId = 9, StarsNo= 4},
                new Hotel {Id = 113, Name = " Nordic Light Hotel ",Image = "CitiesHotels/StockholmHotels/3.Nordic Light Hotel.4.jpg" ,CityId = 9, StarsNo= 4},
                new Hotel {Id = 114, Name = "Grand Hotel",Image = "CitiesHotels/StockholmHotels/4.Grand Hotel.5.jpg" ,CityId = 9, StarsNo= 5},
                new Hotel {Id = 115, Name = "Downtown Camper by Scandic",Image = "CitiesHotels/StockholmHotels/5.Downtown Camper by Scandic.4.jpg" ,CityId = 9, StarsNo= 4},
                new Hotel {Id = 116, Name = "Freys Hotel",Image = "CitiesHotels/StockholmHotels/6.Freys Hotel.4.jpg" ,CityId = 9, StarsNo= 4},
                new Hotel {Id = 117, Name = "Radisson Blu Waterfront",Image = "CitiesHotels/StockholmHotels/7.Radisson Blu Waterfront.4.jpg" ,CityId = 9, StarsNo= 4},
                new Hotel {Id = 118, Name = "Berns Hotel",Image = "CitiesHotels/StockholmHotels/8.Berns Hotel.4.jpg" ,CityId = 9, StarsNo= 4},
                new Hotel {Id = 119, Name = "Motel L Hammarby Sjostad",Image = "CitiesHotels/StockholmHotels/9.Motel L Hammarby Sjostad.3.jpg" ,CityId = 9, StarsNo= 3},
                new Hotel {Id = 120, Name = "Haymarket by Scandic",Image = "CitiesHotels/StockholmHotels/10.Haymarket by Scandic.4.jpg" ,CityId = 9, StarsNo= 4},


            };



       



            builder.HasData(hotels);

        }
    }
}
