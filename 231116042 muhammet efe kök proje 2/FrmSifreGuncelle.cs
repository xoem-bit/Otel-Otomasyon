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
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void txtGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici=@p1,Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKulAd.Text);
            komut.Parameters.AddWithValue("@p2", txtsfire.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kullanıcı Adı Ve Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
