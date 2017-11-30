namespace Hastane.PL
{
    partial class FormPersonelIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelIslemleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvKlinikler = new ns1.BunifuCustomDataGrid();
            this.bunifuMetroTextbox1 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.txtKlinikAdAra = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuMetroTextbox8 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel12 = new ns1.BunifuCustomLabel();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.btnKurumSil = new ns1.BunifuThinButton2();
            this.btnKurumEkle = new ns1.BunifuThinButton2();
            this.btnKurumGuncelle = new ns1.BunifuThinButton2();
            this.dtpRandevuTarih = new ns1.BunifuDatepicker();
            this.bunifuCustomLabel11 = new ns1.BunifuCustomLabel();
            this.bunifuMetroTextbox3 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.bunifuDropdown1 = new ns1.BunifuDropdown();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.cbTahliller = new ns1.BunifuDropdown();
            this.bunifuCustomLabel43 = new ns1.BunifuCustomLabel();
            this.bunifuMetroTextbox4 = new ns1.BunifuMetroTextbox();
            this.bunifuMetroTextbox5 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new ns1.BunifuCustomLabel();
            this.bunifuMetroTextbox6 = new ns1.BunifuMetroTextbox();
            this.bunifuMetroTextbox7 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.bunifuMetroTextbox2 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.txtKlinikAd = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.PersonelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SicilNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnvanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlinikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlinikAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelCepTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelEvTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlinikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvKlinikler);
            this.panel1.Controls.Add(this.bunifuMetroTextbox1);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.txtKlinikAdAra);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 676);
            this.panel1.TabIndex = 0;
            // 
            // dgvKlinikler
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvKlinikler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKlinikler.BackgroundColor = System.Drawing.Color.White;
            this.dgvKlinikler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKlinikler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKlinikler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKlinikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlinikler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonelID,
            this.SicilNo,
            this.UnvanID,
            this.Unvan,
            this.KlinikId,
            this.KlinikAdi,
            this.PersonelAdi,
            this.PersonelSoyadi,
            this.PersonelAdres,
            this.PersonelCepTel,
            this.PersonelEvTel,
            this.DogumTarih});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKlinikler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKlinikler.DoubleBuffered = true;
            this.dgvKlinikler.EnableHeadersVisualStyles = false;
            this.dgvKlinikler.GridColor = System.Drawing.Color.White;
            this.dgvKlinikler.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dgvKlinikler.HeaderForeColor = System.Drawing.Color.White;
            this.dgvKlinikler.Location = new System.Drawing.Point(12, 130);
            this.dgvKlinikler.Name = "dgvKlinikler";
            this.dgvKlinikler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKlinikler.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKlinikler.RowHeadersWidth = 10;
            this.dgvKlinikler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlinikler.Size = new System.Drawing.Size(663, 534);
            this.dgvKlinikler.TabIndex = 30;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(445, 76);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(173, 35);
            this.bunifuMetroTextbox1.TabIndex = 28;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(337, 87);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(101, 17);
            this.bunifuCustomLabel2.TabIndex = 29;
            this.bunifuCustomLabel2.Text = "Personel Kodu";
            // 
            // txtKlinikAdAra
            // 
            this.txtKlinikAdAra.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtKlinikAdAra.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKlinikAdAra.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtKlinikAdAra.BorderThickness = 3;
            this.txtKlinikAdAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKlinikAdAra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKlinikAdAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtKlinikAdAra.isPassword = false;
            this.txtKlinikAdAra.Location = new System.Drawing.Point(157, 76);
            this.txtKlinikAdAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtKlinikAdAra.Name = "txtKlinikAdAra";
            this.txtKlinikAdAra.Size = new System.Drawing.Size(173, 35);
            this.txtKlinikAdAra.TabIndex = 25;
            this.txtKlinikAdAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(88, 87);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel1.TabIndex = 27;
            this.bunifuCustomLabel1.Text = "Ad Soyad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane.PL.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(12, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel9.Controls.Add(this.bunifuThinButton21);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(691, 56);
            this.panel9.TabIndex = 1;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 30;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Personel Bilgileri";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuThinButton21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.Location = new System.Drawing.Point(0, 0);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(691, 56);
            this.bunifuThinButton21.TabIndex = 2;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuMetroTextbox8);
            this.panel2.Controls.Add(this.bunifuCustomLabel12);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.btnKurumSil);
            this.panel2.Controls.Add(this.btnKurumEkle);
            this.panel2.Controls.Add(this.btnKurumGuncelle);
            this.panel2.Controls.Add(this.dtpRandevuTarih);
            this.panel2.Controls.Add(this.bunifuCustomLabel11);
            this.panel2.Controls.Add(this.bunifuMetroTextbox3);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.bunifuDropdown1);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.cbTahliller);
            this.panel2.Controls.Add(this.bunifuCustomLabel43);
            this.panel2.Controls.Add(this.bunifuMetroTextbox4);
            this.panel2.Controls.Add(this.bunifuMetroTextbox5);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.bunifuMetroTextbox6);
            this.panel2.Controls.Add(this.bunifuMetroTextbox7);
            this.panel2.Controls.Add(this.bunifuCustomLabel9);
            this.panel2.Controls.Add(this.bunifuCustomLabel10);
            this.panel2.Controls.Add(this.bunifuMetroTextbox2);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.txtKlinikAd);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(691, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 676);
            this.panel2.TabIndex = 1;
            // 
            // bunifuMetroTextbox8
            // 
            this.bunifuMetroTextbox8.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox8.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox8.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox8.BorderThickness = 3;
            this.bunifuMetroTextbox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox8.isPassword = false;
            this.bunifuMetroTextbox8.Location = new System.Drawing.Point(178, 205);
            this.bunifuMetroTextbox8.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox8.Name = "bunifuMetroTextbox8";
            this.bunifuMetroTextbox8.Size = new System.Drawing.Size(241, 35);
            this.bunifuMetroTextbox8.TabIndex = 84;
            this.bunifuMetroTextbox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(57, 217);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(42, 17);
            this.bunifuCustomLabel12.TabIndex = 83;
            this.bunifuCustomLabel12.Text = "Email";
            this.bunifuCustomLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 56);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(3, 620);
            this.bunifuSeparator1.TabIndex = 82;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // btnKurumSil
            // 
            this.btnKurumSil.ActiveBorderThickness = 1;
            this.btnKurumSil.ActiveCornerRadius = 20;
            this.btnKurumSil.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btnKurumSil.ActiveForecolor = System.Drawing.Color.White;
            this.btnKurumSil.ActiveLineColor = System.Drawing.Color.White;
            this.btnKurumSil.BackColor = System.Drawing.SystemColors.Control;
            this.btnKurumSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKurumSil.BackgroundImage")));
            this.btnKurumSil.ButtonText = "Personel Sil";
            this.btnKurumSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKurumSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurumSil.ForeColor = System.Drawing.Color.Transparent;
            this.btnKurumSil.IdleBorderThickness = 1;
            this.btnKurumSil.IdleCornerRadius = 20;
            this.btnKurumSil.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnKurumSil.IdleForecolor = System.Drawing.Color.White;
            this.btnKurumSil.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnKurumSil.Location = new System.Drawing.Point(60, 548);
            this.btnKurumSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnKurumSil.Name = "btnKurumSil";
            this.btnKurumSil.Size = new System.Drawing.Size(190, 41);
            this.btnKurumSil.TabIndex = 81;
            this.btnKurumSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKurumEkle
            // 
            this.btnKurumEkle.ActiveBorderThickness = 1;
            this.btnKurumEkle.ActiveCornerRadius = 20;
            this.btnKurumEkle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btnKurumEkle.ActiveForecolor = System.Drawing.Color.White;
            this.btnKurumEkle.ActiveLineColor = System.Drawing.Color.White;
            this.btnKurumEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnKurumEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKurumEkle.BackgroundImage")));
            this.btnKurumEkle.ButtonText = "Personel Ekle";
            this.btnKurumEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKurumEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurumEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btnKurumEkle.IdleBorderThickness = 1;
            this.btnKurumEkle.IdleCornerRadius = 20;
            this.btnKurumEkle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnKurumEkle.IdleForecolor = System.Drawing.Color.White;
            this.btnKurumEkle.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnKurumEkle.Location = new System.Drawing.Point(262, 548);
            this.btnKurumEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnKurumEkle.Name = "btnKurumEkle";
            this.btnKurumEkle.Size = new System.Drawing.Size(157, 41);
            this.btnKurumEkle.TabIndex = 80;
            this.btnKurumEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKurumGuncelle
            // 
            this.btnKurumGuncelle.ActiveBorderThickness = 1;
            this.btnKurumGuncelle.ActiveCornerRadius = 20;
            this.btnKurumGuncelle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btnKurumGuncelle.ActiveForecolor = System.Drawing.Color.White;
            this.btnKurumGuncelle.ActiveLineColor = System.Drawing.Color.White;
            this.btnKurumGuncelle.BackColor = System.Drawing.SystemColors.Control;
            this.btnKurumGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKurumGuncelle.BackgroundImage")));
            this.btnKurumGuncelle.ButtonText = "Personel Güncelle";
            this.btnKurumGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKurumGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurumGuncelle.ForeColor = System.Drawing.Color.Transparent;
            this.btnKurumGuncelle.IdleBorderThickness = 1;
            this.btnKurumGuncelle.IdleCornerRadius = 20;
            this.btnKurumGuncelle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnKurumGuncelle.IdleForecolor = System.Drawing.Color.White;
            this.btnKurumGuncelle.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnKurumGuncelle.Location = new System.Drawing.Point(63, 597);
            this.btnKurumGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnKurumGuncelle.Name = "btnKurumGuncelle";
            this.btnKurumGuncelle.Size = new System.Drawing.Size(360, 41);
            this.btnKurumGuncelle.TabIndex = 79;
            this.btnKurumGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpRandevuTarih
            // 
            this.dtpRandevuTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dtpRandevuTarih.BorderRadius = 0;
            this.dtpRandevuTarih.ForeColor = System.Drawing.Color.White;
            this.dtpRandevuTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRandevuTarih.FormatCustom = null;
            this.dtpRandevuTarih.Location = new System.Drawing.Point(178, 376);
            this.dtpRandevuTarih.Name = "dtpRandevuTarih";
            this.dtpRandevuTarih.Size = new System.Drawing.Size(241, 35);
            this.dtpRandevuTarih.TabIndex = 78;
            this.dtpRandevuTarih.Value = new System.DateTime(2017, 11, 24, 19, 24, 18, 0);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(59, 87);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(86, 17);
            this.bunifuCustomLabel11.TabIndex = 77;
            this.bunifuCustomLabel11.Text = "Tc Kimlik No";
            this.bunifuCustomLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox3.BorderThickness = 3;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox3.isPassword = false;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(177, 76);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(241, 35);
            this.bunifuMetroTextbox3.TabIndex = 76;
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(60, 474);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(55, 17);
            this.bunifuCustomLabel6.TabIndex = 75;
            this.bunifuCustomLabel6.Text = "Sicil No";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(179, 503);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(240, 35);
            this.bunifuDropdown1.TabIndex = 74;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(60, 517);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel3.TabIndex = 73;
            this.bunifuCustomLabel3.Text = "Klinik";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTahliller
            // 
            this.cbTahliller.BackColor = System.Drawing.Color.Transparent;
            this.cbTahliller.BorderRadius = 3;
            this.cbTahliller.ForeColor = System.Drawing.Color.White;
            this.cbTahliller.Items = new string[0];
            this.cbTahliller.Location = new System.Drawing.Point(178, 419);
            this.cbTahliller.Name = "cbTahliller";
            this.cbTahliller.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.cbTahliller.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.cbTahliller.selectedIndex = -1;
            this.cbTahliller.Size = new System.Drawing.Size(240, 35);
            this.cbTahliller.TabIndex = 72;
            // 
            // bunifuCustomLabel43
            // 
            this.bunifuCustomLabel43.AutoSize = true;
            this.bunifuCustomLabel43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel43.Location = new System.Drawing.Point(60, 432);
            this.bunifuCustomLabel43.Name = "bunifuCustomLabel43";
            this.bunifuCustomLabel43.Size = new System.Drawing.Size(49, 17);
            this.bunifuCustomLabel43.TabIndex = 71;
            this.bunifuCustomLabel43.Text = "Ünvan";
            // 
            // bunifuMetroTextbox4
            // 
            this.bunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox4.BorderThickness = 3;
            this.bunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox4.isPassword = false;
            this.bunifuMetroTextbox4.Location = new System.Drawing.Point(178, 291);
            this.bunifuMetroTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox4.Name = "bunifuMetroTextbox4";
            this.bunifuMetroTextbox4.Size = new System.Drawing.Size(241, 35);
            this.bunifuMetroTextbox4.TabIndex = 38;
            this.bunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox5
            // 
            this.bunifuMetroTextbox5.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox5.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox5.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox5.BorderThickness = 3;
            this.bunifuMetroTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox5.isPassword = false;
            this.bunifuMetroTextbox5.Location = new System.Drawing.Point(178, 248);
            this.bunifuMetroTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox5.Name = "bunifuMetroTextbox5";
            this.bunifuMetroTextbox5.Size = new System.Drawing.Size(241, 35);
            this.bunifuMetroTextbox5.TabIndex = 35;
            this.bunifuMetroTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(60, 389);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(93, 17);
            this.bunifuCustomLabel7.TabIndex = 37;
            this.bunifuCustomLabel7.Text = "Doğum Tarihi";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(57, 306);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(48, 17);
            this.bunifuCustomLabel8.TabIndex = 36;
            this.bunifuCustomLabel8.Text = "Ev Tel";
            // 
            // bunifuMetroTextbox6
            // 
            this.bunifuMetroTextbox6.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox6.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox6.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox6.BorderThickness = 3;
            this.bunifuMetroTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox6.isPassword = false;
            this.bunifuMetroTextbox6.Location = new System.Drawing.Point(178, 461);
            this.bunifuMetroTextbox6.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox6.Name = "bunifuMetroTextbox6";
            this.bunifuMetroTextbox6.Size = new System.Drawing.Size(241, 35);
            this.bunifuMetroTextbox6.TabIndex = 34;
            this.bunifuMetroTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox7
            // 
            this.bunifuMetroTextbox7.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox7.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox7.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox7.BorderThickness = 3;
            this.bunifuMetroTextbox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox7.isPassword = false;
            this.bunifuMetroTextbox7.Location = new System.Drawing.Point(178, 334);
            this.bunifuMetroTextbox7.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox7.Name = "bunifuMetroTextbox7";
            this.bunifuMetroTextbox7.Size = new System.Drawing.Size(241, 35);
            this.bunifuMetroTextbox7.TabIndex = 31;
            this.bunifuMetroTextbox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(57, 260);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(57, 17);
            this.bunifuCustomLabel9.TabIndex = 33;
            this.bunifuCustomLabel9.Text = "Cep Tel";
            this.bunifuCustomLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(60, 350);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(45, 17);
            this.bunifuCustomLabel10.TabIndex = 32;
            this.bunifuCustomLabel10.Text = "Adres";
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox2.BorderThickness = 3;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(177, 162);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(241, 35);
            this.bunifuMetroTextbox2.TabIndex = 30;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(59, 171);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(108, 17);
            this.bunifuCustomLabel5.TabIndex = 29;
            this.bunifuCustomLabel5.Text = "Personel Soyad";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKlinikAd
            // 
            this.txtKlinikAd.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtKlinikAd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKlinikAd.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtKlinikAd.BorderThickness = 3;
            this.txtKlinikAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKlinikAd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKlinikAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtKlinikAd.isPassword = false;
            this.txtKlinikAd.Location = new System.Drawing.Point(177, 119);
            this.txtKlinikAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtKlinikAd.Name = "txtKlinikAd";
            this.txtKlinikAd.Size = new System.Drawing.Size(241, 35);
            this.txtKlinikAd.TabIndex = 23;
            this.txtKlinikAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(59, 128);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(85, 17);
            this.bunifuCustomLabel4.TabIndex = 24;
            this.bunifuCustomLabel4.Text = "Personel Ad";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.bunifuThinButton22);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 56);
            this.panel3.TabIndex = 1;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 30;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Personel İşlemleri";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuThinButton22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.Location = new System.Drawing.Point(0, 0);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(478, 56);
            this.bunifuThinButton22.TabIndex = 2;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonelID
            // 
            this.PersonelID.HeaderText = "PersonelID";
            this.PersonelID.Name = "PersonelID";
            this.PersonelID.Visible = false;
            // 
            // SicilNo
            // 
            this.SicilNo.HeaderText = "SicilNo";
            this.SicilNo.Name = "SicilNo";
            this.SicilNo.Visible = false;
            // 
            // UnvanID
            // 
            this.UnvanID.HeaderText = "UnvanID";
            this.UnvanID.Name = "UnvanID";
            this.UnvanID.Visible = false;
            // 
            // Unvan
            // 
            this.Unvan.HeaderText = "Unvan";
            this.Unvan.Name = "Unvan";
            // 
            // KlinikId
            // 
            this.KlinikId.HeaderText = "KlinikId";
            this.KlinikId.Name = "KlinikId";
            this.KlinikId.Visible = false;
            // 
            // KlinikAdi
            // 
            this.KlinikAdi.HeaderText = "Klinik Adı";
            this.KlinikAdi.Name = "KlinikAdi";
            // 
            // PersonelAdi
            // 
            this.PersonelAdi.HeaderText = "Ad";
            this.PersonelAdi.Name = "PersonelAdi";
            // 
            // PersonelSoyadi
            // 
            this.PersonelSoyadi.HeaderText = "Soyad";
            this.PersonelSoyadi.Name = "PersonelSoyadi";
            // 
            // PersonelAdres
            // 
            this.PersonelAdres.HeaderText = "Adres";
            this.PersonelAdres.Name = "PersonelAdres";
            this.PersonelAdres.Visible = false;
            // 
            // PersonelCepTel
            // 
            this.PersonelCepTel.HeaderText = "Cep-Tel";
            this.PersonelCepTel.Name = "PersonelCepTel";
            // 
            // PersonelEvTel
            // 
            this.PersonelEvTel.HeaderText = "Ev-Tel";
            this.PersonelEvTel.Name = "PersonelEvTel";
            this.PersonelEvTel.Visible = false;
            // 
            // DogumTarih
            // 
            this.DogumTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DogumTarih.HeaderText = "Doğum Tarihi";
            this.DogumTarih.Name = "DogumTarih";
            this.DogumTarih.Width = 124;
            // 
            // FormPersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPersonelIslemleri";
            this.Text = "FormPersonelIslemleri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlinikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuThinButton2 bunifuThinButton22;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuMetroTextbox txtKlinikAdAra;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuCustomDataGrid dgvKlinikler;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox2;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuMetroTextbox txtKlinikAd;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox4;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox5;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private ns1.BunifuCustomLabel bunifuCustomLabel8;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox6;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox7;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private ns1.BunifuCustomLabel bunifuCustomLabel11;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox3;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuDropdown bunifuDropdown1;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuDropdown cbTahliller;
        private ns1.BunifuCustomLabel bunifuCustomLabel43;
        private ns1.BunifuDatepicker dtpRandevuTarih;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuThinButton2 btnKurumSil;
        private ns1.BunifuThinButton2 btnKurumEkle;
        private ns1.BunifuThinButton2 btnKurumGuncelle;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox8;
        private ns1.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SicilNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnvanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlinikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlinikAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelCepTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelEvTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarih;
    }
}