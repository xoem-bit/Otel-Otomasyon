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
    public partial class FrmYenıMusterı : Form
    {
        public FrmYenıMusterı()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdanum.Text = "101";
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdanum.Text = "102";
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdanum.Text = "103";
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdanum.Text = "104";
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdanum.Text = "105";
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdanum.Text = "106";
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadi) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdanum.Text = "107";
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadi) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdanum.Text = "108";
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadi) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdanum.Text = "109";
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadi) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void DTCikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(DTGiris.Text);
            DateTime buyuktarih = Convert.ToDateTime(DTCikis.Text);

            TimeSpan Sonuc;
            Sonuc = buyuktarih - kucuktarih;

            label11.Text = Sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label11.Text) * 50;
            txtUcret.Text = ucret.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
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
            MessageBox.Show("Yeni Müşteri Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            
        }

        private void FrmYenıMusterı_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select * from Oda101", bgl.baglanti());
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            bgl.baglanti().Close();
            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Red;
            }

            SqlCommand komut2 = new SqlCommand("select * from Oda102", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            bgl.baglanti().Close();
            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
            }

            SqlCommand komut3 = new SqlCommand("select * from Oda103", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            bgl.baglanti().Close();
            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
            }

            SqlCommand komut4 = new SqlCommand("select * from Oda104", bgl.baglanti());
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            bgl.baglanti().Close();
            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Red;
            }

            SqlCommand komut5 = new SqlCommand("select * from Oda105", bgl.baglanti());
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            bgl.baglanti().Close();
            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Red;
            }

            SqlCommand komut6 = new SqlCommand("select * from Oda106", bgl.baglanti());
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            bgl.baglanti().Close();
            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Red;
            }

            SqlCommand komut7 = new SqlCommand("select * from Oda107", bgl.baglanti());
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            bgl.baglanti().Close();
            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
            }

            SqlCommand komut8 = new SqlCommand("select * from Oda108", bgl.baglanti());
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            bgl.baglanti().Close();
            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Red;
            }

            SqlCommand komut9 = new SqlCommand("select * from Oda109", bgl.baglanti());
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            bgl.baglanti().Close();
            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
            }
        }
    }
}
