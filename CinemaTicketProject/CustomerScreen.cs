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
    public partial class CustomerScreen : Form
    {
        int customerId = 0;
        CustomerProccess CustomerProccess = new CustomerProccess();
        public CustomerScreen()
        {
            InitializeComponent();
        }
        public void customerList()
        {
            customerListLb.Items.Clear();

            foreach (var customer in CustomerProccess.List().ToList())
            {
                customerListLb.Items.Add(customer.Id + "  " + customer.Name + " " + customer.Surname);

            }
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            if (!String.IsNullOrWhiteSpace(customerNameTxt.Text) && !String.IsNullOrWhiteSpace(customerSurnameTxt.Text) && customerBalanceNud.Value > 0)
            {
                customer.Id = Convert.ToInt32(customerIdLbl.Text);
                customer.Name = customerNameTxt.Text;
                customer.Surname = customerSurnameTxt.Text;
                customer.Balance = Convert.ToDouble(customerBalanceNud.Value);

                if (CustomerProccess.Add(customer))
                {

                    MessageBox.Show("Customer Add Successful");
                    customerId++;
                    customerIdLbl.Text = customerId.ToString();
                    customerNameTxt.Clear();
                    customerSurnameTxt.Clear();
                    customerBalanceNud.Value = 0;
                    customerNameTxt.Focus();
                    customerList();
                }
                else
                {
                    MessageBox.Show("Customer Add Failed");
                }
            }
            else
            {
                MessageBox.Show("Values cannot be empty");
            }
        }

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            customerId++;
            customerIdLbl.Text = customerId.ToString();
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(deleteCustomerNud.Value);
            if (CustomerProccess.Delete(id))
            {
                MessageBox.Show("Customer Delete Successful");
                customerList();
            }
            else
            {
                MessageBox.Show("Not Found Customer");
            }
        }

        private void getCustomerBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(customerDetailNud.Value);
            Customer customer = CustomerProccess.Detail(id);

            if (customer != null)
            {
                getCustomerIdLbl.Text = customer.Id.ToString();
                getCustomerNameLbl.Text = customer.Name;
                getCustomerSurnameLbl.Text = customer.Surname;
                getCustomerBalanceLbl.Text = customer.Balance + " TL";

                MessageBox.Show("Customer Found Successful");
            }
            else
            {
                MessageBox.Show("Not Found Customer");
            }
        }


    }
}
