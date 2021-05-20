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
            try
            {
                cbxSerie.Items.Clear();
                if (cbxBrand.SelectedIndex==0)
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
