using EntityFrameworkCodeFirstCRUD.Data;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCodeFirstCRUD
{
    public partial class Form1 : MetroForm
    {
        GunlukContext db = new GunlukContext();
        public Form1()
        {
            InitializeComponent();
            YazilariListele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstYazilarim.SelectedItem == null) return;

            string baslik = txtBaslik.Text.Trim();
            string icerik = txtIcerik.Text;
            DateTime zaman = DateTime.Now; //aslinda classda propertyde default olarak verdik ama burayada yazdık yazmasakta olurdu.

            if (baslik == "")
            {
                MetroMessageBox.Show(this,"Başlık yazmayı unuttunuz :)","Hata");
                return;
            }

            Yazi yazi = (Yazi)lstYazilarim.SelectedItem; //Yaptıgımız yazıdaki değişikleri kaydetme
            yazi.Baslik = baslik;
            yazi.Icerik = icerik;
            yazi.Zaman = DateTime.Now;
            db.SaveChanges();
            lstYazilarim.DisplayMember="";      ///Başlığında güncellenmesini sağladık
            lstYazilarim.DisplayMember="Baslik";///
            lblZaman.Text = yazi.Zaman.ToString();
        }

        private void YazilariListele()
        {
            lstYazilarim.DataSource = db.Yazilar.OrderByDescending(x => x.Zaman).ToList();
            lstYazilarim.DisplayMember = "Baslik";//lstboxa başlığı yazdırdık
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            db.Yazilar.Add(new Yazi() { Baslik = "Yeni Yazı" }); //+ butonuna tıklayınca yeni yazıları kaydediyor
            db.SaveChanges();

            YazilariListele();
        }

        private void lstYazilarim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYazilarim.SelectedIndex <0)  //Seçtiğimiz yazıyı görüntüleme
            {
                txtBaslik.Clear();
                txtIcerik.Clear();
                lblZaman.Text = "";
                return;
            }

            Yazi yazi = (Yazi)lstYazilarim.SelectedItem;
            txtBaslik.Text = yazi.Baslik;
            txtIcerik.Text = yazi.Icerik;
            lblZaman.Text = yazi.Zaman.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstYazilarim.SelectedItem == null) return;
            Yazi yazi = (Yazi)lstYazilarim.SelectedItem;
            db.Yazilar.Remove(yazi);
            db.SaveChanges();
            YazilariListele();
        }
    }
}
