namespace Hastane.PL
{
    partial class FormHastaKabul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaKabul));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTCKNOAra = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.dgvRandevuListesi = new ns1.BunifuCustomDataGrid();
            this.txtAdSoyadAra = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.btnHastaKabulKaydet = new ns1.BunifuThinButton2();
            this.txtRandevuTarihi = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.txtKlinik = new ns1.BunifuMetroTextbox();
            this.txtDoktor = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.txtTCKNO = new ns1.BunifuMetroTextbox();
            this.txtHastaAdSoyad = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTCKNOAra);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.dgvRandevuListesi);
            this.panel1.Controls.Add(this.txtAdSoyadAra);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 715);
            this.panel1.TabIndex = 0;
            // 
            // txtTCKNOAra
            // 
            this.txtTCKNOAra.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtTCKNOAra.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTCKNOAra.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtTCKNOAra.BorderThickness = 3;
            this.txtTCKNOAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTCKNOAra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTCKNOAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtTCKNOAra.isPassword = false;
            this.txtTCKNOAra.Location = new System.Drawing.Point(432, 76);
            this.txtTCKNOAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCKNOAra.Name = "txtTCKNOAra";
            this.txtTCKNOAra.Size = new System.Drawing.Size(173, 35);
            this.txtTCKNOAra.TabIndex = 1;
            this.txtTCKNOAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTCKNOAra.OnValueChanged += new System.EventHandler(this.txtAdSoyadAra_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(337, 87);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(88, 17);
            this.bunifuCustomLabel2.TabIndex = 24;
            this.bunifuCustomLabel2.Text = "TC Kimlik No";
            // 
            // dgvRandevuListesi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRandevuListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRandevuListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgvRandevuListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRandevuListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRandevuListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRandevuListesi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRandevuListesi.DoubleBuffered = true;
            this.dgvRandevuListesi.EnableHeadersVisualStyles = false;
            this.dgvRandevuListesi.GridColor = System.Drawing.Color.White;
            this.dgvRandevuListesi.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dgvRandevuListesi.HeaderForeColor = System.Drawing.Color.White;
            this.dgvRandevuListesi.Location = new System.Drawing.Point(16, 130);
            this.dgvRandevuListesi.Name = "dgvRandevuListesi";
            this.dgvRandevuListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRandevuListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRandevuListesi.RowHeadersWidth = 10;
            this.dgvRandevuListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevuListesi.Size = new System.Drawing.Size(636, 573);
            this.dgvRandevuListesi.TabIndex = 2;
            this.dgvRandevuListesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRandevuListesi_CellMouseClick);
            // 
            // txtAdSoyadAra
            // 
            this.txtAdSoyadAra.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtAdSoyadAra.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdSoyadAra.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtAdSoyadAra.BorderThickness = 3;
            this.txtAdSoyadAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdSoyadAra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAdSoyadAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtAdSoyadAra.isPassword = false;
            this.txtAdSoyadAra.Location = new System.Drawing.Point(157, 76);
            this.txtAdSoyadAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdSoyadAra.Name = "txtAdSoyadAra";
            this.txtAdSoyadAra.Size = new System.Drawing.Size(173, 35);
            this.txtAdSoyadAra.TabIndex = 0;
            this.txtAdSoyadAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdSoyadAra.OnValueChanged += new System.EventHandler(this.txtAdSoyadAra_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(88, 87);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel1.TabIndex = 21;
            this.bunifuCustomLabel1.Text = "Ad Soyad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane.PL.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(12, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.bunifuThinButton21);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 56);
            this.panel3.TabIndex = 0;
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
            this.bunifuThinButton21.ButtonText = "Randevu Listesi";
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
            this.bunifuThinButton21.Size = new System.Drawing.Size(669, 56);
            this.bunifuThinButton21.TabIndex = 3;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.btnHastaKabulKaydet);
            this.panel2.Controls.Add(this.txtRandevuTarihi);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.txtKlinik);
            this.panel2.Controls.Add(this.txtDoktor);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.txtTCKNO);
            this.panel2.Controls.Add(this.txtHastaAdSoyad);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(669, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 715);
            this.panel2.TabIndex = 1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 56);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(3, 659);
            this.bunifuSeparator1.TabIndex = 83;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // btnHastaKabulKaydet
            // 
            this.btnHastaKabulKaydet.ActiveBorderThickness = 1;
            this.btnHastaKabulKaydet.ActiveCornerRadius = 20;
            this.btnHastaKabulKaydet.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btnHastaKabulKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnHastaKabulKaydet.ActiveLineColor = System.Drawing.Color.White;
            this.btnHastaKabulKaydet.BackColor = System.Drawing.SystemColors.Control;
            this.btnHastaKabulKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaKabulKaydet.BackgroundImage")));
            this.btnHastaKabulKaydet.ButtonText = "Hasta Kabul Kaydet";
            this.btnHastaKabulKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHastaKabulKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHastaKabulKaydet.ForeColor = System.Drawing.Color.Transparent;
            this.btnHastaKabulKaydet.IdleBorderThickness = 1;
            this.btnHastaKabulKaydet.IdleCornerRadius = 20;
            this.btnHastaKabulKaydet.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnHastaKabulKaydet.IdleForecolor = System.Drawing.Color.White;
            this.btnHastaKabulKaydet.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnHastaKabulKaydet.Location = new System.Drawing.Point(83, 291);
            this.btnHastaKabulKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnHastaKabulKaydet.Name = "btnHastaKabulKaydet";
            this.btnHastaKabulKaydet.Size = new System.Drawing.Size(356, 41);
            this.btnHastaKabulKaydet.TabIndex = 5;
            this.btnHastaKabulKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHastaKabulKaydet.Click += new System.EventHandler(this.btnHastaKabulKaydet_Click);
            // 
            // txtRandevuTarihi
            // 
            this.txtRandevuTarihi.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtRandevuTarihi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRandevuTarihi.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtRandevuTarihi.BorderThickness = 3;
            this.txtRandevuTarihi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRandevuTarihi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRandevuTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtRandevuTarihi.isPassword = false;
            this.txtRandevuTarihi.Location = new System.Drawing.Point(198, 247);
            this.txtRandevuTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.txtRandevuTarihi.Name = "txtRandevuTarihi";
            this.txtRandevuTarihi.Size = new System.Drawing.Size(241, 35);
            this.txtRandevuTarihi.TabIndex = 4;
            this.txtRandevuTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(78, 254);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(105, 17);
            this.bunifuCustomLabel7.TabIndex = 31;
            this.bunifuCustomLabel7.Text = "Randevu Tarihi";
            this.bunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKlinik
            // 
            this.txtKlinik.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtKlinik.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKlinik.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtKlinik.BorderThickness = 3;
            this.txtKlinik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKlinik.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKlinik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtKlinik.isPassword = false;
            this.txtKlinik.Location = new System.Drawing.Point(198, 204);
            this.txtKlinik.Margin = new System.Windows.Forms.Padding(4);
            this.txtKlinik.Name = "txtKlinik";
            this.txtKlinik.Size = new System.Drawing.Size(241, 35);
            this.txtKlinik.TabIndex = 3;
            this.txtKlinik.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDoktor
            // 
            this.txtDoktor.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtDoktor.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDoktor.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtDoktor.BorderThickness = 3;
            this.txtDoktor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoktor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDoktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtDoktor.isPassword = false;
            this.txtDoktor.Location = new System.Drawing.Point(198, 161);
            this.txtDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoktor.Name = "txtDoktor";
            this.txtDoktor.Size = new System.Drawing.Size(241, 35);
            this.txtDoktor.TabIndex = 2;
            this.txtDoktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(78, 211);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel5.TabIndex = 29;
            this.bunifuCustomLabel5.Text = "Klinik";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(80, 171);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(50, 17);
            this.bunifuCustomLabel6.TabIndex = 28;
            this.bunifuCustomLabel6.Text = "Doktor";
            // 
            // txtTCKNO
            // 
            this.txtTCKNO.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtTCKNO.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTCKNO.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtTCKNO.BorderThickness = 3;
            this.txtTCKNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTCKNO.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTCKNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtTCKNO.isPassword = false;
            this.txtTCKNO.Location = new System.Drawing.Point(198, 118);
            this.txtTCKNO.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCKNO.Name = "txtTCKNO";
            this.txtTCKNO.Size = new System.Drawing.Size(241, 35);
            this.txtTCKNO.TabIndex = 1;
            this.txtTCKNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHastaAdSoyad
            // 
            this.txtHastaAdSoyad.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtHastaAdSoyad.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHastaAdSoyad.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtHastaAdSoyad.BorderThickness = 3;
            this.txtHastaAdSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastaAdSoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHastaAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtHastaAdSoyad.isPassword = false;
            this.txtHastaAdSoyad.Location = new System.Drawing.Point(198, 75);
            this.txtHastaAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaAdSoyad.Name = "txtHastaAdSoyad";
            this.txtHastaAdSoyad.Size = new System.Drawing.Size(241, 35);
            this.txtHastaAdSoyad.TabIndex = 0;
            this.txtHastaAdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(78, 128);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(88, 17);
            this.bunifuCustomLabel3.TabIndex = 25;
            this.bunifuCustomLabel3.Text = "TC Kimlik No";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(80, 87);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(116, 17);
            this.bunifuCustomLabel4.TabIndex = 24;
            this.bunifuCustomLabel4.Text = "Hasta Adı Soyadı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.bunifuThinButton22);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(516, 56);
            this.panel4.TabIndex = 1;
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
            this.bunifuThinButton22.ButtonText = "Hasta Bilgileri";
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
            this.bunifuThinButton22.Size = new System.Drawing.Size(516, 56);
            this.bunifuThinButton22.TabIndex = 4;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHastaKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 715);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHastaKabul";
            this.Text = "FormHastaKabul";
            this.Load += new System.EventHandler(this.FormHastaKabul_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private ns1.BunifuThinButton2 bunifuThinButton22;
        private ns1.BunifuMetroTextbox txtTCKNOAra;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomDataGrid dgvRandevuListesi;
        private ns1.BunifuMetroTextbox txtAdSoyadAra;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuMetroTextbox txtRandevuTarihi;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private ns1.BunifuMetroTextbox txtKlinik;
        private ns1.BunifuMetroTextbox txtDoktor;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuMetroTextbox txtTCKNO;
        private ns1.BunifuMetroTextbox txtHastaAdSoyad;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuThinButton2 btnHastaKabulKaydet;
        private ns1.BunifuSeparator bunifuSeparator1;
    }
}