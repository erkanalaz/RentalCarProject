using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCarProject
{
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCarAdd carAdd=new FormCarAdd();
            carAdd.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            FormCustomerAdd customerAdd=new FormCustomerAdd();
            customerAdd.ShowDialog();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            FormCustomerList customerList=new FormCustomerList();
            customerList.ShowDialog();
        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            FormCarList carList=new FormCarList();
            carList.ShowDialog();

        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            FormContract formContract=new FormContract();
            formContract.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            FormSale formSale=new FormSale();
            formSale.ShowDialog();
        }
    }
}
