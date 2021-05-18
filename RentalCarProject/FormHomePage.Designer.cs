
namespace RentalCarProject
{
    partial class FormHomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePage));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnCarList = new System.Windows.Forms.Button();
            this.btnCarAdd = new System.Windows.Forms.Button();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "homapage.png");
            this.ımageList1.Images.SetKeyName(1, "Actions-list-add-user-icon.png");
            this.ımageList1.Images.SetKeyName(2, "add-icon.png");
            this.ımageList1.Images.SetKeyName(3, "cars-icon.png");
            this.ımageList1.Images.SetKeyName(4, "coins-icon.png");
            this.ımageList1.Images.SetKeyName(5, "Data-List-icon.png");
            this.ımageList1.Images.SetKeyName(6, "delete-icon.png");
            this.ımageList1.Images.SetKeyName(7, "folder-documents-icon.png");
            this.ımageList1.Images.SetKeyName(8, "payment-icon.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnContracts);
            this.panel1.Controls.Add(this.btnCarList);
            this.panel1.Controls.Add(this.btnCarAdd);
            this.panel1.Controls.Add(this.btnCustomerList);
            this.panel1.Controls.Add(this.btnCustomerAdd);
            this.panel1.Location = new System.Drawing.Point(23, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 181);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.ImageIndex = 6;
            this.btnExit.ImageList = this.ımageList1;
            this.btnExit.Location = new System.Drawing.Point(1202, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 123);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Çıkış";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.White;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSales.ImageIndex = 8;
            this.btnSales.ImageList = this.ımageList1;
            this.btnSales.Location = new System.Drawing.Point(1004, 33);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(178, 123);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Satışlar";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.BackColor = System.Drawing.Color.White;
            this.btnContracts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContracts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContracts.ImageIndex = 7;
            this.btnContracts.ImageList = this.ımageList1;
            this.btnContracts.Location = new System.Drawing.Point(806, 33);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(178, 123);
            this.btnContracts.TabIndex = 0;
            this.btnContracts.Text = "Sözleşme";
            this.btnContracts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContracts.UseVisualStyleBackColor = false;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnCarList
            // 
            this.btnCarList.BackColor = System.Drawing.Color.White;
            this.btnCarList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCarList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCarList.ImageIndex = 3;
            this.btnCarList.ImageList = this.ımageList1;
            this.btnCarList.Location = new System.Drawing.Point(608, 33);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(178, 123);
            this.btnCarList.TabIndex = 0;
            this.btnCarList.Text = "Araç Listele";
            this.btnCarList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarList.UseVisualStyleBackColor = false;
            this.btnCarList.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // btnCarAdd
            // 
            this.btnCarAdd.BackColor = System.Drawing.Color.White;
            this.btnCarAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCarAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCarAdd.ImageIndex = 2;
            this.btnCarAdd.ImageList = this.ımageList1;
            this.btnCarAdd.Location = new System.Drawing.Point(410, 33);
            this.btnCarAdd.Name = "btnCarAdd";
            this.btnCarAdd.Size = new System.Drawing.Size(178, 123);
            this.btnCarAdd.TabIndex = 0;
            this.btnCarAdd.Text = "Araç Ekle";
            this.btnCarAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarAdd.UseVisualStyleBackColor = false;
            this.btnCarAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.BackColor = System.Drawing.Color.White;
            this.btnCustomerList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomerList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomerList.ImageIndex = 5;
            this.btnCustomerList.ImageList = this.ımageList1;
            this.btnCustomerList.Location = new System.Drawing.Point(212, 33);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(178, 123);
            this.btnCustomerList.TabIndex = 0;
            this.btnCustomerList.Text = "Müşteri Listele";
            this.btnCustomerList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomerList.UseVisualStyleBackColor = false;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.BackColor = System.Drawing.Color.White;
            this.btnCustomerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomerAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomerAdd.ImageIndex = 1;
            this.btnCustomerAdd.ImageList = this.ımageList1;
            this.btnCustomerAdd.Location = new System.Drawing.Point(14, 33);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(178, 123);
            this.btnCustomerAdd.TabIndex = 0;
            this.btnCustomerAdd.Text = "Müşteri Ekle";
            this.btnCustomerAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomerAdd.UseVisualStyleBackColor = false;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1455, 696);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnCarList;
        private System.Windows.Forms.Button btnCarAdd;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.Button btnCustomerAdd;
    }
}

