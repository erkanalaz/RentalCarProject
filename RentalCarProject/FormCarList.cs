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
    public partial class FormCarList : Form
    {
        RentalCar rentalCar=new RentalCar();
        public FormCarList()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow carListRow = dgvCarList.CurrentRow;
            tbxLicensePlate.Text = carListRow.Cells["LicencePlate"].Value.ToString();
            tbxKm.Text = carListRow.Cells["Km"].Value.ToString();
            tbxColor.Text = carListRow.Cells["Color"].Value.ToString();
            tbxRentalPrice.Text = carListRow.Cells["RentalPrice"].Value.ToString();
            cbxBrand.Text = carListRow.Cells["Brand"].Value.ToString();
            cbxPetrol.Text = carListRow.Cells["Petrol"].Value.ToString();
            cbxSerie.Text = carListRow.Cells["Serie"].Value.ToString();
            tbxModel.Text = carListRow.Cells["Model"].Value.ToString();
            pbxCarList.ImageLocation = carListRow.Cells["Picture"].Value.ToString();



        }

        private void FormCarList_Load(object sender, EventArgs e)
        {
            CarList();
            cbxCarFilter.SelectedIndex = 0;

        }

        private void CarList()
        {
            string carListQuery = "select * from Cars";
            SqlDataAdapter carListDataAdapter = new SqlDataAdapter();
            dgvCarList.DataSource = rentalCar.list(carListDataAdapter, carListQuery);
        }

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbxCarList.ImageLocation = openFileDialog1.FileName;
        }

        private void btnCarListUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow carListRow = dgvCarList.CurrentRow;
            string carListUpdateQuery =
                "update cars set LicencePlate=@LicencePlate,Brand=@Brand,Serie=@Serie, Model=@Model, Color=@Color, Km=@Km,Petrol=@Petrol, RentalPrice=@RentalPrice, Picture=@Picture,Date=@Date where LicencePlate='"+carListRow.Cells["LicencePlate"].Value.ToString()+"'";
            SqlCommand carListCommand=new SqlCommand();
            carListCommand.Parameters.AddWithValue("@LicencePlate",tbxLicensePlate.Text);
            carListCommand.Parameters.AddWithValue("@Brand",cbxBrand.Text);
            carListCommand.Parameters.AddWithValue("@Serie",cbxSerie.Text);
            carListCommand.Parameters.AddWithValue("@Model",tbxModel.Text);
            carListCommand.Parameters.AddWithValue("@Color",tbxColor.Text);
            carListCommand.Parameters.AddWithValue("@Km",tbxKm.Text);
            carListCommand.Parameters.AddWithValue("@Petrol",cbxPetrol.Text);
            carListCommand.Parameters.AddWithValue("@RentalPrice",int.Parse(tbxRentalPrice.Text)); 
            carListCommand.Parameters.AddWithValue("@Picture",pbxCarList.ImageLocation);
            carListCommand.Parameters.AddWithValue("@Date",DateTime.Now.ToString()); 
            
            rentalCar.add_delete_update(carListCommand,carListUpdateQuery);
            cbxSerie.Items.Clear();
            foreach (Control item in Controls)
            {
                if (item is TextBox | item is ComboBox)
                {
                    item.Text = "";
                }
            }

            pbxCarList.ImageLocation = "";
            CarList();

        }

        private void btnCarListDelete_Click(object sender, EventArgs e)
        {
            string carListDeleteQuery = "delete from Cars where LicencePlate='" +
                                        dgvCarList.CurrentRow.Cells["LicencePlate"].Value.ToString() + "'";
            SqlCommand carListDeleteCommand=new SqlCommand();
            rentalCar.add_delete_update(carListDeleteCommand,carListDeleteQuery);
            cbxSerie.Items.Clear();
            foreach (Control item in Controls)
            {
                if (item is TextBox | item is ComboBox)
                {
                    item.Text = "";
                }
            }

            pbxCarList.ImageLocation = "";
            CarList();
        }

        private void cbxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbxSerie.Items.Clear();
                if (cbxBrand.SelectedIndex == 0)
                {
                    cbxSerie.Items.Add("A4");
                    cbxSerie.Items.Add("A5");
                    cbxSerie.Items.Add("A6");
                    cbxSerie.Items.Add("Q7");


                }
                else if (cbxBrand.SelectedIndex == 1)
                {
                    cbxSerie.Items.Add("X3");
                    cbxSerie.Items.Add("318");
                    cbxSerie.Items.Add("520");
                    cbxSerie.Items.Add("740");
                }
                else if (cbxBrand.SelectedIndex == 2)
                {
                    cbxSerie.Items.Add("Fiorino");
                    cbxSerie.Items.Add("Linea");
                    cbxSerie.Items.Add("Egea");
                    cbxSerie.Items.Add("Doblo");
                }
                else if (cbxBrand.SelectedIndex == 3)
                {
                    cbxSerie.Items.Add("Focus");
                    cbxSerie.Items.Add("Fiesta");
                    cbxSerie.Items.Add("Mondeo");
                    cbxSerie.Items.Add("Kuga");
                }
                else if (cbxBrand.SelectedIndex == 4)
                {
                    cbxSerie.Items.Add("Civic");
                    cbxSerie.Items.Add("CRV");
                    cbxSerie.Items.Add("Jazz");
                    cbxSerie.Items.Add("Accord");
                }
                else if (cbxBrand.SelectedIndex == 5)
                {
                    cbxSerie.Items.Add("E200");
                    cbxSerie.Items.Add("C180");
                    cbxSerie.Items.Add("CLA200");
                    cbxSerie.Items.Add("CLS220");
                }
                else if (cbxBrand.SelectedIndex == 6)
                {
                    cbxSerie.Items.Add("Astra");
                    cbxSerie.Items.Add("Vectra");
                    cbxSerie.Items.Add("Corsa");
                    cbxSerie.Items.Add("GrandlandX");
                }
            }
            catch
            {
                ;
            }
        }

        private void cbxCarFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tüm Araçlar
            // Kiralanan Araçlar
            // Garajdaki Aralar

            try
            {
                if (cbxCarFilter.SelectedIndex==0)
                {
                    CarList();
                }
                else if (cbxCarFilter.SelectedIndex==1)
                {
                    string carFilterQuery = "select * from Cars where Status='DOLU'";
                    SqlDataAdapter carFilterDataAdapter=new SqlDataAdapter();
                    dgvCarList.DataSource = rentalCar.list(carFilterDataAdapter, carFilterQuery);

                }
                else if (cbxCarFilter.SelectedIndex == 2)
                {
                    string carFilterQuery = "select * from Cars where Status='BOŞ'";
                    SqlDataAdapter carFilterDataAdapter = new SqlDataAdapter();
                    dgvCarList.DataSource = rentalCar.list(carFilterDataAdapter, carFilterQuery);

                }
            }
            catch 
            { ; }
            
        }
    }
    
}
