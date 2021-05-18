using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;


namespace RentalCarProject
{
    class RentalCar
    {
        SqlConnection sqlConnection=new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RentalCarDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private DataTable dataTable;

        public void add_delete_update(SqlCommand sqlCommand, string query)
        {
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = query;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable list(SqlDataAdapter sqlDataAdapter, string query)
        {
            dataTable=new DataTable();
            sqlDataAdapter=new SqlDataAdapter(query,sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;

        }

        public void carsInGarage(ComboBox comboBox, string query)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand=new SqlCommand(query,sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboBox.Items.Add(sqlDataReader["LicencePlate"].ToString());
            }
            sqlConnection.Close();
        }

        public void getCarsFromCbx(ComboBox comboBox, TextBox brandTextBox, TextBox serieTextBox, TextBox modelTextBox,TextBox colorTextBox, string query )
        {
            sqlConnection.Open();
            SqlCommand sqlCommand=new SqlCommand(query,sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                brandTextBox.Text = sqlDataReader["brand"].ToString();
                serieTextBox.Text = sqlDataReader["serie"].ToString();
                modelTextBox.Text = sqlDataReader["model"].ToString();
                colorTextBox.Text = sqlDataReader["color"].ToString();
            }

            sqlConnection.Close();
        }

        public void totalPriceCalculate(ComboBox rentalTypeComboBox, TextBox rentalPriceTextBox, string query)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand=new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (rentalTypeComboBox.SelectedIndex==0)
                {
                    rentalPriceTextBox.Text = (int.Parse(sqlDataReader["RentalPrice"].ToString()) * 1).ToString();
                }
                if (rentalTypeComboBox.SelectedIndex == 1)
                {
                    rentalPriceTextBox.Text = (int.Parse(sqlDataReader["RentalPrice"].ToString()) * 0.8).ToString();

                }
                if (rentalTypeComboBox.SelectedIndex == 2)
                {
                    rentalPriceTextBox.Text = (int.Parse(sqlDataReader["RentalPrice"].ToString()) * 0.5).ToString();

                }
            }
            sqlConnection.Close();

        }

        public void searchByIdNumber(TextBox idSearchTTextBox, TextBox idTextBox, TextBox customerNameTextBox, TextBox phoneTextBox, string query)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand=new SqlCommand(query,sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                idSearchTTextBox.Text = sqlDataReader["IdNumber"].ToString();
                idTextBox.Text = sqlDataReader["IdNumber"].ToString();
                customerNameTextBox.Text = sqlDataReader["CustomerName"].ToString();
                phoneTextBox.Text = sqlDataReader["PhoneNumber"].ToString();

            }
            sqlConnection.Close();
        }

        public void totalPriceCalculate(Label label)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand=new SqlCommand("select sum (RentalPrice) from sales",sqlConnection);
            label.Text = "Toplam tutar : " + sqlCommand.ExecuteScalar() + " TL";
            sqlConnection.Close();
        }
    }
}
