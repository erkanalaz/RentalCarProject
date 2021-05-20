
namespace RentalCarProject
{
    partial class FormCarAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxPetrol = new System.Windows.Forms.ComboBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.cbxSerie = new System.Windows.Forms.ComboBox();
            this.tbxLicensePlate = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.tbxKm = new System.Windows.Forms.TextBox();
            this.tbxRentalPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pbxCarAdd = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChangeBrands = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(109, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(87, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(98, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(113, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(100, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yakıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(51, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kira Ücreti";
            // 
            // cbxPetrol
            // 
            this.cbxPetrol.FormattingEnabled = true;
            this.cbxPetrol.Items.AddRange(new object[] {
            "Benzin",
            "Mazot",
            "LPG+Benzin"});
            this.cbxPetrol.Location = new System.Drawing.Point(185, 366);
            this.cbxPetrol.Name = "cbxPetrol";
            this.cbxPetrol.Size = new System.Drawing.Size(177, 28);
            this.cbxPetrol.TabIndex = 1;
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(185, 114);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(177, 28);
            this.cbxBrand.TabIndex = 1;
            this.cbxBrand.SelectedIndexChanged += new System.EventHandler(this.cbxBrand_SelectedIndexChanged);
            // 
            // cbxSerie
            // 
            this.cbxSerie.FormattingEnabled = true;
            this.cbxSerie.Location = new System.Drawing.Point(185, 165);
            this.cbxSerie.Name = "cbxSerie";
            this.cbxSerie.Size = new System.Drawing.Size(177, 28);
            this.cbxSerie.TabIndex = 1;
            this.cbxSerie.SelectedIndexChanged += new System.EventHandler(this.cbxSerie_SelectedIndexChanged);
            // 
            // tbxLicensePlate
            // 
            this.tbxLicensePlate.Location = new System.Drawing.Point(185, 64);
            this.tbxLicensePlate.Name = "tbxLicensePlate";
            this.tbxLicensePlate.Size = new System.Drawing.Size(177, 27);
            this.tbxLicensePlate.TabIndex = 2;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(185, 216);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(177, 27);
            this.tbxModel.TabIndex = 2;
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(185, 266);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(177, 27);
            this.tbxColor.TabIndex = 2;
            // 
            // tbxKm
            // 
            this.tbxKm.Location = new System.Drawing.Point(185, 316);
            this.tbxKm.Name = "tbxKm";
            this.tbxKm.Size = new System.Drawing.Size(177, 27);
            this.tbxKm.TabIndex = 2;
            // 
            // tbxRentalPrice
            // 
            this.tbxRentalPrice.Location = new System.Drawing.Point(185, 417);
            this.tbxRentalPrice.Name = "tbxRentalPrice";
            this.tbxRentalPrice.Size = new System.Drawing.Size(177, 27);
            this.tbxRentalPrice.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(51, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add-icon.png");
            this.ımageList1.Images.SetKeyName(1, "delete-icon.png");
            this.ımageList1.Images.SetKeyName(2, "Actions-document-edit-icon.png");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(245, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "İptal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(1013, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "Resim Ekle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pbxCarAdd
            // 
            this.pbxCarAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCarAdd.Location = new System.Drawing.Point(458, 64);
            this.pbxCarAdd.Name = "pbxCarAdd";
            this.pbxCarAdd.Size = new System.Drawing.Size(717, 380);
            this.pbxCarAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCarAdd.TabIndex = 4;
            this.pbxCarAdd.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChangeBrands
            // 
            this.btnChangeBrands.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeBrands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChangeBrands.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeBrands.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeBrands.ImageIndex = 2;
            this.btnChangeBrands.ImageList = this.ımageList1;
            this.btnChangeBrands.Location = new System.Drawing.Point(935, 649);
            this.btnChangeBrands.Name = "btnChangeBrands";
            this.btnChangeBrands.Size = new System.Drawing.Size(240, 50);
            this.btnChangeBrands.TabIndex = 5;
            this.btnChangeBrands.Text = "Araç Markalarını Düzenle";
            this.btnChangeBrands.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeBrands.UseVisualStyleBackColor = false;
            this.btnChangeBrands.Click += new System.EventHandler(this.btnChangeBrands_Click);
            // 
            // FormCarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1229, 711);
            this.Controls.Add(this.btnChangeBrands);
            this.Controls.Add(this.pbxCarAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxRentalPrice);
            this.Controls.Add(this.tbxKm);
            this.Controls.Add(this.tbxColor);
            this.Controls.Add(this.tbxModel);
            this.Controls.Add(this.tbxLicensePlate);
            this.Controls.Add(this.cbxSerie);
            this.Controls.Add(this.cbxBrand);
            this.Controls.Add(this.cbxPetrol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCarAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Ekleme Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxPetrol;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.ComboBox cbxSerie;
        private System.Windows.Forms.TextBox tbxLicensePlate;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.TextBox tbxKm;
        private System.Windows.Forms.TextBox tbxRentalPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pbxCarAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChangeBrands;
    }
}