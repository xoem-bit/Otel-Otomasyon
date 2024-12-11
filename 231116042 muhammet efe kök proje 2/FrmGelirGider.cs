using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _231116042_muhammet_efe_kök_proje_2
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(txtPersonelsayi.Text);
            label4.Text = (personel * 1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(label3.Text) - (Convert.ToInt32(label4.Text) + Convert.ToInt32(label7.Text) + Convert.ToInt32(label13.Text) + Convert.ToInt32(label14.Text) + Convert.ToInt32(label8.Text) + Convert.ToInt32(label15.Text) + Convert.ToInt32(label16.Text));
            label11.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label3.Text = oku["toplam"].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select sum(Gida) as toplam2 from Stoklar", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                label7.Text = oku2["toplam2"].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut3 = new SqlCommand("select sum(icecek) as toplam3 from Stoklar", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                label13.Text = oku3["toplam3"].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam4 from Stoklar", bgl.baglanti());
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                label14.Text = oku4["toplam4"].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut5 = new SqlCommand("select sum(Elektrik) as toplam5 from Faturalar", bgl.baglanti());
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                label8.Text = oku5["toplam5"].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut6 = new SqlCommand("select sum(Su) as toplam6 from Faturalar", bgl.baglanti());
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                label15.Text = oku6["toplam6"].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut7 = new SqlCommand("select sum(İnternet) as toplam7 from Faturalar", bgl.baglanti());
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                label16.Text = oku7["toplam7"].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
