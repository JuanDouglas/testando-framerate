using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Timer = System.Timers.Timer;

namespace Testando_Framerates
{
    public partial class Form1 : Form
    {
        Timer timer;
        Image[] gif;
        int gifAtual;
        int gifRe;
        bool Imagem;
        public Form1()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            btnStart.Enabled = false;
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            int inframerate =int.Parse(tbFramerate.Text);
            double framerate = Convert.ToDouble(new TimeSpan(0,0,0,1).TotalMilliseconds /inframerate);

            if (timer!=null)
            {
                timer.Enabled = false;
                timer = null;
            }
            timer = new Timer(framerate);
            timer.Enabled = true;

                timer.Elapsed += new ElapsedEventHandler((object sender2, ElapsedEventArgs @event) => {
                    Piscar();
                });

        }
        private void Piscar() {
            if (!Imagem)
            {
                if (!cbColorido.Checked)
                {
                    if (PanelTeste.BackColor == Color.Black)
                    {
                        PanelTeste.BackColor = Color.White;
                    }
                    else
                    {
                        PanelTeste.BackColor = Color.Black;
                    }
                }
                else
                {
                    Random rd = new Random();
                    PanelTeste.BackColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                }
            }
            else
            {
                Update();
            }
        }
        private void PiscarAleatorio()
        {
            Random rd = new Random();

            int inframerate = rd.Next(int.Parse(tbIncial.Text), int.Parse(tbMaximo.Text));
            double framerate = Convert.ToDouble(new TimeSpan(0, 0, 0, 1).TotalMilliseconds / inframerate);
            Piscar();
            timer.Interval = framerate;
        }

        private void tbFramerate_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var tb = (TextBox)sender;
                int con = int.Parse(tb.Text);
                if (PanelAleatorio.Visible==false)
                {
                    if (con >= 1)
                    {
                        btnStart.Enabled = true;
                    }
                }
                else
                {
                    if (con >= 1)
                    {
                        btnStartAleatorio.Enabled = true;
                    }
                    try
                    {
                        int max = int.Parse(tbMaximo.Text);
                        int min = int.Parse(tbIncial.Text);
                        if (min < 1)
                        {
                            btnStartAleatorio.Enabled = false;
                        }
                        else if (max<min)
                        {
                            btnStartAleatorio.Enabled = false;
                        }
                    }
                    catch (Exception)
                    {
                        btnStartAleatorio.Enabled = false;
                    }
                    
                }

            }
            catch (Exception)
            {
                if (PanelAleatorio.Visible == false)
                {
                    btnStart.Enabled = false;
                }
                else
                {
                    btnStartAleatorio.Enabled = false;
                }
            }
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            if (PanelAleatorio.Visible==false)
            {
                PanelAleatorio.Visible = true;
                btnStart.Enabled = false;
                tbFramerate.Enabled = false;
            }
            else
            {
                tbFramerate.Enabled = true;
                btnStart.Enabled = true;
                PanelAleatorio.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            if (timer != null)
            {
                timer.Enabled = false;
                timer = null;
            }
            timer = new Timer(1);
            timer.Enabled = true;
                timer.Elapsed += new ElapsedEventHandler((object sender2, ElapsedEventArgs @event) => {
                    PiscarAleatorio();
                });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btnStop.Enabled = false;
            button1.Enabled = true;
        }
        private Image[] Seleciona(string selecionado) {
            Image[] gif;
            switch (selecionado)
            {
                case "bob":
                    gif = new Image[6];
                    gif[0] = Properties.Resources.bob__1_;
                    gif[1] = Properties.Resources.bob__2_;
                    gif[2] = Properties.Resources.bob__3_;
                    gif[3] = Properties.Resources.bob__4_;
                    gif[4] = Properties.Resources.bob__5_;
                    gif[5] = Properties.Resources.bob__6_;
                    break;
                case "coracao":
                    gif = new Image[13];
                    gif[0] = Properties.Resources.coracao__1_;
                    gif[1] = Properties.Resources.coracao__2_;
                    gif[2] = Properties.Resources.coracao__3_;
                    gif[3] = Properties.Resources.coracao__4_;
                    gif[4] = Properties.Resources.coracao__5_;
                    gif[5] = Properties.Resources.coracao__6_;
                    gif[6] = Properties.Resources.coracao__7_;
                    gif[7] = Properties.Resources.coracao__8_;
                    gif[8] = Properties.Resources.coracao__9_;
                    gif[9] = Properties.Resources.coracao__10_;
                    gif[10] = Properties.Resources.coracao__11_;
                    gif[11] = Properties.Resources.coracao__12_;
                    gif[12] = Properties.Resources.coracao__13_;
                    break;
                default:
                    gif = new Image[12];
                    gif[0] = Properties.Resources.galinha__1_;
                    gif[1] = Properties.Resources.galinha__2_;
                    gif[2] = Properties.Resources.galinha__3_;
                    gif[3] = Properties.Resources.galinha__4_;
                    gif[4] = Properties.Resources.galinha__5_;
                    gif[5] = Properties.Resources.galinha__6_;
                    gif[6] = Properties.Resources.galinha__7_;
                    gif[7] = Properties.Resources.galinha__8_;
                    gif[8] = Properties.Resources.galinha__9_;
                    gif[9] = Properties.Resources.galinha__10_;
                    gif[10] = Properties.Resources.galinha__11_;
                    gif[11] = Properties.Resources.galinha__12_;
                    break;
            }
            return gif;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] values = new string[] { "bob", "coracao", "g" };
            if (gifRe == null)
            {
                gifAtual = 0;
            }
            if (gifRe == values.Length - 1)
            {
                gifRe = 0;
            }
            else
            {
                gifRe++;
            }
            gif = Seleciona(values[gifRe]);
            
            if (Imagem)
            {
                pictureBox1.Visible =false;
                Imagem = false;
                button1.Enabled = true;
                PanelTeste.BackColor = this.BackColor;
            }
            else
            {
                PanelTeste.BackColor = this.BackColor;
                pictureBox1.Visible = true;
                Imagem = true;
                button1.Enabled = false;
            }
        }
        private void Update() {
            if (gifAtual==null)
            {
                gifAtual = 0;
            }
            try
            {
                pictureBox1.Image = gif[gifAtual];
            }
            catch (Exception)
            {
                pictureBox1.Image = gif[0];
                gifAtual = 0;
            }
            if (gifAtual==gif.Length-1)
            {
                gifAtual =0;
            }
            else
            {
                gifAtual++;
            }
        }
    }
}
