using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TimeSpan = System.TimeSpan;

namespace RentalCarProject
{
    public partial class FormContract : Form
    {
        public FormContract()
        {
            InitializeComponent();
        }

        RentalCar rentalCar=new RentalCar();
        private void FormContract_Load(object sender, EventArgs e)
        {
            CarsInGarage();

            ContractsList();
        }

        private void ContractsList()
        {
            string contractListQuery = "select * from Contracts";
            SqlDataAdapter contractDataAdapter = new SqlDataAdapter();
            dgvContract.DataSource = rentalCar.list(contractDataAdapter, contractListQuery);
        }

        private void CarsInGarage()
        {
            string contractQuery = "select * from Cars ";  //where Status='BOŞ'
            rentalCar.carsInGarage(cbxCars, contractQuery);
        }

        private void cbxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            string contractCarListQuery= "select * from Cars where LicencePlate like '" + cbxCars.SelectedItem + "' ";
            rentalCar.getCarsFromCbx(cbxCars,tbxBrand,tbxSerie,tbxModel,tbxColor,contractCarListQuery);
        }

        private void cbxRentalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rentalTypeQuery = "select * from Cars where LicencePlate like '" + cbxCars.SelectedItem + "' ";
            rentalCar.totalPriceCalculate(cbxRentalType,tbxRentalPrice,rentalTypeQuery);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Parse(dtpGiveBack.Text) - DateTime.Parse(dtpGiveIn.Text);
            int day = timeSpan.Days;
            tbxRentalDay.Text = day.ToString();
            tbxRentalTotalPrice.Text = (day * int.Parse(tbxRentalPrice.Text)).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            dtpGiveIn.Text = DateTime.Now.ToShortDateString();
            dtpGiveBack.Text = DateTime.Now.ToShortDateString();
            cbxRentalType.Text = "";
            tbxRentalPrice.Text = "";
            tbxRentalDay.Text = "";
            tbxRentalTotalPrice.Text = "";
        }

        private void btnContractSave_Click(object sender, EventArgs e)
        {
            string contractSaveQuery = "insert into Contracts(IdNumber,CustomerName,PhoneNumber,LicenceNumber,LicenceDate,LicencePlace,LicencePlate,Brand,Serie,Model,Color,RentalType,RentalPrice,RentalDay,RentalTotalDate,GiveInDate,GiveBackDate) values (@IdNumber,@CustomerName,@PhoneNumber,@LicenceNumber,@LicenceDate,@LicencePlace,@LicencePlate,@Brand,@Serie,@Model,@Color,@RentalType,@RentalPrice,@RentalDay,@RentalTotalDate,@GiveInDate,@GiveBackDate)";
            SqlCommand contractSaveCommand = new SqlCommand();
            contractSaveCommand.Parameters.AddWithValue("@IdNumber", tbxIdNumber.Text);
            contractSaveCommand.Parameters.AddWithValue("@CustomerName", tbxCustomerName.Text);
            contractSaveCommand.Parameters.AddWithValue("@PhoneNumber", tbxPhone.Text);
            contractSaveCommand.Parameters.AddWithValue("@LicenceNumber", tbxLicenceNumber.Text);
            contractSaveCommand.Parameters.AddWithValue("@LicenceDate", tbxLicenceDate.Text);
            contractSaveCommand.Parameters.AddWithValue("@LicencePlace", tbxLicencePlace.Text);
            contractSaveCommand.Parameters.AddWithValue("@LicencePlate", cbxCars.Text);
            contractSaveCommand.Parameters.AddWithValue("@Brand", tbxBrand.Text);
            contractSaveCommand.Parameters.AddWithValue("@Serie", tbxSerie.Text);
            contractSaveCommand.Parameters.AddWithValue("@Model", tbxModel.Text);
            contractSaveCommand.Parameters.AddWithValue("@Color", tbxColor.Text);
            contractSaveCommand.Parameters.AddWithValue("@RentalType", cbxRentalType.Text);
            contractSaveCommand.Parameters.AddWithValue("@RentalPrice", int.Parse(tbxRentalPrice.Text));
            contractSaveCommand.Parameters.AddWithValue("@RentalDay", int.Parse(tbxRentalDay.Text));
            contractSaveCommand.Parameters.AddWithValue("@RentalTotalDate", int.Parse(tbxRentalTotalPrice.Text));
            contractSaveCommand.Parameters.AddWithValue("@GiveInDate", dtpGiveIn.Text);
            contractSaveCommand.Parameters.AddWithValue("@GiveBackDate", dtpGiveBack.Text);

            rentalCar.add_delete_update(contractSaveCommand, contractSaveQuery);

            string changeStatusQuery="update Cars set Status='DOLU' where LicencePlate like '"+cbxCars.Text+"'";
            SqlCommand changeStatusCommand=new SqlCommand();
            rentalCar.add_delete_update(changeStatusCommand,changeStatusQuery);

            cbxCars.Items.Clear();
            CarsInGarage();
            ContractsList();

            foreach (Control item in Controls)
            {
                if (item is TextBox | item is ComboBox)
                {
                    item.Text = "";
                }
            }

            cbxCars.Items.Clear();
            Clear();

            MessageBox.Show("Sözleşme başarılı bir şekilde oluşturuldu.");


        }

        private void tbxIdSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxIdSearch.Text=="")
            {
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            string idSearchQuery="select * from Customers where IdNumber like '"+tbxIdSearch.Text+"'";
            rentalCar.searchByIdNumber(tbxIdSearch,tbxIdNumber,tbxCustomerName,tbxPhone,idSearchQuery);
        }

        private void btnContractUpdate_Click(object sender, EventArgs e)
        {
            string contractUpdateQuery = "update Contracts set IdNumber=@IdNumber,CustomerName=@CustomerName,PhoneNumber=@PhoneNumber,LicenceNumber=@LicenceNumber,LicenceDate=@LicenceDate,LicencePlace=@LicencePlace,LicencePlate=@LicencePlate,Brand=@Brand,Serie=@Serie,Model=@Model,Color=@Color,RentalType=@RentalType,RentalPrice=@RentalPrice,RentalDay=@RentalDay,RentalTotalDate=@RentalTotalDate,GiveInDate=@GiveInDate,GiveBackDate=@GiveBackDate where LicencePlate=@LicencePlate";
            SqlCommand contractUpdateCommand=new SqlCommand();
            contractUpdateCommand.Parameters.AddWithValue("@IdNumber", tbxIdNumber.Text);
            contractUpdateCommand.Parameters.AddWithValue("@CustomerName", tbxCustomerName.Text);
            contractUpdateCommand.Parameters.AddWithValue("@PhoneNumber", tbxPhone.Text);
            contractUpdateCommand.Parameters.AddWithValue("@LicenceNumber", tbxLicenceNumber.Text);
            contractUpdateCommand.Parameters.AddWithValue("@LicenceDate", tbxLicenceDate.Text);
            contractUpdateCommand.Parameters.AddWithValue("@LicencePlace", tbxLicencePlace.Text);
            contractUpdateCommand.Parameters.AddWithValue("@LicencePlate", cbxCars.Text);
            contractUpdateCommand.Parameters.AddWithValue("@Brand", tbxBrand.Text);
            contractUpdateCommand.Parameters.AddWithValue("@Serie", tbxSerie.Text);
            contractUpdateCommand.Parameters.AddWithValue("@Model", tbxModel.Text);
            contractUpdateCommand.Parameters.AddWithValue("@Color", tbxColor.Text);
            contractUpdateCommand.Parameters.AddWithValue("@RentalType", cbxRentalType.Text);
            contractUpdateCommand.Parameters.AddWithValue("@RentalPrice", int.Parse(tbxRentalPrice.Text));
            contractUpdateCommand.Parameters.AddWithValue("@RentalDay", int.Parse(tbxRentalDay.Text));
            contractUpdateCommand.Parameters.AddWithValue("@RentalTotalDate", int.Parse(tbxRentalTotalPrice.Text));
            contractUpdateCommand.Parameters.AddWithValue("@GiveInDate", dtpGiveIn.Text);
            contractUpdateCommand.Parameters.AddWithValue("@GiveBackDate", dtpGiveBack.Text);
            
            rentalCar.add_delete_update(contractUpdateCommand,contractUpdateQuery);
           
            cbxCars.Items.Clear();
            CarsInGarage();
            ContractsList();

            foreach (Control item in Controls)
            {
                if (item is TextBox | item is ComboBox)
                {
                    item.Text = "";
                }
            }

            cbxCars.Items.Clear();
            Clear();

            MessageBox.Show("Sözleşme başarılı bir şekilde güncellendi.");
        }

        private void dgvContract_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow contractDataGridViewRow = dgvContract.CurrentRow;
            tbxIdNumber.Text = contractDataGridViewRow.Cells[1].Value.ToString();
            tbxCustomerName.Text = contractDataGridViewRow.Cells[2].Value.ToString();
            tbxPhone.Text = contractDataGridViewRow.Cells[3].Value.ToString();
            tbxLicenceNumber.Text = contractDataGridViewRow.Cells[4].Value.ToString();
            tbxLicenceDate.Text = contractDataGridViewRow.Cells[5].Value.ToString();
            tbxLicencePlace.Text = contractDataGridViewRow.Cells[6].Value.ToString();
            cbxCars.Text = contractDataGridViewRow.Cells[7].Value.ToString();
            tbxBrand.Text = contractDataGridViewRow.Cells[8].Value.ToString();
            tbxSerie.Text = contractDataGridViewRow.Cells[9].Value.ToString();
            tbxModel.Text = contractDataGridViewRow.Cells[10].Value.ToString();
            tbxColor.Text = contractDataGridViewRow.Cells[11].Value.ToString();
            cbxRentalType.Text = contractDataGridViewRow.Cells[12].Value.ToString();
            tbxRentalPrice.Text = contractDataGridViewRow.Cells[13].Value.ToString();
            tbxRentalDay.Text = contractDataGridViewRow.Cells[14].Value.ToString();
            tbxRentalTotalPrice.Text = contractDataGridViewRow.Cells[15].Value.ToString();
            dtpGiveIn.Text = contractDataGridViewRow.Cells[16].Value.ToString();
            dtpGiveBack.Text = contractDataGridViewRow.Cells[17].Value.ToString();

        }

        private void dgvContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow contractDataGridViewRow = dgvContract.CurrentRow;
            DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime returnBack = DateTime.Parse(contractDataGridViewRow.Cells["GiveBackDate"].Value.ToString());
            int price = int.Parse(contractDataGridViewRow.Cells["RentalPrice"].Value.ToString());
            TimeSpan ekstraDay = today - returnBack;
            int _ekstraDay = ekstraDay.Days;
            int priceEkstra;
            priceEkstra = _ekstraDay * price;
            tbxCredit.Text = priceEkstra.ToString();
        }

        private void btnCarTakeBack_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxCredit.Text)>=0 || int.Parse(tbxCredit.Text)<0)
            {
                DataGridViewRow contractDataGridViewRow = dgvContract.CurrentRow;
                DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
                int price = int.Parse(contractDataGridViewRow.Cells["RentalPrice"].Value.ToString());
                int totalPrice = int.Parse(contractDataGridViewRow.Cells["RentalTotalDate"].Value.ToString());
                DateTime returnBack = DateTime.Parse(contractDataGridViewRow.Cells["GiveBackDate"].Value.ToString());
                TimeSpan ekstraDay = today - returnBack;
                int _ekstraDay = ekstraDay.Days;
                int _totalPrice= _ekstraDay * price;

                string carTakeBackQuery = "delete from Contracts where LicencePlate='" +
                                          contractDataGridViewRow.Cells["LicencePlate"].Value.ToString() + "'";
                SqlCommand sqlCommand=new SqlCommand();
                rentalCar.add_delete_update(sqlCommand,carTakeBackQuery);

                string carTakeBackStatusQuery = "update cars set Status='BOŞ' where LicencePlate='" +
                                                contractDataGridViewRow.Cells["LicencePlate"].Value.ToString() + "'";
                SqlCommand sqlCommandStatus=new SqlCommand();
                rentalCar.add_delete_update(sqlCommandStatus,carTakeBackStatusQuery);

                string saleQuery = "insert into Sales (IdNumber,CustomerName,LicencePlate,Brand,Serie,Model,Color,RentalDay,RentalPrice,RentalTotalPrice,Date1,Date2) values(@IdNumber,@CustomerName,@LicencePlate,@Brand,@Serie,@Model,@Color,@RentalDay,@RentalPrice,@RentalTotalPrice,@Date1,@Date2)";
                SqlCommand contractSaveCommand = new SqlCommand();
                contractSaveCommand.Parameters.AddWithValue("@IdNumber", tbxIdNumber.Text);
                contractSaveCommand.Parameters.AddWithValue("@CustomerName", tbxCustomerName.Text);
                contractSaveCommand.Parameters.AddWithValue("@LicencePlate", cbxCars.Text);
                contractSaveCommand.Parameters.AddWithValue("@Brand", tbxBrand.Text);
                contractSaveCommand.Parameters.AddWithValue("@Serie", tbxSerie.Text);
                contractSaveCommand.Parameters.AddWithValue("@Model", tbxModel.Text);
                contractSaveCommand.Parameters.AddWithValue("@Color", tbxColor.Text);
                contractSaveCommand.Parameters.AddWithValue("@RentalDay", int.Parse(tbxRentalDay.Text));
                contractSaveCommand.Parameters.AddWithValue("@RentalPrice", int.Parse(tbxRentalPrice.Text));
                contractSaveCommand.Parameters.AddWithValue("@RentalTotalPrice", int.Parse(tbxRentalTotalPrice.Text));
                contractSaveCommand.Parameters.AddWithValue("@Date1", dtpGiveIn.Text);
                contractSaveCommand.Parameters.AddWithValue("@Date2", dtpGiveBack.Text);

                rentalCar.add_delete_update(contractSaveCommand, saleQuery);
                MessageBox.Show("Araç teslim edildi.");

                cbxCars.Text = "";

                cbxCars.Items.Clear();
                CarsInGarage();
                ContractsList();

                foreach (Control item in Controls)
                {
                    if (item is TextBox | item is ComboBox)
                    {
                        item.Text = "";
                    }
                }

                cbxCars.Text = "";
                Clear();
                tbxCredit.Text = "";

            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız.");

            }
        }

        private void dgvContract_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
