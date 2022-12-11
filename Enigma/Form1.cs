using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Enigma
{


    public partial class Form1 : Form
    {
        public List<Colore> Colori = new List<Colore>()
        {
            new Colore(Color.LightBlue),new Colore(Color.Pink),new Colore(Color.Red),new Colore(Color.Orange),new Colore(Color.Yellow),new Colore(Color.LightGreen),new Colore(Color.ForestGreen),new Colore(Color.White),new Colore(Color.Magenta),new Colore(Color.Teal),new Colore(Color.Purple),new Colore(Color.Beige),new Colore(Color.DarkKhaki),new Colore(Color.Brown),new Colore(Color.Gold), new Colore(Color.Black)
        };

        public List<KeyLink> Links = new List<KeyLink>();

        private char selected = '0';
        public Rotor Rotore1 { get; set; }
        public Rotor Rotore2 { get; set; }
        public Rotor Rotore3 { get; set; }
        public Reflector Riflettore { get; set; }


        public Form1()
        {
            Rotore1 = new Rotor(1);
            Rotore2 = new Rotor(2);
            Rotore3 = new Rotor(3);
            Riflettore = new Reflector(4);

            InitializeComponent();
        }

        private void Ruota(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Rotor rtr = new Rotor(1);

            if (btn.Name.Contains("1"))
            rtr = Rotore1;
            if (btn.Name.Contains("2"))
                rtr = Rotore2;
            if (btn.Name.Contains("3"))
                rtr = Rotore3;


            if (btn.Name.Contains("u"))
                rtr.Gira(true);

            if (btn.Name.Contains("d"))
                rtr.Gira(false);

            lbl_r1.Text = Rotore1.ToString();
            lbl_r2.Text = Rotore2.ToString();
            lbl_r3.Text = Rotore3.ToString();
        }

        private void ChangeReflector(object sender, EventArgs e)
        {
            if (lbl_riflettore.Text == "UKW-B")
            {
                lbl_riflettore.Text = "UKW-C";
                Riflettore = new Reflector(5);
            }
            else
            {
                lbl_riflettore.Text = "UKW-B";
                Riflettore = new Reflector(4);
            }
        }

        private void Link(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            char c = btn.Name[4];

            if (selected == c)
            {
                Colori.Where(col => col.Color == btn.BackColor).First().InUso = false;
                selected = '0';
                btn.BackColor = SystemColors.ControlDarkDark;
                return;
            }

            if (Links.Where(l => l.CompareTo(c) == 0).FirstOrDefault() != null)
            {
                KeyLink link = Links.Where(l => l.CompareTo(c) == 0).First();

                char c2 = link.Letter1 == c ? link.Letter2 : link.Letter1;
                Colori.Where(col => col.Color == btn.BackColor).First().InUso = false;

                foreach (Button b in pan_links.Controls)
                    if (b.Name[4] == c2)
                    {
                        b.BackColor = SystemColors.ControlDarkDark;
                        break;
                    }

                btn.BackColor = SystemColors.ControlDarkDark;


                Links.Remove(link);
            }
            else
            {
                if (selected == '0')
                {
                    btn.BackColor = Colori.First(a => !a.InUso).Color;
                    Colori.First(a => !a.InUso).InUso = true;
                    selected = c;
                }
                else
                {
                    foreach (Button b in pan_links.Controls)
                        if (b.Name[4] == selected)
                        {
                            btn.BackColor = b.BackColor;
                            break;
                        }

                    Links.Add(new KeyLink(c, selected));
                    selected = '0';
                }
            }

        }



        private void txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 8 || e.KeyValue == 13)
            {
                e.SuppressKeyPress = true;
            }

        }

        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_input.KeyPress -= txt_input_KeyPress;

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (char.IsLower(e.KeyChar))
                e.KeyChar = e.KeyChar.ToString().ToUpper()[0];

            char ToCript = e.KeyChar;
            var crypted = ToCript;


            var link = Links.Where(l => l.CompareTo(ToCript.ToString().ToLower()[0]) == 0).FirstOrDefault();
            if (link != null)
                crypted = link.Letter1.ToString().ToUpper()[0] == crypted ? link.Letter2.ToString().ToUpper()[0] : link.Letter1.ToString().ToUpper()[0];

            if (Rotore1.Gira(true))
                Rotore2.Gira(true);
            lbl_r1.Text = Rotore1.ToString();

            crypted = Rotore1.Crypt(crypted);

            crypted = Rotore2.Crypt(crypted);

            crypted = Rotore3.Crypt(crypted);

            crypted = Riflettore.Crypt(crypted);

            crypted = Rotore3.ReverseCrypt(crypted);

            crypted = Rotore2.ReverseCrypt(crypted);

            crypted = Rotore1.ReverseCrypt(crypted);



            var link2 = Links.Where(l => l.CompareTo(crypted.ToString().ToLower()[0]) == 0).FirstOrDefault();
            if (link2 != null)
                crypted = link2.Letter1.ToString().ToUpper()[0] == crypted ? link2.Letter2.ToString().ToUpper()[0] : link2.Letter1.ToString().ToUpper()[0];


            txt_output.Text += crypted;
            txt_input.Text += ToCript;


            Label lbl = null;
            foreach(Label l in pan_letters.Controls)
                if (l.Name.ToUpper()[4] == crypted)
                {
                    lbl = l;
                    break;
                }
            lbl.BackColor = Color.Yellow;
            
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);

            lbl.BackColor = SystemColors.Control;
            txt_input.KeyPress += txt_input_KeyPress;
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            var txt = txt_input.Text.Split(' ');
            if (txt.Last().Length == 4)
            {
                txt_input.Text += " ";
                txt_output.Text += " ";
            }

            txt_input.Focus();
            txt_input.SelectionStart = txt_input.Text.Length;
            txt_input.SelectionLength = 0;
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
            txt_output.Clear();
            txt_input.MaxLength = 1;

            txt_input.Focus();
            txt_input.SelectionStart = txt_input.Text.Length;
            txt_input.SelectionLength = 0;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Rotore1.Giri = 0;
            Rotore1.Lettera = 'A';

            Rotore2.Giri = 0;
            Rotore2.Lettera = 'A';

            Rotore3.Giri = 0;
            Rotore3.Lettera = 'A';

            lbl_r1.Text = Rotore1.ToString();
            lbl_r2.Text = Rotore2.ToString();
            lbl_r3.Text = Rotore3.ToString();

            txt_input.Focus();
            txt_input.SelectionStart = txt_input.Text.Length;
            txt_input.SelectionLength = 0;
        }
    }
}
