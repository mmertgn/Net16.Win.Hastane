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
            this.dgvPersoneller = new ns1.BunifuCustomDataGrid();
            this.txtPersonelKoduAra = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.txtPersonelAdSoyadAra = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPersonelEmail = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel12 = new ns1.BunifuCustomLabel();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.btnPersonelSil = new ns1.BunifuThinButton2();
            this.btnPersonelEkle = new ns1.BunifuThinButton2();
            this.btnPersonelGuncelle = new ns1.BunifuThinButton2();
            this.dtpPersonelDogumTarihi = new ns1.BunifuDatepicker();
            this.bunifuCustomLabel11 = new ns1.BunifuCustomLabel();
            this.txtTCKimlikNo = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.cbKlinikler = new ns1.BunifuDropdown();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.cbUnvanlar = new ns1.BunifuDropdown();
            this.bunifuCustomLabel43 = new ns1.BunifuCustomLabel();
            this.txtPersonelEvTel = new ns1.BunifuMetroTextbox();
            this.txtPersonelCepTel = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new ns1.BunifuCustomLabel();
            this.txtSicilNo = new ns1.BunifuMetroTextbox();
            this.txtPersonelAdres = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.txtPersonelSoyad = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.txtPersonelAd = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPersoneller);
            this.panel1.Controls.Add(this.txtPersonelKoduAra);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.txtPersonelAdSoyadAra);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 676);
            this.panel1.TabIndex = 0;
            // 
            // dgvPersoneller
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPersoneller.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersoneller.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersoneller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersoneller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersoneller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersoneller.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersoneller.DoubleBuffered = true;
            this.dgvPersoneller.EnableHeadersVisualStyles = false;
            this.dgvPersoneller.GridColor = System.Drawing.Color.White;
            this.dgvPersoneller.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dgvPersoneller.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPersoneller.Location = new System.Drawing.Point(12, 130);
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersoneller.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPersoneller.RowHeadersWidth = 10;
            this.dgvPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoneller.Size = new System.Drawing.Size(744, 534);
            this.dgvPersoneller.TabIndex = 30;
            this.dgvPersoneller.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPersoneller_CellMouseClick);
            // 
            // txtPersonelKoduAra
            // 
            this.txtPersonelKoduAra.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelKoduAra.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelKoduAra.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelKoduAra.BorderThickness = 3;
            this.txtPersonelKoduAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelKoduAra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelKoduAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelKoduAra.isPassword = false;
            this.txtPersonelKoduAra.Location = new System.Drawing.Point(445, 76);
            this.txtPersonelKoduAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelKoduAra.Name = "txtPersonelKoduAra";
            this.txtPersonelKoduAra.Size = new System.Drawing.Size(173, 35);
            this.txtPersonelKoduAra.TabIndex = 28;
            this.txtPersonelKoduAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPersonelKoduAra.OnValueChanged += new System.EventHandler(this.txtPersonelKoduAra_OnValueChanged);
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
            // txtPersonelAdSoyadAra
            // 
            this.txtPersonelAdSoyadAra.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelAdSoyadAra.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelAdSoyadAra.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelAdSoyadAra.BorderThickness = 3;
            this.txtPersonelAdSoyadAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelAdSoyadAra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelAdSoyadAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelAdSoyadAra.isPassword = false;
            this.txtPersonelAdSoyadAra.Location = new System.Drawing.Point(157, 76);
            this.txtPersonelAdSoyadAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelAdSoyadAra.Name = "txtPersonelAdSoyadAra";
            this.txtPersonelAdSoyadAra.Size = new System.Drawing.Size(173, 35);
            this.txtPersonelAdSoyadAra.TabIndex = 25;
            this.txtPersonelAdSoyadAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPersonelAdSoyadAra.OnValueChanged += new System.EventHandler(this.txtPersonelAdSoyadAra_OnValueChanged);
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
            this.panel9.Size = new System.Drawing.Size(762, 56);
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
            this.bunifuThinButton21.Size = new System.Drawing.Size(762, 56);
            this.bunifuThinButton21.TabIndex = 2;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPersonelEmail);
            this.panel2.Controls.Add(this.bunifuCustomLabel12);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.btnPersonelSil);
            this.panel2.Controls.Add(this.btnPersonelEkle);
            this.panel2.Controls.Add(this.btnPersonelGuncelle);
            this.panel2.Controls.Add(this.dtpPersonelDogumTarihi);
            this.panel2.Controls.Add(this.bunifuCustomLabel11);
            this.panel2.Controls.Add(this.txtTCKimlikNo);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.cbKlinikler);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.cbUnvanlar);
            this.panel2.Controls.Add(this.bunifuCustomLabel43);
            this.panel2.Controls.Add(this.txtPersonelEvTel);
            this.panel2.Controls.Add(this.txtPersonelCepTel);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.txtSicilNo);
            this.panel2.Controls.Add(this.txtPersonelAdres);
            this.panel2.Controls.Add(this.bunifuCustomLabel9);
            this.panel2.Controls.Add(this.bunifuCustomLabel10);
            this.panel2.Controls.Add(this.txtPersonelSoyad);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.txtPersonelAd);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(762, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 676);
            this.panel2.TabIndex = 1;
            // 
            // txtPersonelEmail
            // 
            this.txtPersonelEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelEmail.BorderThickness = 3;
            this.txtPersonelEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelEmail.isPassword = false;
            this.txtPersonelEmail.Location = new System.Drawing.Point(141, 192);
            this.txtPersonelEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelEmail.Name = "txtPersonelEmail";
            this.txtPersonelEmail.Size = new System.Drawing.Size(241, 35);
            this.txtPersonelEmail.TabIndex = 84;
            this.txtPersonelEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(20, 204);
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
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 56);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 620);
            this.bunifuSeparator1.TabIndex = 82;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.ActiveBorderThickness = 1;
            this.btnPersonelSil.ActiveCornerRadius = 20;
            this.btnPersonelSil.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btnPersonelSil.ActiveForecolor = System.Drawing.Color.White;
            this.btnPersonelSil.ActiveLineColor = System.Drawing.Color.White;
            this.btnPersonelSil.BackColor = System.Drawing.SystemColors.Control;
            this.btnPersonelSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelSil.BackgroundImage")));
            this.btnPersonelSil.ButtonText = "Personel Sil";
            this.btnPersonelSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelSil.ForeColor = System.Drawing.Color.Transparent;
            this.btnPersonelSil.IdleBorderThickness = 1;
            this.btnPersonelSil.IdleCornerRadius = 20;
            this.btnPersonelSil.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnPersonelSil.IdleForecolor = System.Drawing.Color.White;
            this.btnPersonelSil.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnPersonelSil.Location = new System.Drawing.Point(23, 535);
            this.btnPersonelSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(190, 41);
            this.btnPersonelSil.TabIndex = 81;
            this.btnPersonelSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.ActiveBorderThickness = 1;
            this.btnPersonelEkle.ActiveCornerRadius = 20;
            this.btnPersonelEkle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btnPersonelEkle.ActiveForecolor = System.Drawing.Color.White;
            this.btnPersonelEkle.ActiveLineColor = System.Drawing.Color.White;
            this.btnPersonelEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnPersonelEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelEkle.BackgroundImage")));
            this.btnPersonelEkle.ButtonText = "Personel Ekle";
            this.btnPersonelEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btnPersonelEkle.IdleBorderThickness = 1;
            this.btnPersonelEkle.IdleCornerRadius = 20;
            this.btnPersonelEkle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnPersonelEkle.IdleForecolor = System.Drawing.Color.White;
            this.btnPersonelEkle.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnPersonelEkle.Location = new System.Drawing.Point(225, 535);
            this.btnPersonelEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(157, 41);
            this.btnPersonelEkle.TabIndex = 80;
            this.btnPersonelEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.ActiveBorderThickness = 1;
            this.btnPersonelGuncelle.ActiveCornerRadius = 20;
            this.btnPersonelGuncelle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.btnPersonelGuncelle.ActiveForecolor = System.Drawing.Color.White;
            this.btnPersonelGuncelle.ActiveLineColor = System.Drawing.Color.White;
            this.btnPersonelGuncelle.BackColor = System.Drawing.SystemColors.Control;
            this.btnPersonelGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelGuncelle.BackgroundImage")));
            this.btnPersonelGuncelle.ButtonText = "Personel Güncelle";
            this.btnPersonelGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelGuncelle.ForeColor = System.Drawing.Color.Transparent;
            this.btnPersonelGuncelle.IdleBorderThickness = 1;
            this.btnPersonelGuncelle.IdleCornerRadius = 20;
            this.btnPersonelGuncelle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnPersonelGuncelle.IdleForecolor = System.Drawing.Color.White;
            this.btnPersonelGuncelle.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(26, 584);
            this.btnPersonelGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(360, 41);
            this.btnPersonelGuncelle.TabIndex = 79;
            this.btnPersonelGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // dtpPersonelDogumTarihi
            // 
            this.dtpPersonelDogumTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dtpPersonelDogumTarihi.BorderRadius = 0;
            this.dtpPersonelDogumTarihi.ForeColor = System.Drawing.Color.White;
            this.dtpPersonelDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPersonelDogumTarihi.FormatCustom = null;
            this.dtpPersonelDogumTarihi.Location = new System.Drawing.Point(141, 363);
            this.dtpPersonelDogumTarihi.Name = "dtpPersonelDogumTarihi";
            this.dtpPersonelDogumTarihi.Size = new System.Drawing.Size(241, 35);
            this.dtpPersonelDogumTarihi.TabIndex = 78;
            this.dtpPersonelDogumTarihi.Value = new System.DateTime(2017, 11, 24, 19, 24, 18, 0);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(22, 74);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(88, 17);
            this.bunifuCustomLabel11.TabIndex = 77;
            this.bunifuCustomLabel11.Text = "TC Kimlik No";
            this.bunifuCustomLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtTCKimlikNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTCKimlikNo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtTCKimlikNo.BorderThickness = 3;
            this.txtTCKimlikNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTCKimlikNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTCKimlikNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtTCKimlikNo.isPassword = false;
            this.txtTCKimlikNo.Location = new System.Drawing.Point(140, 63);
            this.txtTCKimlikNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(241, 35);
            this.txtTCKimlikNo.TabIndex = 76;
            this.txtTCKimlikNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(23, 461);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(55, 17);
            this.bunifuCustomLabel6.TabIndex = 75;
            this.bunifuCustomLabel6.Text = "Sicil No";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbKlinikler
            // 
            this.cbKlinikler.BackColor = System.Drawing.Color.Transparent;
            this.cbKlinikler.BorderRadius = 3;
            this.cbKlinikler.ForeColor = System.Drawing.Color.White;
            this.cbKlinikler.Items = new string[0];
            this.cbKlinikler.Location = new System.Drawing.Point(142, 490);
            this.cbKlinikler.Name = "cbKlinikler";
            this.cbKlinikler.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.cbKlinikler.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.cbKlinikler.selectedIndex = -1;
            this.cbKlinikler.Size = new System.Drawing.Size(240, 35);
            this.cbKlinikler.TabIndex = 74;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(23, 504);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel3.TabIndex = 73;
            this.bunifuCustomLabel3.Text = "Klinik";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbUnvanlar
            // 
            this.cbUnvanlar.BackColor = System.Drawing.Color.Transparent;
            this.cbUnvanlar.BorderRadius = 3;
            this.cbUnvanlar.ForeColor = System.Drawing.Color.White;
            this.cbUnvanlar.Items = new string[0];
            this.cbUnvanlar.Location = new System.Drawing.Point(141, 406);
            this.cbUnvanlar.Name = "cbUnvanlar";
            this.cbUnvanlar.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.cbUnvanlar.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(62)))));
            this.cbUnvanlar.selectedIndex = -1;
            this.cbUnvanlar.Size = new System.Drawing.Size(240, 35);
            this.cbUnvanlar.TabIndex = 72;
            // 
            // bunifuCustomLabel43
            // 
            this.bunifuCustomLabel43.AutoSize = true;
            this.bunifuCustomLabel43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel43.Location = new System.Drawing.Point(23, 419);
            this.bunifuCustomLabel43.Name = "bunifuCustomLabel43";
            this.bunifuCustomLabel43.Size = new System.Drawing.Size(49, 17);
            this.bunifuCustomLabel43.TabIndex = 71;
            this.bunifuCustomLabel43.Text = "Ünvan";
            // 
            // txtPersonelEvTel
            // 
            this.txtPersonelEvTel.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelEvTel.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelEvTel.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelEvTel.BorderThickness = 3;
            this.txtPersonelEvTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelEvTel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelEvTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelEvTel.isPassword = false;
            this.txtPersonelEvTel.Location = new System.Drawing.Point(141, 278);
            this.txtPersonelEvTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelEvTel.Name = "txtPersonelEvTel";
            this.txtPersonelEvTel.Size = new System.Drawing.Size(241, 35);
            this.txtPersonelEvTel.TabIndex = 38;
            this.txtPersonelEvTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPersonelCepTel
            // 
            this.txtPersonelCepTel.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelCepTel.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelCepTel.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelCepTel.BorderThickness = 3;
            this.txtPersonelCepTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelCepTel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelCepTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelCepTel.isPassword = false;
            this.txtPersonelCepTel.Location = new System.Drawing.Point(141, 235);
            this.txtPersonelCepTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelCepTel.Name = "txtPersonelCepTel";
            this.txtPersonelCepTel.Size = new System.Drawing.Size(241, 35);
            this.txtPersonelCepTel.TabIndex = 35;
            this.txtPersonelCepTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(23, 376);
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
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(20, 293);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(48, 17);
            this.bunifuCustomLabel8.TabIndex = 36;
            this.bunifuCustomLabel8.Text = "Ev Tel";
            // 
            // txtSicilNo
            // 
            this.txtSicilNo.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtSicilNo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSicilNo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtSicilNo.BorderThickness = 3;
            this.txtSicilNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSicilNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSicilNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtSicilNo.isPassword = false;
            this.txtSicilNo.Location = new System.Drawing.Point(141, 448);
            this.txtSicilNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSicilNo.Name = "txtSicilNo";
            this.txtSicilNo.Size = new System.Drawing.Size(241, 35);
            this.txtSicilNo.TabIndex = 34;
            this.txtSicilNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPersonelAdres
            // 
            this.txtPersonelAdres.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelAdres.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelAdres.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelAdres.BorderThickness = 3;
            this.txtPersonelAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelAdres.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelAdres.isPassword = false;
            this.txtPersonelAdres.Location = new System.Drawing.Point(141, 321);
            this.txtPersonelAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelAdres.Name = "txtPersonelAdres";
            this.txtPersonelAdres.Size = new System.Drawing.Size(241, 35);
            this.txtPersonelAdres.TabIndex = 31;
            this.txtPersonelAdres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(20, 247);
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
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(23, 337);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(45, 17);
            this.bunifuCustomLabel10.TabIndex = 32;
            this.bunifuCustomLabel10.Text = "Adres";
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelSoyad.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelSoyad.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelSoyad.BorderThickness = 3;
            this.txtPersonelSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelSoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelSoyad.isPassword = false;
            this.txtPersonelSoyad.Location = new System.Drawing.Point(140, 149);
            this.txtPersonelSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(241, 35);
            this.txtPersonelSoyad.TabIndex = 30;
            this.txtPersonelSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(22, 158);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(108, 17);
            this.bunifuCustomLabel5.TabIndex = 29;
            this.bunifuCustomLabel5.Text = "Personel Soyad";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelAd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPersonelAd.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelAd.BorderThickness = 3;
            this.txtPersonelAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonelAd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPersonelAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtPersonelAd.isPassword = false;
            this.txtPersonelAd.Location = new System.Drawing.Point(140, 106);
            this.txtPersonelAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(241, 35);
            this.txtPersonelAd.TabIndex = 23;
            this.txtPersonelAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(22, 115);
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
            this.panel3.Size = new System.Drawing.Size(407, 56);
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
            this.bunifuThinButton22.Size = new System.Drawing.Size(407, 56);
            this.bunifuThinButton22.TabIndex = 2;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Load += new System.EventHandler(this.FormPersonelIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
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
        private ns1.BunifuMetroTextbox txtPersonelKoduAra;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuMetroTextbox txtPersonelAdSoyadAra;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuCustomDataGrid dgvPersoneller;
        private ns1.BunifuMetroTextbox txtPersonelSoyad;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuMetroTextbox txtPersonelAd;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuMetroTextbox txtPersonelEvTel;
        private ns1.BunifuMetroTextbox txtPersonelCepTel;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private ns1.BunifuCustomLabel bunifuCustomLabel8;
        private ns1.BunifuMetroTextbox txtSicilNo;
        private ns1.BunifuMetroTextbox txtPersonelAdres;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private ns1.BunifuCustomLabel bunifuCustomLabel11;
        private ns1.BunifuMetroTextbox txtTCKimlikNo;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuDropdown cbKlinikler;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuDropdown cbUnvanlar;
        private ns1.BunifuCustomLabel bunifuCustomLabel43;
        private ns1.BunifuDatepicker dtpPersonelDogumTarihi;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuThinButton2 btnPersonelSil;
        private ns1.BunifuThinButton2 btnPersonelEkle;
        private ns1.BunifuThinButton2 btnPersonelGuncelle;
        private ns1.BunifuMetroTextbox txtPersonelEmail;
        private ns1.BunifuCustomLabel bunifuCustomLabel12;
    }
}