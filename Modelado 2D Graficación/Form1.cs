using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelado_2D_Graficación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            x1.Enabled = false;
            y1.Enabled = false;
            x2.Enabled = false;
            y2.Enabled = false;
            x3.Enabled = false;
            y3.Enabled = false;
            x4.Enabled = false;
            y4.Enabled = false;
            x5.Enabled = false;
            y5.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            System.Drawing.Pen linepen;
            linepen = new System.Drawing.Pen(System.Drawing.Color.Purple);
            System.Drawing.Graphics g = Dibuja.CreateGraphics();
            g.DrawLine(linepen, Dibuja.Width / 2, 0, Dibuja.Width / 2, Dibuja.Height);
            g.DrawLine(linepen, 0, Dibuja.Height / 2, Dibuja.Width, Dibuja.Height / 2);
        }

        private void cbxPuntos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPuntos.Text == "1")
            {
                x1.Enabled = true;
                y1.Enabled = true;
                x2.Enabled = false;
                y2.Enabled = false;
                x3.Enabled = false;
                y3.Enabled = false;
                x4.Enabled = false;
                y4.Enabled = false;
                x5.Enabled = false;
                y5.Enabled = false;
            }
            if (cbxPuntos.Text == "2")
            {
                x1.Enabled = true;
                y1.Enabled = true;
                x2.Enabled = true;
                y2.Enabled = true;
                x3.Enabled = false;
                y3.Enabled = false;
                x4.Enabled = false;
                y4.Enabled = false;
                x5.Enabled = false;
                y5.Enabled = false;
            }
            if (cbxPuntos.Text == "3")
            {
                x1.Enabled = true;
                y1.Enabled = true;
                x2.Enabled = true;
                y2.Enabled = true;
                x3.Enabled = true;
                y3.Enabled = true;
                x4.Enabled = false;
                y4.Enabled = false;
                x5.Enabled = false;
                y5.Enabled = false;
            }

            if (cbxPuntos.Text == "4")
            {
                x1.Enabled = true;
                y1.Enabled = true;
                x2.Enabled = true;
                y2.Enabled = true;
                x3.Enabled = true;
                y3.Enabled = true;
                x4.Enabled = true;
                y4.Enabled = true;
                x5.Enabled = false;
                y5.Enabled = false;
            }

            if (cbxPuntos.Text == "5")
            {
                x1.Enabled = true;
                y1.Enabled = true;
                x2.Enabled = true;
                y2.Enabled = true;
                x3.Enabled = true;
                y3.Enabled = true;
                x4.Enabled = true;
                y4.Enabled = true;
                x5.Enabled = true;
                y5.Enabled = true;
            }
        }

        private void metroComboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "Grafico")
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panelRotar.Visible = false;
                panelses.Visible = false;
                escalar.Visible = false;
            }
            if (metroComboBox1.Text == "Rotar")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panelRotar.Visible = true;
                panelses.Visible = false;
                escalar.Visible = false;
            }
            if (metroComboBox1.Text == "Traslacion")
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panelRotar.Visible = false;
                panelses.Visible = false;
                escalar.Visible = false;
            }
            if (metroComboBox1.Text == "Sesgado")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panelRotar.Visible = false;
                panelses.Visible = true;
                escalar.Visible = false;
            }
            if (metroComboBox1.Text == "Escalacion")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panelRotar.Visible = false;
                panelses.Visible = false;
                escalar.Visible = true;
            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            try
            {
                Graphics papel;
                papel = Dibuja.CreateGraphics();
                Pen Pluma = new Pen(Color.Blue);

                if (cbxPuntos.Text == "1")
                {
                    double c1 = double.Parse(x1.Text) * 10;
                    double c2 = double.Parse(y1.Text) * 10;

                    Bitmap b = new Bitmap(1, 1);
                    b.SetPixel(0, 0, Color.Red);
                    papel.DrawImageUnscaled(b, 250 + (int)c1, 250 - (int)c2);
                }
                if (cbxPuntos.Text == "2")
                {
                    double c1 = double.Parse(x1.Text) * 10;
                    double c2 = double.Parse(y1.Text) * 10;
                    double c3 = double.Parse(x2.Text) * 10;
                    double c4 = double.Parse(y2.Text) * 10;
                    papel.DrawLine(Pluma, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                    papel.DrawLine(Pluma, (int)c3 + 250, 250 - (int)c4, (int)c1 + 250, 250 - (int)c2);
                }
                if (cbxPuntos.Text == "3")
                {
                    double c1 = double.Parse(x1.Text) * 10;
                    double c2 = double.Parse(y1.Text) * 10;
                    double c3 = double.Parse(x2.Text) * 10;
                    double c4 = double.Parse(y2.Text) * 10;
                    double c5 = double.Parse(x3.Text) * 10;
                    double c6 = double.Parse(y3.Text) * 10;
                    papel.DrawLine(Pluma, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                    papel.DrawLine(Pluma, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                    papel.DrawLine(Pluma, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                }
                if (cbxPuntos.Text == "4")
                {
                    double c1 = double.Parse(x1.Text) * 10;
                    double c2 = double.Parse(y1.Text) * 10;
                    double c3 = double.Parse(x2.Text) * 10;
                    double c4 = double.Parse(y2.Text) * 10;
                    double c5 = double.Parse(x3.Text) * 10;
                    double c6 = double.Parse(y3.Text) * 10;
                    double c7 = double.Parse(x4.Text) * 10;
                    double c8 = double.Parse(y4.Text) * 10;
                    papel.DrawLine(Pluma, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                    papel.DrawLine(Pluma, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                    papel.DrawLine(Pluma, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                    papel.DrawLine(Pluma, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                }
                if (cbxPuntos.Text == "5")
                {
                    double c1 = double.Parse(x1.Text) * 10;
                    double c2 = double.Parse(y1.Text) * 10;
                    double c3 = double.Parse(x2.Text) * 10;
                    double c4 = double.Parse(y2.Text) * 10;
                    double c5 = double.Parse(x3.Text) * 10;
                    double c6 = double.Parse(y3.Text) * 10;
                    double c7 = double.Parse(x4.Text) * 10;
                    double c8 = double.Parse(y4.Text) * 10;
                    double c9 = double.Parse(x5.Text) * 10;
                    double c10 = double.Parse(y5.Text) * 10;
                    papel.DrawLine(Pluma, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                    papel.DrawLine(Pluma, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                    papel.DrawLine(Pluma, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                    papel.DrawLine(Pluma, (int)c7 + 250, 250 - (int)c8, (int)c9 + 250, 250 - (int)c10);
                    papel.DrawLine(Pluma, (int)c9 + 250, 250 - (int)c10, (int)c1 + 250, 250 - (int)c2);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btntrasladar_Click(object sender, EventArgs e)
        {
            int tras_x = int.Parse(txt_trasX.Text) * 10;
            int tras_y = int.Parse(txt_trasY.Text) * 10;

            Graphics papel;
            papel = Dibuja.CreateGraphics();
            Pen Pluma = new Pen(Color.Lime);

            if (cbxPuntos.Text == "1")
            {
                double c1 = double.Parse(x1.Text) * 10;
                double c2 = double.Parse(y1.Text) * 10;
                double tras_xsum = c1;
                double tras_ysum = c2;

                Bitmap b = new Bitmap(1, 1);
                b.SetPixel(0, 0, Color.Red);

                tras_xsum = tras_xsum + tras_x;
                tras_ysum = tras_ysum + tras_y;

                papel.DrawImageUnscaled(b, 250 + (int)tras_xsum, 250 - (int)tras_ysum);
            }
            if (cbxPuntos.Text == "2")
            {
                double c1 = double.Parse(x1.Text) * 10;
                double c2 = double.Parse(y1.Text) * 10;
                double c3 = double.Parse(x2.Text) * 10;
                double c4 = double.Parse(y2.Text) * 10;

                double tras_xsum = c1;
                double tras_ysum = c2;
                double tras_xsum1 = c3;
                double tras_ysum1 = c4;

                tras_xsum = tras_xsum + tras_x;
                tras_ysum = tras_ysum + tras_y;
                tras_xsum1 = tras_xsum1 + tras_x;
                tras_ysum1 = tras_ysum1 + tras_y;

                papel.DrawLine(Pluma, (int)tras_xsum + 250, 250 - (int)tras_ysum, (int)tras_xsum1 + 250, 250 - (int)tras_ysum1);
                papel.DrawLine(Pluma, (int)tras_xsum1 + 250, 250 - (int)tras_ysum1, (int)tras_xsum + 250, 250 - (int)tras_ysum);

            }
            if (cbxPuntos.Text == "3")
            {
                double c1 = double.Parse(x1.Text) * 10;
                double c2 = double.Parse(y1.Text) * 10;
                double c3 = double.Parse(x2.Text) * 10;
                double c4 = double.Parse(y2.Text) * 10;
                double c5 = double.Parse(x3.Text) * 10;
                double c6 = double.Parse(y3.Text) * 10;

                double tras_xsum = c1;
                double tras_ysum = c2;
                double tras_xsum1 = c3;
                double tras_ysum1 = c4;
                double tras_xsum2 = c5;
                double tras_ysum2 = c6;

                tras_xsum = tras_xsum + tras_x;
                tras_ysum = tras_ysum + tras_y;
                tras_xsum1 = tras_xsum1 + tras_x;
                tras_ysum1 = tras_ysum1 + tras_y;
                tras_xsum2 = tras_xsum2 + tras_x;
                tras_ysum2 = tras_ysum2 + tras_y;

                papel.DrawLine(Pluma, (int)tras_xsum + 250, 250 - (int)tras_ysum, (int)tras_xsum1 + 250, 250 - (int)tras_ysum1);
                papel.DrawLine(Pluma, (int)tras_xsum1 + 250, 250 - (int)tras_ysum1, (int)tras_xsum2 + 250, 250 - (int)tras_ysum2);
                papel.DrawLine(Pluma, (int)tras_xsum2 + 250, 250 - (int)tras_ysum2, (int)tras_xsum + 250, 250 - (int)tras_ysum);

            }
            if (cbxPuntos.Text == "4")
            {
                double c1 = double.Parse(x1.Text) * 10;
                double c2 = double.Parse(y1.Text) * 10;
                double c3 = double.Parse(x2.Text) * 10;
                double c4 = double.Parse(y2.Text) * 10;
                double c5 = double.Parse(x3.Text) * 10;
                double c6 = double.Parse(y3.Text) * 10;
                double c7 = double.Parse(x4.Text) * 10;
                double c8 = double.Parse(y4.Text) * 10;

                double tras_xsum = c1;
                double tras_ysum = c2;
                double tras_xsum1 = c3;
                double tras_ysum1 = c4;
                double tras_xsum2 = c5;
                double tras_ysum2 = c6;
                double tras_xsum3 = c7;
                double tras_ysum3 = c8;

                tras_xsum = tras_xsum + tras_x;
                tras_ysum = tras_ysum + tras_y;
                tras_xsum1 = tras_xsum1 + tras_x;
                tras_ysum1 = tras_ysum1 + tras_y;
                tras_xsum2 = tras_xsum2 + tras_x;
                tras_ysum2 = tras_ysum2 + tras_y;
                tras_xsum3 = tras_xsum3 + tras_x;
                tras_ysum3 = tras_ysum3 + tras_y;

                papel.DrawLine(Pluma, (int)tras_xsum + 250, 250 - (int)tras_ysum, (int)tras_xsum1 + 250, 250 - (int)tras_ysum1);
                papel.DrawLine(Pluma, (int)tras_xsum1 + 250, 250 - (int)tras_ysum1, (int)tras_xsum2 + 250, 250 - (int)tras_ysum2);
                papel.DrawLine(Pluma, (int)tras_xsum2 + 250, 250 - (int)tras_ysum2, (int)tras_xsum3 + 250, 250 - (int)tras_ysum3);
                papel.DrawLine(Pluma, (int)tras_xsum3 + 250, 250 - (int)tras_ysum3, (int)tras_xsum + 250, 250 - (int)tras_ysum);
            }
            if (cbxPuntos.Text == "5")
            {
                double c1 = double.Parse(x1.Text) * 10;
                double c2 = double.Parse(y1.Text) * 10;
                double c3 = double.Parse(x2.Text) * 10;
                double c4 = double.Parse(y2.Text) * 10;
                double c5 = double.Parse(x3.Text) * 10;
                double c6 = double.Parse(y3.Text) * 10;
                double c7 = double.Parse(x4.Text) * 10;
                double c8 = double.Parse(y4.Text) * 10;
                double c9 = double.Parse(x5.Text) * 10;
                double c10 = double.Parse(y5.Text) * 10;

                double tras_xsum = c1;
                double tras_ysum = c2;
                double tras_xsum1 = c3;
                double tras_ysum1 = c4;
                double tras_xsum2 = c5;
                double tras_ysum2 = c6;
                double tras_xsum3 = c7;
                double tras_ysum3 = c8;
                double tras_xsum4 = c9;
                double tras_ysum4 = c10;

                tras_xsum = tras_xsum + tras_x;
                tras_ysum = tras_ysum + tras_y;
                tras_xsum1 = tras_xsum1 + tras_x;
                tras_ysum1 = tras_ysum1 + tras_y;
                tras_xsum2 = tras_xsum2 + tras_x;
                tras_ysum2 = tras_ysum2 + tras_y;
                tras_xsum3 = tras_xsum3 + tras_x;
                tras_ysum3 = tras_ysum3 + tras_y;
                tras_xsum4 = tras_xsum4 + tras_x;
                tras_ysum4 = tras_ysum4 + tras_y;

                papel.DrawLine(Pluma, (int)tras_xsum + 250, 250 - (int)tras_ysum, (int)tras_xsum1 + 250, 250 - (int)tras_ysum1);
                papel.DrawLine(Pluma, (int)tras_xsum1 + 250, 250 - (int)tras_ysum1, (int)tras_xsum2 + 250, 250 - (int)tras_ysum2);
                papel.DrawLine(Pluma, (int)tras_xsum2 + 250, 250 - (int)tras_ysum2, (int)tras_xsum3 + 250, 250 - (int)tras_ysum3);
                papel.DrawLine(Pluma, (int)tras_xsum3 + 250, 250 - (int)tras_ysum3, (int)tras_xsum4 + 250, 250 - (int)tras_ysum4);
                papel.DrawLine(Pluma, (int)tras_xsum4 + 250, 250 - (int)tras_ysum4, (int)tras_xsum + 250, 250 - (int)tras_ysum);
            }
        }

        private void btnrotar_Click_1(object sender, EventArgs e)
        {
            System.Drawing.Pen linepen;
            linepen = new System.Drawing.Pen(System.Drawing.Color.Orange);
            System.Drawing.Graphics g = Dibuja.CreateGraphics();

            if (cbxPuntos.Text == "1")
            {
                double c1 = double.Parse(x1.Text) * 10;
                double c2 = double.Parse(y1.Text) * 10;

                double R1 = double.Parse(txt_rotar.Text);
                double AnguloCos = Math.PI * R1 / 180.0;
                double AnguloSin = AnguloCos;

                AnguloCos = Math.Cos(AnguloCos);
                AnguloSin = Math.Sin(AnguloSin);

                if (R1 == 90)
                {
                    AnguloCos = 0;
                    Bitmap b = new Bitmap(1, 1);
                    b.SetPixel(0, 0, Color.Black);
                    double AnguloListo = (c1 * AnguloCos) - (c2 * AnguloSin);
                    double AnguloListo1 = (c1 * AnguloSin) + (c2 * AnguloCos);

                    g.DrawImageUnscaled(b, 250 + (int)AnguloListo, 250 - (int)AnguloListo1);
                }
                else
                {
                    Bitmap b = new Bitmap(1, 1);
                    b.SetPixel(0, 0, Color.Black);
                    double AnguloListo = (c1 * AnguloCos) - (c2 * AnguloSin);
                    double AnguloListo1 = (c1 * AnguloSin) + (c2 * AnguloCos);

                    g.DrawImageUnscaled(b, 250 + (int)AnguloListo, 250 - (int)AnguloListo1);
                }
            }
            if (cbxPuntos.Text == "2")
            {
                double c1 = double.Parse(x1.Text) * 10;
                double c2 = double.Parse(y1.Text) * 10;
                double c3 = double.Parse(x2.Text) * 10;
                double c4 = double.Parse(y2.Text) * 10;

                double R1 = double.Parse(txt_rotar.Text);
                double AnguloCos = Math.PI * R1 / 180.0;
                double AnguloSin = AnguloCos;

                AnguloCos = Math.Cos(AnguloCos);
                AnguloSin = Math.Sin(AnguloSin);

                if (R1 == 90)
                {
                    AnguloCos = 0;
                    double AnguloListo = (c1 * AnguloCos) - (c2 * AnguloSin);
                    double AnguloListo1 = (c1 * AnguloSin) + (c2 * AnguloCos);
                    double AnguloListo2 = (c3 * AnguloCos) - (c4 * AnguloSin);
                    double AnguloListo3 = (c3 * AnguloSin) + (c4 * AnguloCos);

                    g.DrawLine(linepen, (int)AnguloListo + 250, 250 - (int)AnguloListo1, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3);
                    g.DrawLine(linepen, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3, (int)AnguloListo + 250, 250 - (int)AnguloListo1);
                }
                else
                {
                    double AnguloListo = (c1 * AnguloCos) - (c2 * AnguloSin);
                    double AnguloListo1 = (c1 * AnguloSin) + (c2 * AnguloCos);
                    double AnguloListo2 = (c3 * AnguloCos) - (c4 * AnguloSin);
                    double AnguloListo3 = (c3 * AnguloSin) + (c4 * AnguloCos);

                    g.DrawLine(linepen, (int)AnguloListo + 250, 250 - (int)AnguloListo1, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3);
                    g.DrawLine(linepen, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3, (int)AnguloListo + 250, 250 - (int)AnguloListo1);
                }
            }
            if (cbxPuntos.Text == "3")
            {
                double c1 = double.Parse(x1.Text) * 10;
                double c2 = double.Parse(y1.Text) * 10;
                double c3 = double.Parse(x2.Text) * 10;
                double c4 = double.Parse(y2.Text) * 10;
                double c5 = double.Parse(x3.Text) * 10;
                double c6 = double.Parse(y3.Text) * 10;

                double R1 = double.Parse(txt_rotar.Text);
                double AnguloCos = Math.PI * R1 / 180.0;
                double AnguloSin = AnguloCos;

                AnguloCos = Math.Cos(AnguloCos);
                AnguloSin = Math.Sin(AnguloSin);

                if (R1 == 90)
                {
                    AnguloCos = 0;

                    double AnguloListo = (c1 * AnguloCos) - (c2 * AnguloSin);
                    double AnguloListo1 = (c1 * AnguloSin) + (c2 * AnguloCos);
                    double AnguloListo2 = (c3 * AnguloCos) - (c4 * AnguloSin);
                    double AnguloListo3 = (c3 * AnguloSin) + (c4 * AnguloCos);
                    double AnguloListo4 = (c5 * AnguloCos) - (c6 * AnguloSin);
                    double AnguloListo5 = (c5 * AnguloSin) + (c6 * AnguloCos);

                    g.DrawLine(linepen, (int)AnguloListo + 250, 250 - (int)AnguloListo1, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3);
                    g.DrawLine(linepen, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5);
                    g.DrawLine(linepen, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5, (int)AnguloListo + 250, 250 - (int)AnguloListo1);
                }
                else
                {
                    double AnguloListo = (c1 * AnguloCos) - (c2 * AnguloSin);
                    double AnguloListo1 = (c1 * AnguloSin) + (c2 * AnguloCos);
                    double AnguloListo2 = (c3 * AnguloCos) - (c4 * AnguloSin);
                    double AnguloListo3 = (c3 * AnguloSin) + (c4 * AnguloCos);
                    double AnguloListo4 = (c5 * AnguloCos) - (c6 * AnguloSin);
                    double AnguloListo5 = (c5 * AnguloSin) + (c6 * AnguloCos);

                    g.DrawLine(linepen, (int)AnguloListo + 250, 250 - (int)AnguloListo1, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3);
                    g.DrawLine(linepen, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5);
                    g.DrawLine(linepen, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5, (int)AnguloListo + 250, 250 - (int)AnguloListo1);
                }
            }
            if (cbxPuntos.Text == "4")
            {
                double c1 = double.Parse(x1.Text) * 10;
                double c2 = double.Parse(y1.Text) * 10;
                double c3 = double.Parse(x2.Text) * 10;
                double c4 = double.Parse(y2.Text) * 10;
                double c5 = double.Parse(x3.Text) * 10;
                double c6 = double.Parse(y3.Text) * 10;
                double c7 = double.Parse(x4.Text) * 10;
                double c8 = double.Parse(y4.Text) * 10;

                double R1 = double.Parse(txt_rotar.Text);
                double AnguloCos = Math.PI * R1 / 180.0;
                double AnguloSin = AnguloCos;

                AnguloCos = Math.Cos(AnguloCos);
                AnguloSin = Math.Sin(AnguloSin);

                if (R1 == 90)
                {
                    AnguloCos = 0;

                    double AnguloListo = (c1 * AnguloCos) - (c2 * AnguloSin);
                    double AnguloListo1 = (c1 * AnguloSin) + (c2 * AnguloCos);
                    double AnguloListo2 = (c3 * AnguloCos) - (c4 * AnguloSin);
                    double AnguloListo3 = (c3 * AnguloSin) + (c4 * AnguloCos);
                    double AnguloListo4 = (c5 * AnguloCos) - (c6 * AnguloSin);
                    double AnguloListo5 = (c5 * AnguloSin) + (c6 * AnguloCos);
                    double AnguloListo6 = (c7 * AnguloCos) - (c8 * AnguloSin);
                    double AnguloListo7 = (c7 * AnguloSin) + (c8 * AnguloCos);

                    g.DrawLine(linepen, (int)AnguloListo + 250, 250 - (int)AnguloListo1, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3);
                    g.DrawLine(linepen, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5);
                    g.DrawLine(linepen, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5, (int)AnguloListo6 + 250, 250 - (int)AnguloListo7);
                    g.DrawLine(linepen, (int)AnguloListo6 + 250, 250 - (int)AnguloListo7, (int)AnguloListo + 250, 250 - (int)AnguloListo1);
                }
                else
                {
                    double AnguloListo = (c1 * AnguloCos) - (c2 * AnguloSin);
                    double AnguloListo1 = (c1 * AnguloSin) + (c2 * AnguloCos);
                    double AnguloListo2 = (c3 * AnguloCos) - (c4 * AnguloSin);
                    double AnguloListo3 = (c3 * AnguloSin) + (c4 * AnguloCos);
                    double AnguloListo4 = (c5 * AnguloCos) - (c6 * AnguloSin);
                    double AnguloListo5 = (c5 * AnguloSin) + (c6 * AnguloCos);
                    double AnguloListo6 = (c7 * AnguloCos) - (c8 * AnguloSin);
                    double AnguloListo7 = (c7 * AnguloSin) + (c8 * AnguloCos);

                    g.DrawLine(linepen, (int)AnguloListo + 250, 250 - (int)AnguloListo1, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3);
                    g.DrawLine(linepen, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5);
                    g.DrawLine(linepen, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5, (int)AnguloListo6 + 250, 250 - (int)AnguloListo7);
                    g.DrawLine(linepen, (int)AnguloListo6 + 250, 250 - (int)AnguloListo7, (int)AnguloListo + 250, 250 - (int)AnguloListo1);
                }
            }
            if (cbxPuntos.Text == "5")
            {
                double c1 = double.Parse(x1.Text) * 10;
                double c2 = double.Parse(y1.Text) * 10;
                double c3 = double.Parse(x2.Text) * 10;
                double c4 = double.Parse(y2.Text) * 10;
                double c5 = double.Parse(x3.Text) * 10;
                double c6 = double.Parse(y3.Text) * 10;
                double c7 = double.Parse(x4.Text) * 10;
                double c8 = double.Parse(y4.Text) * 10;
                double c9 = double.Parse(x5.Text) * 10;
                double c10 = double.Parse(y5.Text) * 10;

                double R1 = double.Parse(txt_rotar.Text);
                double AnguloCos = Math.PI * R1 / 180.0;
                double AnguloSin = AnguloCos;
                AnguloCos = Math.Cos(AnguloCos);
                AnguloSin = Math.Sin(AnguloSin);

                if (R1 == 90)
                {
                    AnguloCos = 0;
                    double AnguloListo = (c1 * AnguloCos) - (c2 * AnguloSin);
                    double AnguloListo1 = (c1 * AnguloSin) + (c2 * AnguloCos);
                    double AnguloListo2 = (c3 * AnguloCos) - (c4 * AnguloSin);
                    double AnguloListo3 = (c3 * AnguloSin) + (c4 * AnguloCos);
                    double AnguloListo4 = (c5 * AnguloCos) - (c6 * AnguloSin);
                    double AnguloListo5 = (c5 * AnguloSin) + (c6 * AnguloCos);
                    double AnguloListo6 = (c7 * AnguloCos) - (c8 * AnguloSin);
                    double AnguloListo7 = (c7 * AnguloSin) + (c8 * AnguloCos);
                    double AnguloListo8 = (c9 * AnguloCos) - (c10 * AnguloSin);
                    double AnguloListo9 = (c9 * AnguloSin) + (c10 * AnguloCos);

                    g.DrawLine(linepen, (int)AnguloListo + 250, 250 - (int)AnguloListo1, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3);
                    g.DrawLine(linepen, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5);
                    g.DrawLine(linepen, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5, (int)AnguloListo6 + 250, 250 - (int)AnguloListo7);
                    g.DrawLine(linepen, (int)AnguloListo6 + 250, 250 - (int)AnguloListo7, (int)AnguloListo8 + 250, 250 - (int)AnguloListo9);
                    g.DrawLine(linepen, (int)AnguloListo8 + 250, 250 - (int)AnguloListo9, (int)AnguloListo + 250, 250 - (int)AnguloListo1);
                }
                else
                {
                    double AnguloListo = (c1 * AnguloCos) - (c2 * AnguloSin);
                    double AnguloListo1 = (c1 * AnguloSin) + (c2 * AnguloCos);
                    double AnguloListo2 = (c3 * AnguloCos) - (c4 * AnguloSin);
                    double AnguloListo3 = (c3 * AnguloSin) + (c4 * AnguloCos);
                    double AnguloListo4 = (c5 * AnguloCos) - (c6 * AnguloSin);
                    double AnguloListo5 = (c5 * AnguloSin) + (c6 * AnguloCos);
                    double AnguloListo6 = (c7 * AnguloCos) - (c8 * AnguloSin);
                    double AnguloListo7 = (c7 * AnguloSin) + (c8 * AnguloCos);
                    double AnguloListo8 = (c9 * AnguloCos) - (c10 * AnguloSin);
                    double AnguloListo9 = (c9 * AnguloSin) + (c10 * AnguloCos);

                    g.DrawLine(linepen, (int)AnguloListo + 250, 250 - (int)AnguloListo1, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3);
                    g.DrawLine(linepen, (int)AnguloListo2 + 250, 250 - (int)AnguloListo3, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5);
                    g.DrawLine(linepen, (int)AnguloListo4 + 250, 250 - (int)AnguloListo5, (int)AnguloListo6 + 250, 250 - (int)AnguloListo7);
                    g.DrawLine(linepen, (int)AnguloListo6 + 250, 250 - (int)AnguloListo7, (int)AnguloListo8 + 250, 250 - (int)AnguloListo9);
                    g.DrawLine(linepen, (int)AnguloListo8 + 250, 250 - (int)AnguloListo9, (int)AnguloListo + 250, 250 - (int)AnguloListo1);
                }
            }
        }

        private void btnSesgar_Click_2(object sender, EventArgs e)
        {
            System.Drawing.Graphics g = Dibuja.CreateGraphics();
            System.Drawing.Pen LineaPen;
            LineaPen = new System.Drawing.Pen(System.Drawing.Color.Yellow);
            double sesgo = double.Parse(txt_ses.Text) * 10;

            if (cbxPuntos.Text == "2")
            {
                double c1 = double.Parse(x1.Text) * 10;
                double c2 = double.Parse(y1.Text) * 10;
                double c3 = double.Parse(x2.Text) * 10;
                double c4 = double.Parse(y2.Text) * 10;
                if (radioButton6.Checked == true)
                {
                    if (c1 <= c3)
                    {
                        c3 += sesgo;
                        g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                    }
                    //x1 > x2
                    if (c1 > c3)
                    {
                        c1 += sesgo;
                        g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                    }
                }
                else
                {
                    if (radioButton7.Checked == true)
                    {
                        //y1<=y2
                        if (c2 <= c4)
                        {
                            c4 += sesgo;
                            g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                        }
                        //y1>y2
                        if (c2 > c4)
                        {
                            c2 += sesgo;
                            g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                        }
                    }
                }
            }
            else
            {
                if (cbxPuntos.Text == "3")
                {
                    double c1 = double.Parse(x1.Text) * 10;
                    double c2 = double.Parse(y1.Text) * 10;
                    double c3 = double.Parse(x2.Text) * 10;
                    double c4 = double.Parse(y2.Text) * 10;
                    double c5 = double.Parse(x3.Text) * 10;
                    double c6 = double.Parse(y3.Text) * 10;
                    if (radioButton6.Checked == true)
                    {
                        //y1 < y2 && y1 < y3
                        if (c2 < c4 && c2 < c6)
                        {
                            c3 += sesgo;
                            c5 += sesgo;

                            g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                            g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                            g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                        }
                        //y2 < y1 && y2 < y3
                        if (c4 < c2 && c4 < c6)
                        {
                            c1 += sesgo;
                            c5 += sesgo;

                            g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                            g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                            g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                        }
                        //y3 < y1 && y3 < y2
                        if (c6 < c2 && c6 < c4)
                        {
                            c3 += sesgo;
                            c1 += sesgo;

                            g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                            g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                            g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                        }
                        //y1 == y2 && y1 < y3
                        if (c2 == c4 && c2 < c6)
                        {
                            c5 += sesgo;
                            g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                            g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                            g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                        }
                        //y2 == y3 && y2 < y1
                        if (c4 == c6 && c4 < c2)
                        {
                            c1 += sesgo;
                            g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                            g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                            g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                        }
                        //y1 == y3 && y1 < y2
                        if (c2 == c6 && c2 < c4)
                        {
                            c3 += sesgo;
                            g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                            g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                            g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                        }
                    }
                    else
                    {
                        if (radioButton7.Checked == true)
                        {
                            //x1 < x2 && x1 < x3
                            if (c1 < c3 && c1 < c5)
                            {
                                c4 += sesgo;
                                c6 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);

                            }
                            //x2 < x1 && x2 < x3
                            if (c3 < c1 && c3 < c5)
                            {
                                c2 += sesgo;
                                c6 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x3 <x1 && x3 < x2
                            if (c5 < c1 && c5 < c3)
                            {
                                c4 += sesgo;
                                c2 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x1==x2&&x1<x3
                            if (c1 == c3 && c1 < c5)
                            {
                                c6 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x2 == x3 &&x2< x1
                            if (c3 == c5 && c3 < c1)
                            {
                                c2 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x1 == x3 && x1 < x2
                            if (c1 == c5 && c1 < c3)
                            {
                                c4 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c1 + 250, 250 - (int)c2);
                            }
                        }
                    }
                }
                else
                {
                    if (cbxPuntos.Text == "4")
                    {
                        double c1 = double.Parse(x1.Text) * 10;
                        double c2 = double.Parse(y1.Text) * 10;
                        double c3 = double.Parse(x2.Text) * 10;
                        double c4 = double.Parse(y2.Text) * 10;
                        double c5 = double.Parse(x3.Text) * 10;
                        double c6 = double.Parse(y3.Text) * 10;
                        double c7 = double.Parse(x4.Text) * 10;
                        double c8 = double.Parse(y4.Text) * 10;
                        if (radioButton6.Checked == true)
                        {
                            //x1 < x2 && x1 < x3 && x1 < x4
                            if (c1 < c3 && c1 < c5 && c1 < c7)
                            {
                                c4 += sesgo;
                                c6 += sesgo;
                                c8 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x2 < x1 && x2 < x3 && x2 < x4
                            if (c3 < c1 && c3 < c5 && c3 < c7)
                            {
                                c2 += sesgo;
                                c6 += sesgo;
                                c8 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);

                            }
                            //x3 < x2 && x3 < x1 && x3 < x4
                            if (c5 < c3 && c5 < c1 && c5 < c7)
                            {
                                c2 += sesgo;
                                c4 += sesgo;
                                c8 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x4 < x2 && x4 < x3 && x4 < x1
                            if (c7 < c3 && c7 < c5 && c7 < c1)
                            {
                                c2 += sesgo;
                                c4 += sesgo;
                                c6 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x1 == x2 && x1 < x3
                            if (c1 == c3 && c1 < c5)
                            {
                                c6 += sesgo;
                                c8 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x1 == x4 && x1 < x3
                            if (c1 == c7 && c1 < c5)
                            {
                                c6 += sesgo;
                                c4 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x1 == x3 && x1 < x4
                            if (c1 == c5 && c1 < c7)
                            {
                                c8 += sesgo;
                                c4 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x2 == x3 && x2 < x4
                            if (c3 == c5 && c3 < c7)
                            {
                                c8 += sesgo;
                                c2 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x2 == x4 && x2 < x3
                            if (c3 == c7 && c3 < c5)
                            {
                                c6 += sesgo;
                                c2 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                            }
                            //x3 == x4 && x3 < x1
                            if (c5 == c7 && c5 < c1)
                            {
                                c2 += sesgo;
                                c4 += sesgo;
                                g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                            }
                        }
                        else
                        {
                            if (radioButton7.Checked == true)
                            {
                                //y1 < y2 && y1 < y3 && y1 < y4
                                if (c2 < c4 && c2 < c6 && c2 < c8)
                                {
                                    c3 += sesgo;
                                    c5 += sesgo;
                                    c7 += sesgo;
                                    g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                    g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                    g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                    g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                                }
                                //y2 < y1 && y2 < y3 && y2 < y4
                                if (c4 < c2 && c4 < c6 && c4 < c8)
                                {
                                    c1 += sesgo;
                                    c5 += sesgo;
                                    c7 += sesgo;
                                    g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                    g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                    g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                    g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                                }
                                //y3 < y2 && y3 < y1 && y3 < y4
                                if (c6 < c4 && c6 < c2 && c6 < c8)
                                {
                                    c1 += sesgo;
                                    c3 += sesgo;
                                    c7 += sesgo;
                                    g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                    g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                    g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                    g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                                }
                                //y4 < y2 && y4 < y3 && y4 < y1
                                if (c8 < c4 && c8 < c6 && c8 < c2)
                                {
                                    c1 += sesgo;
                                    c3 += sesgo;
                                    c5 += sesgo;
                                    g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                    g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                    g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                    g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                                }
                                //y1 == y2 && y1 < y3
                                if (c2 == c4 && c2 < c6)
                                {
                                    c5 += sesgo;
                                    c7 += sesgo;
                                    g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                    g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                    g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                    g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                                }
                                //y1 == y4 && y1 < y3
                                if (c2 == c8 && c2 < c6)
                                {
                                    c5 += sesgo;
                                    c3 += sesgo;
                                    g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                    g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                    g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                    g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                                }
                                //y1 == y3 && y1 < y4
                                if (c2 == c6 && c2 < c8)
                                {
                                    c7 += sesgo;
                                    c3 += sesgo;
                                    g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                    g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                    g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                    g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                                }
                                //y2 == y3 && y2 < y4
                                if (c4 == c6 && c4 < c6)
                                {
                                    c7 += sesgo;
                                    c1 += sesgo;
                                    g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                    g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                    g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                    g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                                }
                                //y2 == y4 && y2 < y3
                                if (c4 == c8 && c4 < c6)
                                {
                                    c5 += sesgo;
                                    c1 += sesgo;
                                    g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                    g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                    g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                    g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                                }
                                //y3 == y4 && y3 < y1
                                if (c6 == c8 && c6 < c2)
                                {
                                    c3 += sesgo;
                                    c1 += sesgo;
                                    g.DrawLine(LineaPen, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                                    g.DrawLine(LineaPen, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                                    g.DrawLine(LineaPen, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                                    g.DrawLine(LineaPen, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dibuja.Image = null;
            //Limpia txt Grafico
            x1.Clear();
            x2.Clear();
            x3.Clear();
            x4.Clear();
            x5.Clear();
            y1.Clear();
            y2.Clear();
            y3.Clear();
            y4.Clear();
            y5.Clear();
            cbxPuntos.Text = "";

            x1.Enabled = false;
            y1.Enabled = false;
            x2.Enabled = false;
            y2.Enabled = false;
            x3.Enabled = false;
            y3.Enabled = false;
            x4.Enabled = false;
            y4.Enabled = false;
            x5.Enabled = false;
            y5.Enabled = false;

            // Limpia Escalar
            txtescalar.Clear();

            //Limpia Rotar
            txt_rotar.ResetText();

            //Limpia Sesgado
            txt_ses.Clear();

            //Limpiar Traslacion
            txt_trasX.Clear();
            txt_trasY.Clear();

            //Regreso de Herramientas
            metroComboBox1.Text = "Grafico";
        }

        private void btnescalar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Graphics G = Dibuja.CreateGraphics();
                Pen Lapiz = new Pen(Color.Black);
                double k = Convert.ToDouble(txtescalar.Text);
                
                    if (cbxPuntos.Text == "2")
                    {
                        double c1 = double.Parse(x1.Text) * k;
                        double c2 = double.Parse(y1.Text) * k;
                        double c3 = double.Parse(x2.Text) * k;
                        double c4 = double.Parse(y2.Text) * k;

                        G.DrawLine(Lapiz, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                    }
                    if (cbxPuntos.Text == "3")
                    {
                        double c1 = double.Parse(x1.Text) * k;
                        double c2 = double.Parse(y1.Text) * k;
                        double c3 = double.Parse(x2.Text) * k;
                        double c4 = double.Parse(y2.Text) * k;
                        double c5 = double.Parse(x3.Text) * k;
                        double c6 = double.Parse(y3.Text) * k;
                        G.DrawLine(Lapiz, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                        G.DrawLine(Lapiz, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                        G.DrawLine(Lapiz, (int)c1 + 250, 250 - (int)c2, (int)c5 + 250, 250 - (int)c6);
                    }
                    if (cbxPuntos.Text == "4")
                    {
                        double c1 = double.Parse(x1.Text) * k;
                        double c2 = double.Parse(y1.Text) * k;
                        double c3 = double.Parse(x2.Text) * k;
                        double c4 = double.Parse(y2.Text) * k;
                        double c5 = double.Parse(x3.Text) * k;
                        double c6 = double.Parse(y3.Text) * k;
                        double c7 = double.Parse(x4.Text) * k;
                        double c8 = double.Parse(y4.Text) * k;
                        G.DrawLine(Lapiz, (int)c1 + 250, 250 - (int)c2, (int)c3 + 250, 250 - (int)c4);
                        G.DrawLine(Lapiz, (int)c3 + 250, 250 - (int)c4, (int)c5 + 250, 250 - (int)c6);
                        G.DrawLine(Lapiz, (int)c5 + 250, 250 - (int)c6, (int)c7 + 250, 250 - (int)c8);
                        G.DrawLine(Lapiz, (int)c7 + 250, 250 - (int)c8, (int)c1 + 250, 250 - (int)c2);
                    }
            }
            catch (Exception x)
            {
                MessageBox.Show("Ingresa un numero valido" + x);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias Por Utilizar Nuestro Programa.", "Copyright Oficial ©:");
            MessageBox.Show("Arguijo Vazquez Edgar Eduardo - 192310252.", "Copyright Oficial ©: Autor 1");
            MessageBox.Show("Ortiz Godoy Antonio - 192310291.", "Copyright Oficial ©: Autor 2");
        }
    }
}
