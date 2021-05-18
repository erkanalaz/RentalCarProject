
namespace RentalCarProject
{
    partial class FormCarList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarList));
            this.tbxRentalPrice = new System.Windows.Forms.TextBox();
            this.tbxKm = new System.Windows.Forms.TextBox();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxLicensePlate = new System.Windows.Forms.TextBox();
            this.cbxSerie = new System.Windows.Forms.ComboBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.cbxPetrol = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbxCarList = new System.Windows.Forms.PictureBox();
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.btnChangePic = new System.Windows.Forms.Button();
            this.btnCarListUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCarListDelete = new System.Windows.Forms.Button();
            this.cbxCarFilter = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxRentalPrice
            // 
            this.tbxRentalPrice.Location = new System.Drawing.Point(143, 445);
            this.tbxRentalPrice.Name = "tbxRentalPrice";
            this.tbxRentalPrice.Size = new System.Drawing.Size(177, 27);
            this.tbxRentalPrice.TabIndex = 14;
            // 
            // tbxKm
            // 
            this.tbxKm.Location = new System.Drawing.Point(143, 337);
            this.tbxKm.Name = "tbxKm";
            this.tbxKm.Size = new System.Drawing.Size(177, 27);
            this.tbxKm.TabIndex = 15;
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(143, 283);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(177, 27);
            this.tbxColor.TabIndex = 16;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(143, 229);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(177, 27);
            this.tbxModel.TabIndex = 17;
            // 
            // tbxLicensePlate
            // 
            this.tbxLicensePlate.Location = new System.Drawing.Point(143, 66);
            this.tbxLicensePlate.Name = "tbxLicensePlate";
            this.tbxLicensePlate.Size = new System.Drawing.Size(177, 27);
            this.tbxLicensePlate.TabIndex = 18;
            // 
            // cbxSerie
            // 
            this.cbxSerie.FormattingEnabled = true;
            this.cbxSerie.Location = new System.Drawing.Point(143, 175);
            this.cbxSerie.Name = "cbxSerie";
            this.cbxSerie.Size = new System.Drawing.Size(177, 28);
            this.cbxSerie.TabIndex = 11;
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Fiat",
            "Ford",
            "Honda",
            "Mercedes - Benz",
            "Opel",
            "Peugeot",
            "Renault",
            "Seat",
            "Skoda",
            "Toyota",
            "Volkswagen"});
            this.cbxBrand.Location = new System.Drawing.Point(143, 120);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(177, 28);
            this.cbxBrand.TabIndex = 12;
            this.cbxBrand.SelectedIndexChanged += new System.EventHandler(this.cbxBrand_SelectedIndexChanged);
            // 
            // cbxPetrol
            // 
            this.cbxPetrol.FormattingEnabled = true;
            this.cbxPetrol.Items.AddRange(new object[] {
            "Benzin",
            "Mazot",
            "LPG+Benzin"});
            this.cbxPetrol.Location = new System.Drawing.Point(143, 387);
            this.cbxPetrol.Name = "cbxPetrol";
            this.cbxPetrol.Size = new System.Drawing.Size(177, 28);
            this.cbxPetrol.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(70, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(83, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(68, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(57, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(79, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Plaka";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Actions-document-edit-icon.png");
            this.ımageList1.Images.SetKeyName(1, "delete-icon.png");
            // 
            // pbxCarList
            // 
            this.pbxCarList.Location = new System.Drawing.Point(21, 489);
            this.pbxCarList.Name = "pbxCarList";
            this.pbxCarList.Size = new System.Drawing.Size(208, 120);
            this.pbxCarList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCarList.TabIndex = 19;
            this.pbxCarList.TabStop = false;
            // 
            // dgvCarList
            // 
            this.dgvCarList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.Location = new System.Drawing.Point(372, 66);
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.RowHeadersWidth = 51;
            this.dgvCarList.RowTemplate.Height = 29;
            this.dgvCarList.Size = new System.Drawing.Size(861, 497);
            this.dgvCarList.TabIndex = 20;
            this.dgvCarList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarList_CellDoubleClick);
            // 
            // btnChangePic
            // 
            this.btnChangePic.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangePic.Location = new System.Drawing.Point(235, 518);
            this.btnChangePic.Name = "btnChangePic";
            this.btnChangePic.Size = new System.Drawing.Size(94, 74);
            this.btnChangePic.TabIndex = 21;
            this.btnChangePic.Text = "Resim Değiştir";
            this.btnChangePic.UseVisualStyleBackColor = true;
            this.btnChangePic.Click += new System.EventHandler(this.btnChangePic_Click);
            // 
            // btnCarListUpdate
            // 
            this.btnCarListUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarListUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarListUpdate.ImageIndex = 0;
            this.btnCarListUpdate.ImageList = this.ımageList1;
            this.btnCarListUpdate.Location = new System.Drawing.Point(21, 638);
            this.btnCarListUpdate.Name = "btnCarListUpdate";
            this.btnCarListUpdate.Size = new System.Drawing.Size(158, 59);
            this.btnCarListUpdate.TabIndex = 22;
            this.btnCarListUpdate.Text = "Güncelle";
            this.btnCarListUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarListUpdate.UseVisualStyleBackColor = true;
            this.btnCarListUpdate.Click += new System.EventHandler(this.btnCarListUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageIndex = 1;
            this.btnCancel.ImageList = this.ımageList1;
            this.btnCancel.Location = new System.Drawing.Point(194, 638);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 59);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCarListDelete
            // 
            this.btnCarListDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarListDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarListDelete.ImageIndex = 1;
            this.btnCarListDelete.ImageList = this.ımageList1;
            this.btnCarListDelete.Location = new System.Drawing.Point(1122, 569);
            this.btnCarListDelete.Name = "btnCarListDelete";
            this.btnCarListDelete.Size = new System.Drawing.Size(111, 47);
            this.btnCarListDelete.TabIndex = 22;
            this.btnCarListDelete.Text = "Sil";
            this.btnCarListDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarListDelete.UseVisualStyleBackColor = true;
            this.btnCarListDelete.Click += new System.EventHandler(this.btnCarListDelete_Click);
            // 
            // cbxCarFilter
            // 
            this.cbxCarFilter.FormattingEnabled = true;
            this.cbxCarFilter.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Kiralanan Araçlar",
            "Garajdaki Aralar"});
            this.cbxCarFilter.Location = new System.Drawing.Point(1023, 32);
            this.cbxCarFilter.Name = "cbxCarFilter";
            this.cbxCarFilter.Size = new System.Drawing.Size(210, 28);
            this.cbxCarFilter.TabIndex = 23;
            this.cbxCarFilter.SelectedIndexChanged += new System.EventHandler(this.cbxCarFilter_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1274, 734);
            this.Controls.Add(this.cbxCarFilter);
            this.Controls.Add(this.btnCarListDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCarListUpdate);
            this.Controls.Add(this.btnChangePic);
            this.Controls.Add(this.dgvCarList);
            this.Controls.Add(this.pbxCarList);
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
            this.Name = "FormCarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FormCarList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRentalPrice;
        private System.Windows.Forms.TextBox tbxKm;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxLicensePlate;
        private System.Windows.Forms.ComboBox cbxSerie;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.ComboBox cbxPetrol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pbxCarList;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Button btnChangePic;
        private System.Windows.Forms.Button btnCarListUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCarListDelete;
        private System.Windows.Forms.ComboBox cbxCarFilter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}