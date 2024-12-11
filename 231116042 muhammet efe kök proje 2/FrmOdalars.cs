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
    public partial class FrmOdalars : Form
    {
        public FrmOdalars()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void FrmOdalars_Load(object sender, EventArgs e)
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
                btnOda101.Enabled = false;
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
                btnOda102.Enabled = false;
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
                btnOda103.Enabled = false;
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
                btnOda104.Enabled = false;
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
                btnOda105.Enabled = false;
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
                btnOda106.Enabled = false;
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
                btnOda107.Enabled = false;
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
                btnOda108.Enabled = false;
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
                btnOda109.Enabled = false;
                btnOda109.BackColor = Color.Red;
            }
        }
    }
}
