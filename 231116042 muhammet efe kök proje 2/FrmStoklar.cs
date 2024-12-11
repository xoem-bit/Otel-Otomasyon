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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        
        sqlbaglanti bgl = new sqlbaglanti();

        private void veriler()
        {
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand("select * from Stoklar", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["icecek"].ToString());
                ekle.SubItems.Add(oku["cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            bgl.baglanti().Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into Stoklar (Gida,icecek,Cerezler) values (@p1,@p2,@p3)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txtGida.Text);
            komut1.Parameters.AddWithValue("@p2", txticecek.Text);
            komut1.Parameters.AddWithValue("@p3", txtAtistirmalik.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void txtKaydet2_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into Faturalar (Elektrik,Su,İnternet) values (@p1,@p2,@p3)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtElektrik.Text);
            komut2.Parameters.AddWithValue("@p2", txtSu.Text);
            komut2.Parameters.AddWithValue("@p3", txtİnternet.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            veriler2();
        }
    }
}
