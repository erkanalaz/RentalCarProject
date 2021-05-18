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
    public partial class FormSale : Form
    {
        RentalCar rentalCar=new RentalCar();
        public FormSale()
        {
            InitializeComponent();
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            string saleQuery = "select * from Sales";
            SqlDataAdapter saleDataAdapter=new SqlDataAdapter();
            dgvSale.DataSource = rentalCar.list(saleDataAdapter, saleQuery);

            rentalCar.totalPriceCalculate(label1);

        }
    }
}
