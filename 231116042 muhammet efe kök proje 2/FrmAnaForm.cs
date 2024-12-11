using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116042_muhammet_efe_kök_proje_2
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYenıMusterı fr2 = new FrmYenıMusterı();
            fr2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr3 = new FrmMusteriler();
            fr3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pansiyon Kayıt Uygulaması  / 2024 - Samsun");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOdalars fr4 = new FrmOdalars();
            fr4.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr5 = new FrmGelirGider();
            fr5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmStoklar fr6 = new FrmStoklar();
            fr6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle fr7 = new FrmRadyoDinle();
            fr7.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmGazeteler fr8 = new FrmGazeteler();
            fr8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle fr9 = new FrmSifreGuncelle();
            fr9.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr10 = new FrmMesajlar();
            fr10.Show();
        }
    }
}
