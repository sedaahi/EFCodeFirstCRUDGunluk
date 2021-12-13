
namespace EntityFrameworkCodeFirstCRUD
{
    partial class Form1
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
            if (disposing)
            {
                db.Dispose();
            }
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtBaslik = new MetroFramework.Controls.MetroTextBox();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.lstYazilarim = new System.Windows.Forms.ListBox();
            this.txtIcerik = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnYeni = new MetroFramework.Controls.MetroButton();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.lblZaman = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Yazılarım";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(195, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Başlık";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBaslik.CustomButton.Image = null;
            this.txtBaslik.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txtBaslik.CustomButton.Name = "";
            this.txtBaslik.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBaslik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBaslik.CustomButton.TabIndex = 1;
            this.txtBaslik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBaslik.CustomButton.UseSelectable = true;
            this.txtBaslik.CustomButton.Visible = false;
            this.txtBaslik.Lines = new string[] {
        "Başlık"};
            this.txtBaslik.Location = new System.Drawing.Point(195, 63);
            this.txtBaslik.MaxLength = 32767;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.PasswordChar = '\0';
            this.txtBaslik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBaslik.SelectedText = "";
            this.txtBaslik.SelectionLength = 0;
            this.txtBaslik.SelectionStart = 0;
            this.txtBaslik.ShortcutsEnabled = true;
            this.txtBaslik.Size = new System.Drawing.Size(302, 23);
            this.txtBaslik.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtBaslik.TabIndex = 2;
            this.txtBaslik.Text = "Başlık";
            this.txtBaslik.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBaslik.UseSelectable = true;
            this.txtBaslik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBaslik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Location = new System.Drawing.Point(422, 268);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstYazilarim
            // 
            this.lstYazilarim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstYazilarim.FormattingEnabled = true;
            this.lstYazilarim.ItemHeight = 20;
            this.lstYazilarim.Location = new System.Drawing.Point(24, 73);
            this.lstYazilarim.Name = "lstYazilarim";
            this.lstYazilarim.Size = new System.Drawing.Size(115, 204);
            this.lstYazilarim.TabIndex = 4;
            this.lstYazilarim.SelectedIndexChanged += new System.EventHandler(this.lstYazilarim_SelectedIndexChanged);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtIcerik.CustomButton.Image = null;
            this.txtIcerik.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtIcerik.CustomButton.Name = "";
            this.txtIcerik.CustomButton.Size = new System.Drawing.Size(149, 149);
            this.txtIcerik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIcerik.CustomButton.TabIndex = 1;
            this.txtIcerik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIcerik.CustomButton.UseSelectable = true;
            this.txtIcerik.CustomButton.Visible = false;
            this.txtIcerik.Lines = new string[] {
        "metroTextBox2"};
            this.txtIcerik.Location = new System.Drawing.Point(195, 111);
            this.txtIcerik.MaxLength = 32767;
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.PasswordChar = '\0';
            this.txtIcerik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIcerik.SelectedText = "";
            this.txtIcerik.SelectionLength = 0;
            this.txtIcerik.SelectionStart = 0;
            this.txtIcerik.ShortcutsEnabled = true;
            this.txtIcerik.Size = new System.Drawing.Size(302, 151);
            this.txtIcerik.TabIndex = 6;
            this.txtIcerik.Text = "metroTextBox2";
            this.txtIcerik.UseSelectable = true;
            this.txtIcerik.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIcerik.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(195, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "İçerik";
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.Gray;
            this.btnYeni.Location = new System.Drawing.Point(116, 47);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(23, 23);
            this.btnYeni.TabIndex = 7;
            this.btnYeni.Text = "+";
            this.btnYeni.UseSelectable = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Location = new System.Drawing.Point(341, 268);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblZaman
            // 
            this.lblZaman.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblZaman.AutoSize = true;
            this.lblZaman.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblZaman.ForeColor = System.Drawing.Color.Black;
            this.lblZaman.Location = new System.Drawing.Point(195, 268);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(42, 15);
            this.lblZaman.TabIndex = 9;
            this.lblZaman.Text = "Zaman";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 303);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lstYazilarim);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Günlük";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtBaslik;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private System.Windows.Forms.ListBox lstYazilarim;
        private MetroFramework.Controls.MetroTextBox txtIcerik;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnYeni;
        private MetroFramework.Controls.MetroButton btnSil;
        private MetroFramework.Controls.MetroLabel lblZaman;
    }
}

