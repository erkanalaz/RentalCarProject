using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace RentalCarProject
{
    public partial class FormContractPrint : Form
    {
        RentalCar rentalCar=new RentalCar();
        public FormContractPrint()
        {
            InitializeComponent();

            String contractPrintQuery = "select CustomerName,PhoneNumber,Brand,Serie,RentalDay,RentalTotalDate,GiveBackDate from Contracts";
            SqlDataAdapter sqlDataAdapter=new SqlDataAdapter();
            dataGridView1.DataSource= rentalCar.list(sqlDataAdapter, contractPrintQuery);

            

        }

        private void btnSeePrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //yazıcı işlemlerinde try-catch bloğu kullanılır.
            try
            {
                //sayfanın yatay çevirilmesine çalış!

                Font font=new Font("Arial",11);
                SolidBrush solidBrush=new SolidBrush(Color.Black);
                
                e.Graphics.DrawString($"Tarih :{DateTime.Now.ToString("dd.MM.yyyy")}",font,solidBrush,650,30);

                Font fontHead=new Font("Arial",20,FontStyle.Bold);
                e.Graphics.DrawString("Araç Kiralama Sözleşme Çıktısı",fontHead,solidBrush,190,70);

                //CustomerName,PhoneNumber,Brand,Serie,Model,RentalType,RentalDay,RentalTotalDate,GiveBackDate
                e.Graphics.DrawString("Müşteri Adı",font,solidBrush,50,170);
                e.Graphics.DrawString("Telefon", font, solidBrush, 150, 170);
                e.Graphics.DrawString("Marka", font, solidBrush, 300, 170);
                e.Graphics.DrawString("Seri", font, solidBrush, 370, 170);
                e.Graphics.DrawString("Gün", font, solidBrush, 450, 170);
                e.Graphics.DrawString("Toplam Ödenecek Miktar", font, solidBrush, 500, 170);
                e.Graphics.DrawString("İade Tarihi", font, solidBrush, 700, 170);

                Font fontCustomerInfo=new Font("Arial",11,FontStyle.Underline);
                e.Graphics.DrawString("Müşteri Bilgileri", fontCustomerInfo, solidBrush, 500, 600);
                e.Graphics.DrawString("İmza         : ", font, solidBrush, 500, 650);
                e.Graphics.DrawString("Adı Soyadı : " + (dataGridView1.CurrentRow.Cells[0].Value.ToString()), font, solidBrush, 500, 700);


                int i = 0;
                int y = 210;
                while (i<=dataGridView1.Rows.Count-2)
                {
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), font, solidBrush, 50 , y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), font, solidBrush, 150, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), font, solidBrush, 300, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), font, solidBrush, 370, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), font, solidBrush, 450, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), font, solidBrush, 500, y);
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), font, solidBrush, 700, y);

                    y = y + 40;
                    i = i + 1;
                }
                
            }
            catch 
            {
                
                throw;
            }
        }
    }
}
