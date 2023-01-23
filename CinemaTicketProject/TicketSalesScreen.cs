using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.LinkLabel;

namespace CinemaTicketProject
{
    public partial class MovieAddScreen : Form
    {
        public MovieAddScreen()
        {
            InitializeComponent();

        }

        private void MovieAddScreen_Load(object sender, EventArgs e)
        {


            DbContext db = new DbContext();
            foreach (var item in DbContext.CustomerList.Select(x => x.Id).Distinct().ToList())
            {
                cuscmb.Items.Add(item.ToString() ?? "" );
                
            }
            foreach (var item in DbContext.MovieList.Select(x => x.MovieName).Distinct().ToList())
            {


                movieNamecmb.Items.Add(item ?? "");

              
            }
            foreach (var item in DbContext.MovieList.Select(x => x.TheaterName).Distinct().ToList())
            {
                movietheaterComb.Items.Add(item ?? "");
               
            }
            foreach (var item in DbContext.MovieList.Select(x => x.MovieTime).Distinct().ToList())
            {
                movietimeComb.Items.Add(item ?? "");
               
            }
        }

        private void movieaddBtn_Click(object sender, EventArgs e)
        {
            DbContext db = new DbContext();


            bool IsCustomer = false;
            foreach (var customer in DbContext.CustomerList.ToList())
            {
                if (customer.Id ==Convert.ToInt32( cuscmb.SelectedItem))
                {
                    IsCustomer = true;
                    break;
                }
                
            }
            foreach (var customers in DbContext.CustomerList.ToList())
            {
                if (IsCustomer)
                {
                    if (customers.Id == Convert.ToInt32(cuscmb.SelectedItem))
                    {

                        foreach (var movie in DbContext.MovieList.ToList())
                        {


                            if (movie.MovieName == movieNamecmb.SelectedItem && movie.TheaterName == movietheaterComb.SelectedItem && movie.MovieTime == movietimeComb.SelectedItem)
                            {
                                foreach (var theater in DbContext.TheaterList.ToList())
                                {
                                    int seat = Convert.ToInt32(ticketQuatityTxt.Text.ToString());



                                    if (movietheaterComb.SelectedIndex == 0)
                                    {
                                        if (theater.Id == 1)
                                        {


                                            if (theater.SeatQuantity >= Convert.ToInt32(ticketQuatityTxt.Text))
                                            {
                                                if (customers.Balance >= (movie.TicketPrice * seat))
                                                {
                                                    customers.Balance -= (movie.TicketPrice * seat);
                                                    theater.SeatQuantity -= Convert.ToInt32(ticketQuatityTxt.Text);
                                                    MessageBox.Show("Ticket sale successful. Remaining Seat: " + theater.SeatQuantity.ToString());

                                                    ticketLb.Items.Add(customers.Id + " Customer: " + customers.Name +" " + customers.Surname + "\t Movie: " + movie.MovieName +
                                                    "\tTheater: " + movie.TheaterName + "\tTotal Price: " + movie.TicketPrice * seat + "\tTransaction Date:" + DateTime.Now.ToString("yyyy.MM.dd") + "     " +
                                                        DateTime.Now.ToString("HH:mm:ss")); 

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Insufficient Balance", "Balance",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                                }
                                                break;
                                            }

                                            else
                                            {
                                                MessageBox.Show("Not Enough Tickets.");
                                            }
                                            break;

                                        }
                                    }
                                    if (movietheaterComb.SelectedIndex == 1)
                                    {
                                        if (theater.Id == 2)
                                        {

                                            if (theater.SeatQuantity >= Convert.ToInt32(ticketQuatityTxt.Text))
                                            {
                                                if (customers.Balance >= (movie.TicketPrice * seat))
                                                {
                                                    customers.Balance -= (movie.TicketPrice * seat);
                                                    theater.SeatQuantity -= Convert.ToInt32(ticketQuatityTxt.Text);
                                                    MessageBox.Show("Ticket sale successful. Remaining Seat: " + theater.SeatQuantity.ToString());

                                                    ticketLb.Items.Add(customers.Id + " Customer: " + customers.Name + " " + customers.Surname + "\t Movie: " + movie.MovieName +
                                                    "\tTheater: " + movie.TheaterName + "\tTotal Price: " + movie.TicketPrice * seat + "\tTransaction Date:" + DateTime.Now.ToString("yyyy.MM.dd") + "     " +
                                                        DateTime.Now.ToString("HH:mm:ss"));
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Insufficient Balance", "Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                                break;

                                            }

                                            else
                                            {
                                                MessageBox.Show("Not Enough Tickets.");
                                            }
                                            break;
                                        }
                                    }
                                    if (movietheaterComb.SelectedIndex == 2)
                                    {
                                        if (theater.Id == 3)
                                        {   

                                            if (theater.SeatQuantity >= Convert.ToInt32(ticketQuatityTxt.Text))
                                            {
                                                if (customers.Balance >= (movie.TicketPrice * seat))
                                                {
                                                    customers.Balance -= (movie.TicketPrice * seat);
                                                    theater.SeatQuantity -= Convert.ToInt32(ticketQuatityTxt.Text);
                                                    MessageBox.Show("Ticket sale successful. Remaining Seat: " + theater.SeatQuantity.ToString());

                                                    ticketLb.Items.Add(customers.Id + " Customer: " + customers.Name + " " + customers.Surname + "\t Movie: " + movie.MovieName +
                                                    "\tTheater: " + movie.TheaterName + "\tTotal Price: " + movie.TicketPrice * seat + "\tTransaction Date:" + DateTime.Now.ToString("yyyy.MM.dd") + "     " +
                                                        DateTime.Now.ToString("HH:mm:ss"));
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Insufficient Balance", "Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                                break;
                                            }

                                            else
                                            {
                                                MessageBox.Show("Not Enough Tickets.");
                                            }
                                            break;
                                        }
                                    }

                                }


                                break;
                            }
                          
                          
                        }
                    }
                   
                }
               
            }

        }

        private void movietheaterComb_SelectedIndexChanged(object sender, EventArgs e)
        {

            movieNamecmb.SelectedIndex = movietheaterComb.SelectedIndex;
            movietimeComb.SelectedIndex = movieNamecmb.SelectedIndex;
        }

        private void movieNamecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            movietheaterComb.SelectedIndex = movieNamecmb.SelectedIndex;
        }

        private void movietimeComb_SelectedIndexChanged(object sender, EventArgs e)
        {
             movieNamecmb.SelectedIndex=movietimeComb.SelectedIndex;
        }

       
    }
}