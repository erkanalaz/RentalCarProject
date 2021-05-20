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
    public partial class FormBrands : Form
    {
        RentalCar rentalCar=new RentalCar();
        public FormBrands()
        {
            InitializeComponent();
        }

        private void FormBrands_Load(object sender, EventArgs e)
        {
            ShowCars();
        }

        private void ShowCars()
        {
            string brandQuery = "select * from Brands";
            SqlDataAdapter brandDataAdapter = new SqlDataAdapter();

            dgvBrands.DataSource = rentalCar.list(brandDataAdapter, brandQuery);
            dgvBrands.Columns[0].HeaderText = "S.Nu";
            dgvBrands.Columns[1].HeaderText = "Marka";
        }

        private void dgvBrands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBrands_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow brandDataGridViewRow = dgvBrands.CurrentRow;
            tbxBrand.Text = brandDataGridViewRow.Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string brandAddQuery = "insert into Brands (BrandName) values('"+tbxBrand.Text+"')";
            SqlCommand sqlCommand=new SqlCommand();
            rentalCar.add_delete_update(sqlCommand,brandAddQuery);

            ShowCars();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string brandDeleteQuery = "delete Brands where BrandName='" + tbxBrand.Text + "'";
            SqlCommand sqlCommand = new SqlCommand();
            rentalCar.add_delete_update(sqlCommand, brandDeleteQuery);

            ShowCars();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dgvBrands.CurrentRow;
            string brandUpdateQuery = "update Brands set BrandName='" + tbxBrand.Text + "' where Id='"+dataGridViewRow.Cells[0].Value.ToString()+"'";
            SqlCommand sqlCommand = new SqlCommand();
            rentalCar.add_delete_update(sqlCommand, brandUpdateQuery);
            ShowCars();
        }
    }
}
