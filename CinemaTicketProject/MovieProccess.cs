using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketProject
{
    internal class MovieProccess : ICrud<Movie>
    {
        public bool Add(Movie obj)
        {
            Movie movie = obj;
            if (movie != null)
            {
                DbContext.MovieList.Add(movie);
                return true;
            }
            else return false;
        }

        public bool Delete(int id)
        {
            bool IsDelete = false;
            foreach (var movie in DbContext.MovieList.ToList())
            {
                if (movie.Id == id)
                {
                    DbContext.MovieList.Remove(movie);
                    IsDelete = true;
                    break;
                }
            }

            return IsDelete;
        }

        public Movie Detail(int id)
        {
            Movie movieDetail = null;
            foreach (var movie in DbContext.MovieList.ToList())
            {
                if (movie.Id == id)
                {
                    movieDetail = movie;
                    break;
                }
            }

            return movieDetail;
        }

        public List<Movie> List()
        {
            List<Movie> movies = DbContext.MovieList.ToList();
            return movies;
        }
    }
}
