using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinav_Notu_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, ort;
            string ad, soyad;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1 = Convert.ToDouble(textBox3.Text);
            s2 = Convert.ToDouble(textBox4.Text);
            proje = Convert.ToDouble(textBox5.Text);
            ort = (s1 + s2 + proje) / 3;
            listBox1.Items.Add("Adı:" + ad +" "+ soyad + " 1.Sınav: " + s1 + " 2.Sınav: " + s2 + " Proje Notu: " + proje);
        }
    }
}
