using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSvobodaHynek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double soucet = 0, rozdil = 0, nasobeni = 0, deleni = 0, mocnina = 0, odmocnina = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            odmocnina = 0;
            try
            {
                if (textBox1.Text != "" && textBox2.Text == "")
                {
                    if (textBox1.Text != "0")
                    {
                        double a = Convert.ToInt32(textBox1.Text);
                        if (a > 0)
                        {
                            odmocnina = Math.Sqrt(a);
                            label3.Text = Convert.ToString(odmocnina);
                        }
                        else label3.Text = "Nelze určit";
                    }
                    else
                    {
                        label3.Text = "Odmocnina z nuly nelze";
                    }
                }
                else label3.Text = "Nelze urcit";
            }
            catch
            {
                MessageBox.Show("Chyba", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kalkulačka funguje k vypočítání různých operací, např: +,-,/,*,odmocnina a mocnina","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            mocnina = 1;
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    double a = Convert.ToInt32(textBox1.Text);
                    double b = Convert.ToInt32(textBox2.Text);
                    if (b > 0)
                    {
                        for (int i = 0; b > i; i++)
                        {
                            mocnina *= a;
                        }
                    }
                    else
                    {
                        for (int i = 0; b < i; i--)
                        {
                            mocnina *= a;
                        }
                        mocnina = 1 / mocnina;
                    }
                    label3.Text = Convert.ToString(mocnina);
                }
                else label3.Text = "Nelze urcit";
            }
            catch
            {
                MessageBox.Show("Chyba", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            nasobeni = 1;
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {

                    double a = Convert.ToInt32(textBox1.Text);
                    double b = Convert.ToInt32(textBox2.Text);
                    nasobeni *= a * b;
                    label3.Text = Convert.ToString(nasobeni);
                }
                else label3.Text = "Nelze urcit";
            }
            catch
            {
                MessageBox.Show("Chyba", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            deleni = 0;
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    if (textBox2.Text == "0")
                    {
                        label3.Text = "Nelze dělit 0";
                    }
                    else
                    {
                        double a = Convert.ToInt32(textBox1.Text);
                        double b = Convert.ToInt32(textBox2.Text);
                        deleni += a / b;
                        label3.Text = Convert.ToString(deleni);
                    }
                }
                else label3.Text = "Nelze urcit";
            }
            catch
            {
                MessageBox.Show("Chyba", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            rozdil = 0;
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {

                    double a = Convert.ToInt32(textBox1.Text);
                    double b = Convert.ToInt32(textBox2.Text);
                    rozdil += a - b;
                    label3.Text = Convert.ToString(rozdil);
                }
                else label3.Text = "Nelze urcit";
            }
            catch
            {
                MessageBox.Show("Chyba", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            soucet = 0;
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {

                    double a = Convert.ToInt32(textBox1.Text);
                    double b = Convert.ToInt32(textBox2.Text);
                    soucet += a + b;
                    label3.Text = Convert.ToString(soucet);
                }
                else label3.Text = "Nelze urcit";
            }
            catch
            {
                MessageBox.Show("Chyba", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
