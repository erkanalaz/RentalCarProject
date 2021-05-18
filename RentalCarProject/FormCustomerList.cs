using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace RentalCarProject
{
    public partial class FormCustomerList : Form
    {
        RentalCar rentalCar=new RentalCar();
        public FormCustomerList()
        {
            InitializeComponent();
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            CustomerList();
        }

        private void CustomerList()
        {
            string customerListQuery = "select * from Customers";
            SqlDataAdapter customerDataAdapter = new SqlDataAdapter();

            dgvCustomerList.DataSource = rentalCar.list(customerDataAdapter, customerListQuery);
            dgvCustomerList.Columns[0].HeaderText = "S.Nu.";
            dgvCustomerList.Columns[1].HeaderText = "TC Kimlik Nu.";
            dgvCustomerList.Columns[2].HeaderText = "Adı Soyadı";
            dgvCustomerList.Columns[3].HeaderText = "Telefonu";
            dgvCustomerList.Columns[4].HeaderText = "Adresi";

        }

        private void button1_Click(object sender, EventArgs e) //customer update button
        {
            string customerUpdateQuery =
                "update Customers set CustomerName=@CustomerName, PhoneNumber=@PhoneNumber, Address=@Address, Email=@Email where IdNumber='"+tbxIdNumber.Text+"'";
            SqlCommand customerUpdateSqlCommand=new SqlCommand();
            customerUpdateSqlCommand.Parameters.AddWithValue("@CustomerName", tbxCustomerName.Text);
            customerUpdateSqlCommand.Parameters.AddWithValue("@PhoneNumber", tbxPhoneNumber.Text);
            customerUpdateSqlCommand.Parameters.AddWithValue("@Address", tbxAddress.Text);
            customerUpdateSqlCommand.Parameters.AddWithValue("@Email", tbxEmail.Text);

            rentalCar.add_delete_update(customerUpdateSqlCommand,customerUpdateQuery);

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                } 
            }

            CustomerList();

        }

        private void button2_Click(object sender, EventArgs e) //customerlist iptal butonu
        {
            this.Close();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string customerSearchQuery = "select * from Customers where IdNumber='" + tbxSearch.Text + "'";
            SqlDataAdapter customerSearchDataAdapter=new SqlDataAdapter();
            dgvCustomerList.DataSource=rentalCar.list(customerSearchDataAdapter, customerSearchQuery);
        }

        private void dgvCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow customerRow = dgvCustomerList.CurrentRow;
            tbxIdNumber.Text = customerRow.Cells[1].Value.ToString();
            tbxCustomerName.Text = customerRow.Cells[2].Value.ToString();
            tbxPhoneNumber.Text = customerRow.Cells[3].Value.ToString();
            tbxAddress.Text = customerRow.Cells[4].Value.ToString();
            tbxEmail.Text= customerRow.Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)  //CustomerList delete button
        {
            DataGridViewRow customerDeleteRow = dgvCustomerList.CurrentRow;
            string customerDeleteQuery="delete from Customers where IdNumber='"+customerDeleteRow.Cells[1].Value.ToString()+"'";
            SqlCommand customerDeleteSqlCommand=new SqlCommand();
            rentalCar.add_delete_update(customerDeleteSqlCommand,customerDeleteQuery);
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
;                }
            }
            CustomerList();
        }
    }
}
