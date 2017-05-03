using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsrpp_3_julia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Figure> f = new List<Figure>();
        public static List<Triangle> f_triangle = new List<Triangle>();
        public static List<Rectangle> f_rectangle = new List<Rectangle>();

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            // вывод исходного массива
            for (int i = 0; i < f.Count; i++)
            {
                textBox1.Text += (
                    Convert.ToString(f[i].Type) + "\t" 
                    + System.Convert.ToString(f[i].perimeter) + "\t x+y = " 
                    + System.Convert.ToString(f[i].x + f[i].y) + "\t" 
                    + f[i].Triangle_Type);
                textBox1.Text += Environment.NewLine;
            }
            f.Sort(Figure.MyClassCompareDate);

            // вывод разделителя
            textBox1.Text += ("__________________________________________________________");
            textBox1.Text += Environment.NewLine;

            // вывод отсортированного массива
            for (int i = 0; i < f.Count; i++)
            {
                textBox1.Text += (
                    Convert.ToString(f[i].Type) + "\t" 
                    + System.Convert.ToString(f[i].perimeter) + "\t x+y = " 
                    + System.Convert.ToString(f[i].x + f[i].y) + "\t" 
                    + f[i].Triangle_Type);
                textBox1.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = System.Convert.ToInt32(textBox2.Text);
                int b = System.Convert.ToInt32(textBox3.Text);
                int c = System.Convert.ToInt32(textBox4.Text);
                int x = System.Convert.ToInt32(textBox5.Text);
                int y = System.Convert.ToInt32(textBox6.Text);
                string str = "";

                Triangle tr = new Triangle(a, b, c, x, y, str);
                f_triangle.Add(tr);
                f.Add(tr);
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = System.Convert.ToInt32(textBox2.Text);
                int b = System.Convert.ToInt32(textBox3.Text);
                int x = System.Convert.ToInt32(textBox5.Text);
                int y = System.Convert.ToInt32(textBox6.Text);
                Rectangle rect = new Rectangle(a, b, x, y);
                f_rectangle.Add(rect);
                f.Add(rect);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Неверный символ!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
