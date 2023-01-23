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
    public partial class SelectionScreen : Form
    {
        public SelectionScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovieAddScreen movieAddScreen = new MovieAddScreen();
            movieAddScreen.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovieScreen movieScreen = new MovieScreen();    
            movieScreen.ShowDialog();
        }
    }
}
