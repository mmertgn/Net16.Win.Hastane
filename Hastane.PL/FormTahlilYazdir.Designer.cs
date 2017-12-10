namespace Hastane.PL
{
    partial class FormTahlilYazdir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTahlilYazdir));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panelbaslik = new System.Windows.Forms.Panel();
            this.bunifuDragControl3 = new ns1.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuThinButton23 = new ns1.BunifuThinButton2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelbaslik.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelbaslik
            // 
            this.panelbaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panelbaslik.Controls.Add(this.bunifuThinButton23);
            this.panelbaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbaslik.Location = new System.Drawing.Point(0, 0);
            this.panelbaslik.Name = "panelbaslik";
            this.panelbaslik.Size = new System.Drawing.Size(819, 41);
            this.panelbaslik.TabIndex = 0;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.bunifuThinButton23;
            this.bunifuDragControl3.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 480);
            this.panel1.TabIndex = 1;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 30;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Tahlil Sonucu";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuThinButton23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.Location = new System.Drawing.Point(0, 0);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(819, 41);
            this.bunifuThinButton23.TabIndex = 3;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hastane.PL.TahlilReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(247, 141);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormTahlilYazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(819, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelbaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTahlilYazdir";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTahlilYazdir";
            this.Load += new System.EventHandler(this.FormTahlilYazdir_Load);
            this.panelbaslik.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelbaslik;
        private ns1.BunifuDragControl bunifuDragControl3;
        private ns1.BunifuThinButton2 bunifuThinButton23;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}