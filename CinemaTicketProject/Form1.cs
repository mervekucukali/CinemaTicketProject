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
    public partial class Form1 : Form
    {
        bool status = false;

        User user = new User()
        {

            Name = "Merve",
            Surname = "Küçükali",
            UserName = "merve",
            Password = "123",
            Email = "merve@gmail.com"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DbContext.UserList.Add(user);


            foreach (var users in DbContext.UserList.ToList())
            {
                if (userNameTxt.Text == users.UserName.ToString() && passwordTxt.Text == users.Password.ToString())
                {

                    status = true;
                  

                }
            }

            if (status)
            {
                MessageBox.Show("Hello Merve Welcome to System");
                SelectionScreen selectionScreen = new SelectionScreen();
                this.Hide();
                selectionScreen.ShowDialog();
                this.Show();
               
                status = false;
            }
            else
            {
                MessageBox.Show("Login Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
