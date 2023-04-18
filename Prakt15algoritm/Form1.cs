using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt15algoritm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Vector v1 = new Vector(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                Vector v2 = new Vector(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
                Vector sumvec = v1 + v2;
                label3.Text = ("Длина нового вектора после сложения: " + Math.Round(sumvec.VecLenght(),3));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch { MessageBox.Show("Найден некорректный ввод данных!", "Сообщение", MessageBoxButtons.OK);}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Vector v1 = new Vector(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                Vector v2 = new Vector(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
                Vector minvec = v1 - v2;
                label3.Text = ("Длина нового вектора после вычитания: " + Math.Round(minvec.VecLenght(),3));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch { MessageBox.Show("Найден некорректный ввод данных!", "Сообщение", MessageBoxButtons.OK); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Vector v1 = new Vector(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                Vector v2 = new Vector(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
                double scalvec = v1 * v2;
                label3.Text = ("Длина нового вектора после скалярного произведения: " + Math.Round(scalvec,3));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch { MessageBox.Show("Найден некорректный ввод данных!", "Сообщение", MessageBoxButtons.OK); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Vector v1 = new Vector(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                Vector v2 = new Vector(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
                label3.Text = ("Косинус угла между векторами: " + Math.Round(v1.Cos(v2),3));
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch { MessageBox.Show("Найден некорректный ввод данных!", "Сообщение", MessageBoxButtons.OK); }
        }
    }
}
