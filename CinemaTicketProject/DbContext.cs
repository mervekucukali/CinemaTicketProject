using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketProject
{
    internal class DbContext
    {
        public static List<User> UserList = new List<User>();
        public static List<Customer> CustomerList = new List<Customer>();
        public static List<Movie> MovieList = new List<Movie>();
        public static List<Theater> TheaterList = new List<Theater>();
        

        public DbContext()
        {
            Theater theater = new Theater()
            {
                Id = 1,
                MovieId = 1,
                SeatQuantity = 50,
                IsStatus = true,

            };
            TheaterList.Add(theater);

            Theater theater1 = new Theater()
            {
                Id = 2,
                MovieId = 2,
                SeatQuantity = 50,
                IsStatus = true,
            };
            TheaterList.Add(theater1);

            Theater theater2 = new Theater()
            {
                Id = 3,
                MovieId = 3,
                SeatQuantity = 50,
                IsStatus = true,
            };
            TheaterList.Add(theater2);

            Movie movie = new Movie()
            {
                Id = 1,
                MovieName = "Ice Age",
                MovieTime = "14:00",
                TheaterName = "Theater 1",
                TicketPrice = 40,
                IsStatus = true,

            };
            DbContext.MovieList.Add(movie);

            Movie movie1 = new Movie()
            {
                Id = 2,
                MovieName = "Lucy",
                MovieTime = "17:00",
                TheaterName = "Theater 2",
                TicketPrice = 40,
                IsStatus = true,

            };
            DbContext.MovieList.Add(movie1);

            Movie movie2 = new Movie()
            {
                Id = 3,
                MovieName = "Interstellar",
                MovieTime = "20:00",
                TheaterName = "Theater 3",
                TicketPrice = 40,
                IsStatus = true,

            };
            DbContext.MovieList.Add(movie2);
        }

    }


}
