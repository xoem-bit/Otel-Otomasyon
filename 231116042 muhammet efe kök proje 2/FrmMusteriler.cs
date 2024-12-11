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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void verilergoster()
        {
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            bgl.baglanti().Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = (listView1.SelectedItems[0].SubItems[1].Text);
            txtSoyadi.Text = (listView1.SelectedItems[0].SubItems[2].Text);
            comboBox1.Text = (listView1.SelectedItems[0].SubItems[3].Text);
            mskTel.Text = (listView1.SelectedItems[0].SubItems[4].Text);
            txtmaıl.Text = (listView1.SelectedItems[0].SubItems[5].Text);
            mskTc.Text = (listView1.SelectedItems[0].SubItems[6].Text);
            txtOdanum.Text = (listView1.SelectedItems[0].SubItems[7].Text);
            txtUcret.Text = (listView1.SelectedItems[0].SubItems[8].Text);
            DTGiris.Text = (listView1.SelectedItems[0].SubItems[9].Text);
            DTCikis.Text = (listView1.SelectedItems[0].SubItems[10].Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtOdanum.Text == "101")
            {
                SqlCommand komut = new SqlCommand("delete from Oda101", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilergoster();
            }
            //SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", bgl.baglanti());
            if (txtOdanum.Text == "102")
            {
                SqlCommand komut = new SqlCommand("delete from Oda102", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilergoster();
            }
            if (txtOdanum.Text == "103")
            {
                SqlCommand komut = new SqlCommand("delete from Oda103", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilergoster();
            }
            if (txtOdanum.Text == "104")
            {
                SqlCommand komut = new SqlCommand("delete from Oda104", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilergoster();
            }
            if (txtOdanum.Text == "105")
            {
                SqlCommand komut = new SqlCommand("delete from Oda105", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilergoster();
            }
            if (txtOdanum.Text == "106")
            {
                SqlCommand komut = new SqlCommand("delete from Oda106", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilergoster();
            }
            if (txtOdanum.Text == "107")
            {
                SqlCommand komut = new SqlCommand("delete from Oda107", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilergoster();
            }
            if (txtOdanum.Text == "108")
            {
                SqlCommand komut = new SqlCommand("delete Oda108", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilergoster();
            }
            if (txtOdanum.Text == "109")
            {
                SqlCommand komut = new SqlCommand("delete from Oda109", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                verilergoster();
            }
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            this.UseWaitCursor = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            comboBox1.Text = "";
            mskTel.Clear();
            txtmaıl.Clear();
            mskTc.Clear();
            txtOdanum.Clear();
            txtUcret.Clear();
            DTCikis.Text = "";
            DTGiris.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi=@p1,Soyadi=@p2,Cinsiyet=@p3,Telefon=@p4,Mail=@p5,TC=@p6,OdaNo=@p7,Ucret=@p8,GirisTarihi=@p9,CikisTarihi=@p10 where Musteriid =" + id + "", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            komut.Parameters.AddWithValue("@p4", mskTel.Text);
            komut.Parameters.AddWithValue("@p5", txtmaıl.Text);
            komut.Parameters.AddWithValue("@p6", mskTc.Text);
            komut.Parameters.AddWithValue("@p7", txtOdanum.Text);
            komut.Parameters.AddWithValue("@p8", txtUcret.Text);
            komut.Parameters.AddWithValue("@p9", DTGiris.Value.ToString("yyy-MM-dd"));
            komut.Parameters.AddWithValue("@p10", DTCikis.Value.ToString("yyy-MM-dd"));
            komut.ExecuteNonQuery();
            MessageBox.Show("Müşteri Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            verilergoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%" + txtisim.Text + "%'", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            bgl.baglanti().Close();
        }
    }
}
