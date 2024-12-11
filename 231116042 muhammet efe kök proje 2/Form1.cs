using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116042_muhammet_efe_kök_proje_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void txtGiris_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from AdminGiris where Kullanici=@p1 AND Sifre=@p2";
                SqlParameter prm1 = new SqlParameter("@p1", txtKulAd.Text.Trim());
                SqlParameter prm2 = new SqlParameter("@p2", txtsfire.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, bgl.baglanti());
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
            }          
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
