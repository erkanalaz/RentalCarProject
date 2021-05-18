using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentalCarProject
{
    public partial class FormCustomerAdd : Form
    {
        RentalCar rentalCar=new RentalCar();
        public FormCustomerAdd()
        {
            InitializeComponent();
        }

        private void FormCustomerAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  //CustomerAddButton
        {
            SqlCommand customerAddCommand=new SqlCommand();
            string customerAddQuery = "insert into Customers (IdNumber,CustomerName,PhoneNumber,Address,Email) values(@IdNumber,@CustomerName,@PhoneNumber,@Address,@Email)";

            customerAddCommand.Parameters.AddWithValue("@IdNumber", tbxIdNumber.Text);
            customerAddCommand.Parameters.AddWithValue("@CustomerName", tbxCustomerName.Text);
            customerAddCommand.Parameters.AddWithValue("@PhoneNumber", tbxPhoneNumber.Text);
            customerAddCommand.Parameters.AddWithValue("@Address", tbxAddress.Text);
            customerAddCommand.Parameters.AddWithValue("@Email", tbxEmail.Text);

            rentalCar.add_delete_update(customerAddCommand,customerAddQuery);

            foreach (Control item in Controls)  //formdaki textboxları temizle
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            MessageBox.Show("Müşteri veri tabanına başarıyla kaydedildi!");
        }

        private void button2_Click(object sender, EventArgs e)  //CloseButton
        {
            this.Close();
        }
    }
}
