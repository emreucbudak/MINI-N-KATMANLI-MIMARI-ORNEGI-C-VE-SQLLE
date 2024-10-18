using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LogicLayer.LogicLayer.LogicListele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityPersonel pers = new EntityPersonel();
            pers.ID1 = int.Parse(textBox1.Text);
            pers.Ad = textBox2.Text;
            pers.Soyad = textBox3.Text;
            pers.Sehir = textBox4.Text;
            pers.Gorev = textBox5.Text;
            pers.Maas = int.Parse(textBox6.Text);
            LogicLayer.LogicLayer.personelGuncelle(pers);
            MessageBox.Show("Güncelleme Başarılı", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonel per = new EntityPersonel();
            per.Ad = textBox2.Text;
            per.Soyad = textBox3.Text;
            per.Sehir = textBox4.Text;
            per.Gorev = textBox5.Text;
            per.Maas = int.Parse(textBox6.Text);
            LogicLayer.LogicLayer.personelEkle(per);
            MessageBox.Show("Ekleme Başarılı","BILGI",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            LogicLayer.LogicLayer.personelSil(x);
            MessageBox.Show("Silme Başarılı", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
