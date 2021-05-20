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
    public partial class FormCarAdd : Form
    {
        RentalCar rentalCar=new RentalCar();
        public FormCarAdd()
        {
            InitializeComponent();

            string brandListQuery = "select BrandName from Brands";
            SqlDataAdapter sqlDataAdapter=new SqlDataAdapter();
            rentalCar.getBrandsFromDatabase(cbxBrand,brandListQuery);




        }

        private void button1_Click(object sender, EventArgs e) //Car Add button
        {
            SqlCommand carAddSqlCommand=new SqlCommand();   
            string carAddSqlQuery = "insert into Cars(LicencePlate,Brand,Serie,Model,Color,Km,Petrol,RentalPrice,Picture,Date,Status) values(@LicencePlate,@Brand,@Serie,@Model,@Color,@Km,@Petrol,@RentalPrice,@Picture,@Date,@Status)";
            carAddSqlCommand.Parameters.AddWithValue("@LicencePlate", tbxLicensePlate.Text);
            carAddSqlCommand.Parameters.AddWithValue("@Brand", cbxBrand.Text);
            carAddSqlCommand.Parameters.AddWithValue("@Serie", cbxSerie.Text);
            carAddSqlCommand.Parameters.AddWithValue("@Model", tbxModel.Text);
            carAddSqlCommand.Parameters.AddWithValue("@Color", tbxColor.Text);
            carAddSqlCommand.Parameters.AddWithValue("@Km", tbxKm.Text);
            carAddSqlCommand.Parameters.AddWithValue("@Petrol", cbxPetrol.Text);
            carAddSqlCommand.Parameters.AddWithValue("@RentalPrice", tbxRentalPrice.Text);
            carAddSqlCommand.Parameters.AddWithValue("@Picture", pbxCarAdd.ImageLocation);
            carAddSqlCommand.Parameters.AddWithValue("@Date", DateTime.Now.ToString());
            carAddSqlCommand.Parameters.AddWithValue("@Status", "BOŞ");

            rentalCar.add_delete_update(carAddSqlCommand,carAddSqlQuery);

            cbxSerie.Items.Clear();
            foreach (Control item in Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }

            pbxCarAdd.ImageLocation = "";

            MessageBox.Show("Araç veri tabanına başarıyla kaydedildi!");
        }

        private void button3_Click(object sender, EventArgs e) //Car Picture Add Button
        {
            openFileDialog1.ShowDialog();
            pbxCarAdd.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cbxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbxSerie.Items.Clear();
            //string serieListQuery = "select SeriName from Series inner join Brands on Series.BrandId=Brands.Id";
            string serieListQuery = "select SeriName from Series where BrandId=(select Id from Brands where BrandName='" + cbxBrand.SelectedItem+"' )";
            rentalCar.getSeriesFromDb(cbxSerie, serieListQuery);

        }
        private void cbxSerie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChangeBrands_Click(object sender, EventArgs e)
        {
            FormBrands formBrands=new FormBrands();
            formBrands.ShowDialog();
        }
    }
}
