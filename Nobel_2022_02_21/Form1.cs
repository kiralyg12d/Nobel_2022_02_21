using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nobel_2022_02_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdatolMentése_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 1 || textBox2.Text.Length <= 1 || textBox3.Text.Length <= 1 || textBox4.Text.Length <= 1)
            {
                MessageBox.Show($"Töltsön ki minden mezőt!");
               
            }
            if (int.Parse(textBox1.Text) <= 1989)
            {
                MessageBox.Show($"AZ évszám nem hibás!");
                
            }
            try
            {
                StreamWriter sw = new StreamWriter("orvosi_nobeldijak.txt");
                sw.WriteLine("Év;Név;Sz/H;Ország");
                sw.WriteLine($"{textBox1.Text};{textBox2.Text};{textBox3.Text};{textBox4.Text}");
                sw.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception error )
            {
                MessageBox.Show($"Hiba a mentés során:\n{error.Message}");
            }
        }
    }
}
