using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeanEnergyEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();

            int z = 4;
            int j = 1;
            int kb = 1;
            int t = 1;
            double delta = 0.01;
            double y1, y2;

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            SolidBrush sb1 = new SolidBrush(Color.Green);

            for (double s = -3; s < 3; s += delta)
            {
                gg.FillEllipse(sb, 400 + (float)0 * 50, 200 - (float)s * 50, 2, 2);
                gg.FillEllipse(sb, 400 + (float)s * 50, 200 - (float)0 * 50, 2, 2);
            }

            for (double s = -1.5; s < 1.5; s+=delta)
            {
                y1 = s;
                gg.FillEllipse(sb1, 400 + (float)s * 70, 200 - (float)y1 * 70, 2, 2);

                y2 = Math.Tanh((j * z * s) / (kb * t));
                gg.FillEllipse(sb, 400 + (float)s * 70, 200 - (float)y2 * 70, 2, 2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();

            int z = 4;
            int j = 1;
            int kb = 1;
            int t = 1;
            double delta = 0.001;
            double y;

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            SolidBrush sb1 = new SolidBrush(Color.Green);

            for (double s = -3; s < 3; s += delta)
            {
                gg.FillEllipse(sb, 400 + (float)0 * 50, 200 - (float)s * 50, 2, 2);
                gg.FillEllipse(sb, 400 + (float)s * 50, 200 - (float)0 * 50, 2, 2);
            }

            for (double s = -2.5; s < 2.5; s += delta)
            {
                y = s - Math.Tanh((j * z * s) / (kb * t));
                gg.FillEllipse(sb1, 400 + (float)s * 50, 200 - (float)y * 50, 2, 2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Refresh();

            int z = 4;
            int j = 1;
            int kb = 1;
            //int t = 1;
            double delta = 0.01;
            double sol1, sol2;

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            SolidBrush sb1 = new SolidBrush(Color.Green);
            SolidBrush sb2 = new SolidBrush(Color.Yellow);
            SolidBrush sb3 = new SolidBrush(Color.Blue);

            for (double s = -3; s < 3; s += delta)
            {
                //gg.FillEllipse(sb2, 400 + (float)0 * 50, 400 - (float)s * 50, 2, 2);
                //gg.FillEllipse(sb2, 400 + (float)s * 50, 400 - (float)0 * 50, 2, 2);
            }

            for (double t = 0.1; t < 10; t += delta)
            {
                for (double s = -1.5; s < 1.5; s += delta)
                {
                    sol1 = s;
                    //gg.FillEllipse(sb1, 400 + (float)s * 70, 400 - (float)sol1 * 70, 2, 2);

                    sol2 = Math.Tanh((j * z * s) / (kb * t));
                    //gg.FillEllipse(sb, 400 + (float)s * 70, 400 - (float)sol2 * 70, 2, 2);

                    if (Math.Abs(sol1 - sol2) < 0.01)
                    {
                        //gg.FillEllipse(sb3, 400 + (float)sol1 * 70, 400 - (float)t * 70, 2, 2);
                        gg.FillEllipse(sb, 50 + (float)t * 70, 300 - (float)sol1 * 70, 2, 2);
                    }
                    if ((Math.Round(sol1, 2) == Math.Round(sol2, 2)) && (t == 0.1))
                    {
                        textBox1.Text += textBox1.Text + sol1 + "\r\n";
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Refresh();

            int z = 4;
            int j = 1;
            int kb = 1;
            //int t = 1;
            double delta = 0.01;
            double sol1, sol2;

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Red);
            SolidBrush sb1 = new SolidBrush(Color.Green);
            SolidBrush sb2 = new SolidBrush(Color.Yellow);
            SolidBrush sb3 = new SolidBrush(Color.Blue);

            for (double s = -3; s < 3; s += delta)
            {
                //gg.FillEllipse(sb2, 400 + (float)0 * 50, 400 - (float)s * 50, 2, 2);
                //gg.FillEllipse(sb2, 400 + (float)s * 50, 400 - (float)0 * 50, 2, 2);
            }

            for (double t = 10; t > 0.1; t -= delta)
            {
                for (double s = -1.5; s < 1.5; s += delta)
                {
                    sol1 = s;
                    //gg.FillEllipse(sb1, 400 + (float)s * 70, 400 - (float)sol1 * 70, 2, 2);

                    sol2 = Math.Tanh((j * z * s) / (kb * t));
                    //gg.FillEllipse(sb, 400 + (float)s * 70, 400 - (float)sol2 * 70, 2, 2);

                    if (Math.Abs(sol1 - sol2) < 0.01)
                    {
                        //gg.FillEllipse(sb3, 400 + (float)sol1 * 70, 400 - (float)t * 70, 2, 2);
                        gg.FillEllipse(sb, 50 + (float)t * 70, 300 - (float)sol1 * 70, 2, 2);
                    }
                    if ((Math.Round(sol1, 2) == Math.Round(sol2, 2)) && (t == 0.1))
                    {
                        textBox1.Text += textBox1.Text + sol1 + "\r\n";
                    }
                }
            }
        }
    }
}
