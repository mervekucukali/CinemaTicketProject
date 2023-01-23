using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketProject
{
    public partial class MovieScreen : Form
    {
        int movieId = 0;
        MovieProccess MovieProccess = new MovieProccess();
        public MovieScreen()
        {
            InitializeComponent();
        }
        public void movieList()
        {
            movielistLb.Items.Clear();

            foreach (var movie in MovieProccess.List().ToList())
            {
                movielistLb.Items.Add(movie.Id + "  " + movie.MovieName );

            }
        }

        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();

            if (!String.IsNullOrWhiteSpace(movienameTxt.Text) && !String.IsNullOrWhiteSpace(movieTheaterCmb.Text) && !String.IsNullOrWhiteSpace(movietimeTxt.Text)  && ticketpricenum.Value > 0)
            {
                movie.Id = Convert.ToInt32(movieIdLbl.Text);
                movie.MovieName = movienameTxt.Text;
                movie.TheaterName = movieTheaterCmb.Text;
                movie.MovieTime = movietimeTxt.Text;
                movie.TicketPrice = Convert.ToDouble(ticketpricenum.Value);

                if (MovieProccess.Add(movie))
                {

                    MessageBox.Show("Movie Add Successful");
                    movieId++;
                    movieIdLbl.Text = movieId.ToString();
                    movienameTxt.Clear();
                    movietimeTxt.Clear();
                    ticketpricenum.Value = 0;
                    movienameTxt.Focus();
                    movieList();
                }
                else
                {
                    MessageBox.Show("Movie Add Failed");
                }
            }
            else
            {
                MessageBox.Show("Values cannot be empty");
            }
        }

        private void MovieScreen_Load(object sender, EventArgs e)
        {
            movieId++;
            movieIdLbl.Text = movieId.ToString();
        }

        private void deleteMovieBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(deleteMovieNud.Value);
            if (MovieProccess.Delete(id))
            {
                MessageBox.Show("Movie Delete Successful");
                movieList();
            }
            else
            {
                MessageBox.Show("Not Found Movie");
            }
        }

        private void getmovieBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(movieDetailNud.Value);
            Movie movie = MovieProccess.Detail(id);

            if (movie != null)
            {
                getMovieIdLbl.Text = movie.Id.ToString();
                getMovieNameLbl.Text = movie.MovieName;
                getMovieTheaterLbl.Text = movie.TheaterName;
                getMovieTimeLbl.Text = movie.MovieTime;
                getMovieTicketPriceLbl.Text = movie.TicketPrice + " TL";

                MessageBox.Show("Movie Found Successful");
            }
            else
            {
                MessageBox.Show("Not Found Movie");
            }
        }

      
    }
}
