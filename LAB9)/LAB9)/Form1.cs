using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB9_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);

                int r = int.Parse(textBox4.Text);
                int x = 100 * int.Parse(textBox5.Text);
                int y = 1000 * int.Parse(textBox6.Text);
                int z = 50 * int.Parse(textBox7.Text);

                if (x == y && x == z)
                {
                    textBox9.Text = "Кормов поровну";
                }
                else if (x < y && x < z)
                {
                    textBox9.Text = "Сено закончится первым";
                }
                else if (y < x && y < z)
                {
                    textBox9.Text = "Силос закончится первым";
                }
                else if (z < x && z < y)
                {
                    textBox9.Text = "Комбикорм закончится первым";
                }

                x /= a;
                y /= b;
                z /= c;
                int kol = 0;

                if (x >= r || y >= r || z >= r)
                {
                    if (x <= y || x <= z)
                    {
                        kol /= r;
                    }
                    if (y < x || y <= z)
                    {
                        kol /= r;
                    }
                    if (z < x || z < y)
                    {
                        kol /= r;
                    }
                }
                textBox8.Text = kol.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
