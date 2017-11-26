namespace Hastane.PL
{
    partial class FormAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlKullaniciBilgileri = new System.Windows.Forms.Panel();
            this.btnKullaniciBilgi = new ns1.BunifuTileButton();
            this.pnlIcerik = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.btnDoktorIslemleri = new ns1.BunifuFlatButton();
            this.btnCikis = new ns1.BunifuFlatButton();
            this.pbSeciliSayfa = new System.Windows.Forms.PictureBox();
            this.btnSistemYonetimi = new ns1.BunifuFlatButton();
            this.btnOdemeIslemleri = new ns1.BunifuFlatButton();
            this.btnTahlilIslemleri = new ns1.BunifuFlatButton();
            this.btnRandevu = new ns1.BunifuFlatButton();
            this.btnPersonelIslemleri = new ns1.BunifuFlatButton();
            this.btnHastaKabul = new ns1.BunifuFlatButton();
            this.btnAnaSayfa = new ns1.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTarih = new ns1.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlKullaniciBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeciliSayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 768);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSistemYonetimi);
            this.panel2.Controls.Add(this.btnTahlilIslemleri);
            this.panel2.Controls.Add(this.btnOdemeIslemleri);
            this.panel2.Controls.Add(this.btnHastaKabul);
            this.panel2.Controls.Add(this.lblTarih);
            this.panel2.Controls.Add(this.btnRandevu);
            this.panel2.Controls.Add(this.btnPersonelIslemleri);
            this.panel2.Controls.Add(this.pbSeciliSayfa);
            this.panel2.Controls.Add(this.btnDoktorIslemleri);
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Controls.Add(this.btnAnaSayfa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 715);
            this.panel2.TabIndex = 17;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(181, 53);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.pnlHeader.Controls.Add(this.pnlKullaniciBilgileri);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(181, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1185, 53);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlKullaniciBilgileri
            // 
            this.pnlKullaniciBilgileri.Controls.Add(this.btnKullaniciBilgi);
            this.pnlKullaniciBilgileri.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlKullaniciBilgileri.Location = new System.Drawing.Point(985, 0);
            this.pnlKullaniciBilgileri.Name = "pnlKullaniciBilgileri";
            this.pnlKullaniciBilgileri.Size = new System.Drawing.Size(200, 53);
            this.pnlKullaniciBilgileri.TabIndex = 2;
            // 
            // btnKullaniciBilgi
            // 
            this.btnKullaniciBilgi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnKullaniciBilgi.color = System.Drawing.Color.DarkSlateGray;
            this.btnKullaniciBilgi.colorActive = System.Drawing.Color.DarkSlateGray;
            this.btnKullaniciBilgi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnKullaniciBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKullaniciBilgi.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnKullaniciBilgi.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciBilgi.Image = null;
            this.btnKullaniciBilgi.ImagePosition = 20;
            this.btnKullaniciBilgi.ImageZoom = 50;
            this.btnKullaniciBilgi.LabelPosition = 41;
            this.btnKullaniciBilgi.LabelText = "";
            this.btnKullaniciBilgi.Location = new System.Drawing.Point(0, 0);
            this.btnKullaniciBilgi.Margin = new System.Windows.Forms.Padding(6);
            this.btnKullaniciBilgi.Name = "btnKullaniciBilgi";
            this.btnKullaniciBilgi.Size = new System.Drawing.Size(200, 53);
            this.btnKullaniciBilgi.TabIndex = 17;
            // 
            // pnlIcerik
            // 
            this.pnlIcerik.AutoScroll = true;
            this.pnlIcerik.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIcerik.Location = new System.Drawing.Point(181, 53);
            this.pnlIcerik.Name = "pnlIcerik";
            this.pnlIcerik.Size = new System.Drawing.Size(1185, 715);
            this.pnlIcerik.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnDoktorIslemleri
            // 
            this.btnDoktorIslemleri.Activecolor = System.Drawing.Color.Transparent;
            this.btnDoktorIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnDoktorIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorIslemleri.BorderRadius = 0;
            this.btnDoktorIslemleri.ButtonText = "Doktor İşlemleri";
            this.btnDoktorIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoktorIslemleri.DisabledColor = System.Drawing.Color.Gray;
            this.btnDoktorIslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoktorIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorIslemleri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDoktorIslemleri.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDoktorIslemleri.Iconimage")));
            this.btnDoktorIslemleri.Iconimage_right = null;
            this.btnDoktorIslemleri.Iconimage_right_Selected = null;
            this.btnDoktorIslemleri.Iconimage_Selected = null;
            this.btnDoktorIslemleri.IconMarginLeft = 0;
            this.btnDoktorIslemleri.IconMarginRight = 0;
            this.btnDoktorIslemleri.IconRightVisible = true;
            this.btnDoktorIslemleri.IconRightZoom = 0D;
            this.btnDoktorIslemleri.IconVisible = true;
            this.btnDoktorIslemleri.IconZoom = 60D;
            this.btnDoktorIslemleri.IsTab = false;
            this.btnDoktorIslemleri.Location = new System.Drawing.Point(0, 44);
            this.btnDoktorIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoktorIslemleri.Name = "btnDoktorIslemleri";
            this.btnDoktorIslemleri.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnDoktorIslemleri.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnDoktorIslemleri.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDoktorIslemleri.selected = false;
            this.btnDoktorIslemleri.Size = new System.Drawing.Size(181, 44);
            this.btnDoktorIslemleri.TabIndex = 1;
            this.btnDoktorIslemleri.Text = "Doktor İşlemleri";
            this.btnDoktorIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoktorIslemleri.Textcolor = System.Drawing.Color.White;
            this.btnDoktorIslemleri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoktorIslemleri.Click += new System.EventHandler(this.btnDoktorIslemleri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Activecolor = System.Drawing.Color.Transparent;
            this.btnCikis.BackColor = System.Drawing.Color.DarkRed;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.BorderRadius = 0;
            this.btnCikis.ButtonText = "Çıkış";
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.DisabledColor = System.Drawing.Color.Gray;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCikis.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCikis.Iconimage")));
            this.btnCikis.Iconimage_right = null;
            this.btnCikis.Iconimage_right_Selected = null;
            this.btnCikis.Iconimage_Selected = null;
            this.btnCikis.IconMarginLeft = 20;
            this.btnCikis.IconMarginRight = 0;
            this.btnCikis.IconRightVisible = true;
            this.btnCikis.IconRightZoom = 0D;
            this.btnCikis.IconVisible = true;
            this.btnCikis.IconZoom = 90D;
            this.btnCikis.IsTab = false;
            this.btnCikis.Location = new System.Drawing.Point(0, 671);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnCikis.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnCikis.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCikis.selected = false;
            this.btnCikis.Size = new System.Drawing.Size(181, 44);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Textcolor = System.Drawing.Color.White;
            this.btnCikis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pbSeciliSayfa
            // 
            this.pbSeciliSayfa.BackColor = System.Drawing.Color.Orange;
            this.pbSeciliSayfa.Location = new System.Drawing.Point(176, 0);
            this.pbSeciliSayfa.Name = "pbSeciliSayfa";
            this.pbSeciliSayfa.Size = new System.Drawing.Size(6, 43);
            this.pbSeciliSayfa.TabIndex = 3;
            this.pbSeciliSayfa.TabStop = false;
            // 
            // btnSistemYonetimi
            // 
            this.btnSistemYonetimi.Activecolor = System.Drawing.Color.Transparent;
            this.btnSistemYonetimi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnSistemYonetimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSistemYonetimi.BorderRadius = 0;
            this.btnSistemYonetimi.ButtonText = "Sistem Yönetimi";
            this.btnSistemYonetimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSistemYonetimi.DisabledColor = System.Drawing.Color.Gray;
            this.btnSistemYonetimi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSistemYonetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSistemYonetimi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSistemYonetimi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSistemYonetimi.Iconimage")));
            this.btnSistemYonetimi.Iconimage_right = null;
            this.btnSistemYonetimi.Iconimage_right_Selected = null;
            this.btnSistemYonetimi.Iconimage_Selected = null;
            this.btnSistemYonetimi.IconMarginLeft = 0;
            this.btnSistemYonetimi.IconMarginRight = 0;
            this.btnSistemYonetimi.IconRightVisible = true;
            this.btnSistemYonetimi.IconRightZoom = 0D;
            this.btnSistemYonetimi.IconVisible = true;
            this.btnSistemYonetimi.IconZoom = 60D;
            this.btnSistemYonetimi.IsTab = false;
            this.btnSistemYonetimi.Location = new System.Drawing.Point(0, 308);
            this.btnSistemYonetimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSistemYonetimi.Name = "btnSistemYonetimi";
            this.btnSistemYonetimi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnSistemYonetimi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnSistemYonetimi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSistemYonetimi.selected = false;
            this.btnSistemYonetimi.Size = new System.Drawing.Size(181, 44);
            this.btnSistemYonetimi.TabIndex = 7;
            this.btnSistemYonetimi.Text = "Sistem Yönetimi";
            this.btnSistemYonetimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSistemYonetimi.Textcolor = System.Drawing.Color.White;
            this.btnSistemYonetimi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistemYonetimi.Click += new System.EventHandler(this.btnSistemYonetimi_Click);
            // 
            // btnOdemeIslemleri
            // 
            this.btnOdemeIslemleri.Activecolor = System.Drawing.Color.Transparent;
            this.btnOdemeIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnOdemeIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdemeIslemleri.BorderRadius = 0;
            this.btnOdemeIslemleri.ButtonText = "Ödeme İşlemleri";
            this.btnOdemeIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdemeIslemleri.DisabledColor = System.Drawing.Color.Gray;
            this.btnOdemeIslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOdemeIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeIslemleri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOdemeIslemleri.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOdemeIslemleri.Iconimage")));
            this.btnOdemeIslemleri.Iconimage_right = null;
            this.btnOdemeIslemleri.Iconimage_right_Selected = null;
            this.btnOdemeIslemleri.Iconimage_Selected = null;
            this.btnOdemeIslemleri.IconMarginLeft = 0;
            this.btnOdemeIslemleri.IconMarginRight = 0;
            this.btnOdemeIslemleri.IconRightVisible = true;
            this.btnOdemeIslemleri.IconRightZoom = 0D;
            this.btnOdemeIslemleri.IconVisible = true;
            this.btnOdemeIslemleri.IconZoom = 60D;
            this.btnOdemeIslemleri.IsTab = false;
            this.btnOdemeIslemleri.Location = new System.Drawing.Point(0, 220);
            this.btnOdemeIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdemeIslemleri.Name = "btnOdemeIslemleri";
            this.btnOdemeIslemleri.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnOdemeIslemleri.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnOdemeIslemleri.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOdemeIslemleri.selected = false;
            this.btnOdemeIslemleri.Size = new System.Drawing.Size(181, 44);
            this.btnOdemeIslemleri.TabIndex = 5;
            this.btnOdemeIslemleri.Text = "Ödeme İşlemleri";
            this.btnOdemeIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOdemeIslemleri.Textcolor = System.Drawing.Color.White;
            this.btnOdemeIslemleri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdemeIslemleri.Click += new System.EventHandler(this.btnOdemeIslemleri_Click);
            // 
            // btnTahlilIslemleri
            // 
            this.btnTahlilIslemleri.Activecolor = System.Drawing.Color.Transparent;
            this.btnTahlilIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnTahlilIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTahlilIslemleri.BorderRadius = 0;
            this.btnTahlilIslemleri.ButtonText = "Tahlil İşlemleri";
            this.btnTahlilIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTahlilIslemleri.DisabledColor = System.Drawing.Color.Gray;
            this.btnTahlilIslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTahlilIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahlilIslemleri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTahlilIslemleri.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTahlilIslemleri.Iconimage")));
            this.btnTahlilIslemleri.Iconimage_right = null;
            this.btnTahlilIslemleri.Iconimage_right_Selected = null;
            this.btnTahlilIslemleri.Iconimage_Selected = null;
            this.btnTahlilIslemleri.IconMarginLeft = 0;
            this.btnTahlilIslemleri.IconMarginRight = 0;
            this.btnTahlilIslemleri.IconRightVisible = true;
            this.btnTahlilIslemleri.IconRightZoom = 0D;
            this.btnTahlilIslemleri.IconVisible = true;
            this.btnTahlilIslemleri.IconZoom = 60D;
            this.btnTahlilIslemleri.IsTab = false;
            this.btnTahlilIslemleri.Location = new System.Drawing.Point(0, 264);
            this.btnTahlilIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTahlilIslemleri.Name = "btnTahlilIslemleri";
            this.btnTahlilIslemleri.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnTahlilIslemleri.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnTahlilIslemleri.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTahlilIslemleri.selected = false;
            this.btnTahlilIslemleri.Size = new System.Drawing.Size(181, 44);
            this.btnTahlilIslemleri.TabIndex = 6;
            this.btnTahlilIslemleri.Text = "Tahlil İşlemleri";
            this.btnTahlilIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTahlilIslemleri.Textcolor = System.Drawing.Color.White;
            this.btnTahlilIslemleri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTahlilIslemleri.Click += new System.EventHandler(this.btnTahlilIslemleri_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.Activecolor = System.Drawing.Color.Transparent;
            this.btnRandevu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnRandevu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandevu.BorderRadius = 0;
            this.btnRandevu.ButtonText = "Randevu İşlemleri";
            this.btnRandevu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandevu.DisabledColor = System.Drawing.Color.Gray;
            this.btnRandevu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRandevu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRandevu.Iconimage")));
            this.btnRandevu.Iconimage_right = null;
            this.btnRandevu.Iconimage_right_Selected = null;
            this.btnRandevu.Iconimage_Selected = null;
            this.btnRandevu.IconMarginLeft = 0;
            this.btnRandevu.IconMarginRight = 0;
            this.btnRandevu.IconRightVisible = true;
            this.btnRandevu.IconRightZoom = 0D;
            this.btnRandevu.IconVisible = true;
            this.btnRandevu.IconZoom = 60D;
            this.btnRandevu.IsTab = false;
            this.btnRandevu.Location = new System.Drawing.Point(0, 132);
            this.btnRandevu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnRandevu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnRandevu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRandevu.selected = false;
            this.btnRandevu.Size = new System.Drawing.Size(181, 44);
            this.btnRandevu.TabIndex = 3;
            this.btnRandevu.Text = "Randevu İşlemleri";
            this.btnRandevu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRandevu.Textcolor = System.Drawing.Color.White;
            this.btnRandevu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // btnPersonelIslemleri
            // 
            this.btnPersonelIslemleri.Activecolor = System.Drawing.Color.Transparent;
            this.btnPersonelIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnPersonelIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonelIslemleri.BorderRadius = 0;
            this.btnPersonelIslemleri.ButtonText = "Personel İşlemleri";
            this.btnPersonelIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelIslemleri.DisabledColor = System.Drawing.Color.Gray;
            this.btnPersonelIslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonelIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelIslemleri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPersonelIslemleri.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPersonelIslemleri.Iconimage")));
            this.btnPersonelIslemleri.Iconimage_right = null;
            this.btnPersonelIslemleri.Iconimage_right_Selected = null;
            this.btnPersonelIslemleri.Iconimage_Selected = null;
            this.btnPersonelIslemleri.IconMarginLeft = 0;
            this.btnPersonelIslemleri.IconMarginRight = 0;
            this.btnPersonelIslemleri.IconRightVisible = true;
            this.btnPersonelIslemleri.IconRightZoom = 0D;
            this.btnPersonelIslemleri.IconVisible = true;
            this.btnPersonelIslemleri.IconZoom = 60D;
            this.btnPersonelIslemleri.IsTab = false;
            this.btnPersonelIslemleri.Location = new System.Drawing.Point(0, 88);
            this.btnPersonelIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPersonelIslemleri.Name = "btnPersonelIslemleri";
            this.btnPersonelIslemleri.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnPersonelIslemleri.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnPersonelIslemleri.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPersonelIslemleri.selected = false;
            this.btnPersonelIslemleri.Size = new System.Drawing.Size(181, 44);
            this.btnPersonelIslemleri.TabIndex = 2;
            this.btnPersonelIslemleri.Text = "Personel İşlemleri";
            this.btnPersonelIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersonelIslemleri.Textcolor = System.Drawing.Color.White;
            this.btnPersonelIslemleri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelIslemleri.Click += new System.EventHandler(this.btnPersonelIslemleri_Click);
            // 
            // btnHastaKabul
            // 
            this.btnHastaKabul.Activecolor = System.Drawing.Color.Transparent;
            this.btnHastaKabul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnHastaKabul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaKabul.BorderRadius = 0;
            this.btnHastaKabul.ButtonText = "Hasta Kabul";
            this.btnHastaKabul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHastaKabul.DisabledColor = System.Drawing.Color.Gray;
            this.btnHastaKabul.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHastaKabul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaKabul.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHastaKabul.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHastaKabul.Iconimage")));
            this.btnHastaKabul.Iconimage_right = null;
            this.btnHastaKabul.Iconimage_right_Selected = null;
            this.btnHastaKabul.Iconimage_Selected = null;
            this.btnHastaKabul.IconMarginLeft = 0;
            this.btnHastaKabul.IconMarginRight = 0;
            this.btnHastaKabul.IconRightVisible = true;
            this.btnHastaKabul.IconRightZoom = 0D;
            this.btnHastaKabul.IconVisible = true;
            this.btnHastaKabul.IconZoom = 60D;
            this.btnHastaKabul.IsTab = false;
            this.btnHastaKabul.Location = new System.Drawing.Point(0, 176);
            this.btnHastaKabul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHastaKabul.Name = "btnHastaKabul";
            this.btnHastaKabul.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnHastaKabul.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnHastaKabul.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHastaKabul.selected = false;
            this.btnHastaKabul.Size = new System.Drawing.Size(181, 44);
            this.btnHastaKabul.TabIndex = 4;
            this.btnHastaKabul.Text = "Hasta Kabul";
            this.btnHastaKabul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHastaKabul.Textcolor = System.Drawing.Color.White;
            this.btnHastaKabul.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHastaKabul.Click += new System.EventHandler(this.btnHastaKabul_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Activecolor = System.Drawing.Color.Transparent;
            this.btnAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnAnaSayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaSayfa.BorderRadius = 0;
            this.btnAnaSayfa.ButtonText = "Anasayfa";
            this.btnAnaSayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaSayfa.DisabledColor = System.Drawing.Color.Gray;
            this.btnAnaSayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnaSayfa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.Iconimage")));
            this.btnAnaSayfa.Iconimage_right = null;
            this.btnAnaSayfa.Iconimage_right_Selected = null;
            this.btnAnaSayfa.Iconimage_Selected = null;
            this.btnAnaSayfa.IconMarginLeft = 0;
            this.btnAnaSayfa.IconMarginRight = 0;
            this.btnAnaSayfa.IconRightVisible = true;
            this.btnAnaSayfa.IconRightZoom = 0D;
            this.btnAnaSayfa.IconVisible = true;
            this.btnAnaSayfa.IconZoom = 60D;
            this.btnAnaSayfa.IsTab = false;
            this.btnAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnAnaSayfa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnAnaSayfa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAnaSayfa.selected = false;
            this.btnAnaSayfa.Size = new System.Drawing.Size(181, 44);
            this.btnAnaSayfa.TabIndex = 0;
            this.btnAnaSayfa.Text = "Anasayfa";
            this.btnAnaSayfa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnaSayfa.Textcolor = System.Drawing.Color.White;
            this.btnAnaSayfa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTarih
            // 
            this.lblTarih.Activecolor = System.Drawing.Color.Transparent;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblTarih.BorderRadius = 0;
            this.lblTarih.ButtonText = "Tarih : ";
            this.lblTarih.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTarih.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.lblTarih.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTarih.Enabled = false;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Iconcolor = System.Drawing.Color.Transparent;
            this.lblTarih.Iconimage = null;
            this.lblTarih.Iconimage_right = null;
            this.lblTarih.Iconimage_right_Selected = null;
            this.lblTarih.Iconimage_Selected = null;
            this.lblTarih.IconMarginLeft = 20;
            this.lblTarih.IconMarginRight = 0;
            this.lblTarih.IconRightVisible = true;
            this.lblTarih.IconRightZoom = 0D;
            this.lblTarih.IconVisible = true;
            this.lblTarih.IconZoom = 90D;
            this.lblTarih.IsTab = false;
            this.lblTarih.Location = new System.Drawing.Point(0, 627);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Normalcolor = System.Drawing.Color.DarkRed;
            this.lblTarih.OnHovercolor = System.Drawing.Color.Firebrick;
            this.lblTarih.OnHoverTextColor = System.Drawing.Color.White;
            this.lblTarih.selected = true;
            this.lblTarih.Size = new System.Drawing.Size(181, 44);
            this.lblTarih.TabIndex = 9;
            this.lblTarih.Text = "Tarih : ";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTarih.Textcolor = System.Drawing.Color.White;
            this.lblTarih.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlIcerik);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnaSayfa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnaSayfa";
            this.Load += new System.EventHandler(this.FormAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlKullaniciBilgileri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSeciliSayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlKullaniciBilgileri;
        private System.Windows.Forms.Panel pnlIcerik;
        private ns1.BunifuFlatButton btnTahlilIslemleri;
        private ns1.BunifuFlatButton btnSistemYonetimi;
        private ns1.BunifuFlatButton btnOdemeIslemleri;
        private ns1.BunifuFlatButton btnPersonelIslemleri;
        private ns1.BunifuFlatButton btnAnaSayfa;
        private ns1.BunifuFlatButton btnHastaKabul;
        private ns1.BunifuFlatButton btnRandevu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbSeciliSayfa;
        private ns1.BunifuFlatButton btnCikis;
        private ns1.BunifuTileButton btnKullaniciBilgi;
        private ns1.BunifuFlatButton btnDoktorIslemleri;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timer1;
        private ns1.BunifuFlatButton lblTarih;
    }
}