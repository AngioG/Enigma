using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Enigma
{


    public partial class Frm_enigma : Form
    {
        #region Fields
        private List<Colore> Colori = new List<Colore>()
        {
            new Colore(Color.LightBlue),new Colore(Color.Pink),new Colore(Color.Red),new Colore(Color.Orange),new Colore(Color.Yellow),new Colore(Color.LightGreen),new Colore(Color.ForestGreen),new Colore(Color.White),new Colore(Color.Magenta),new Colore(Color.Teal),new Colore(Color.Purple),new Colore(Color.Beige),new Colore(Color.DarkKhaki),new Colore(Color.Brown),new Colore(Color.Gold), new Colore(Color.Black)
        };
        private List<KeyLink> Links = new List<KeyLink>();
        private char selected = '0';
        #endregion

        #region Properties
        public Rotor Rotore1 { get; set; }
        public Rotor Rotore2 { get; set; }
        public Rotor Rotore3 { get; set; }
        public Reflector Riflettore { get; set; }

        public Frm_settings Frm_settings { get; set; }
        public Frm_logs Frm_Logs { get; set; }

        public int Delay { get; set; }
        #endregion

        public Frm_enigma()
        {
            Delay = 750;

            Rotore1 = new Rotor(1);
            Rotore2 = new Rotor(2);
            Rotore3 = new Rotor(3);
            Riflettore = new Reflector(4);

            InitializeComponent();
        }

        #region Settings
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
                rtr.RotateRotor(true);

            if (btn.Name.Contains("d"))
                rtr.RotateRotor(false);

            SetRotorsValue();
        }

        public void SetRotorsValue()
        {
            lbl_r1.Text = Rotore1.ToString();
            lbl_r2.Text = Rotore2.ToString();
            lbl_r3.Text = Rotore3.ToString();

            Application.DoEvents();
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
        #endregion

        #region Encryption
        private void txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 8 || e.KeyValue == 13)
            {
                e.SuppressKeyPress = true;
                if (Frm_Logs != null)
                    Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Invalid character entered"); }));
            }

        }

        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_input.KeyPress -= txt_input_KeyPress;

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                if (Frm_Logs != null)
                    Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Invalid character entered"); }));
                txt_input.KeyPress += txt_input_KeyPress;
                return;
            }

            if (char.IsLower(e.KeyChar))
                e.KeyChar = e.KeyChar.ToString().ToUpper()[0];

            char ToCript = e.KeyChar;

            if (!(ToCript >= 65 && ToCript <= 90))
            {
                e.Handled = true;
                if (Frm_Logs != null)
                    Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Invalid character entered"); }));
                txt_input.KeyPress += txt_input_KeyPress;
                return;
            }

            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Starting encryption..."); }));
            var crypted = CryptChar(ToCript);

            txt_output.Text += crypted;
            txt_input.Text += ToCript;


            Label lbl = null;
            foreach (Label l in pan_letters.Controls)
                if (l.Name.ToUpper()[4] == crypted)
                {
                    lbl = l;
                    break;
                }
            lbl.BackColor = Color.Yellow;

            Application.DoEvents();
            System.Threading.Thread.Sleep(Delay);


            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() =>
                {
                    Frm_Logs.WriteSingleLog($"Character crypted: {crypted}");
                    Frm_Logs.WriteSingleLog("");
                }));
            lbl.BackColor = SystemColors.Control;
            txt_input.KeyPress += txt_input_KeyPress;
        }

        private char CryptChar(char ToCrypt)
        {
            var crypted = ToCrypt;

            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Character to crypt: {crypted}"); }));

            if (Rotore1.RotateRotor(true))
                if (Rotore2.RotateRotor(true))
                    Rotore3.RotateRotor(true);
            lbl_r1.Invoke(new Action(() => { SetRotorsValue(); }));

            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Rotors rotated upwards"); }));

            var link = Links.Where(l => l.CompareTo(ToCrypt.ToString().ToLower()[0]) == 0).FirstOrDefault();
            if (link != null)
                crypted = link.Letter1.ToString().ToUpper()[0] == crypted ? link.Letter2.ToString().ToUpper()[0] : link.Letter1.ToString().ToUpper()[0];
            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Character after plugboard: {crypted}"); }));




            crypted = Rotore1.Crypt(crypted);
            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Character after first rotor: {crypted}"); }));

            crypted = Rotore2.Crypt(crypted);
            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Character after second rotor: {crypted}"); }));

            crypted = Rotore3.Crypt(crypted);
            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Character after third rotor: {crypted}"); }));

            crypted = Riflettore.Crypt(crypted);
            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Character after reflector: {crypted}"); }));

            crypted = Rotore3.ReverseCrypt(crypted);
            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Character after third rotor: {crypted}"); }));

            crypted = Rotore2.ReverseCrypt(crypted);
            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Character after second rotor: {crypted}"); }));

            crypted = Rotore1.ReverseCrypt(crypted);
            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Character after first rotor: {crypted}"); }));



            var link2 = Links.Where(l => l.CompareTo(crypted.ToString().ToLower()[0]) == 0).FirstOrDefault();
            if (link2 != null)
                crypted = link2.Letter1.ToString().ToUpper()[0] == crypted ? link2.Letter2.ToString().ToUpper()[0] : link2.Letter1.ToString().ToUpper()[0];
            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"Character after plugboard: {crypted}"); }));

            return crypted;
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
        #endregion

        #region Forms
        private void open_settings(object sender, EventArgs e)
        {
            if (Frm_settings == null)
            {
                Frm_settings = new Frm_settings();
                Frm_settings.Show();
            }

            btn_settings.Enabled = false;
        }

        public void ResetForm2()
        {
            Frm_settings = null;
            btn_settings.Enabled = true;
        }

        private void open_logs(object sender, EventArgs e)
        {
            if (Frm_Logs == null)
            {
                Frm_Logs = new Frm_logs();
                Frm_Logs.Show();
            }

            btn_logs.Enabled = false;
        }

        public void ResetForm3()
        {
            Frm_Logs = null;
            btn_logs.Enabled = true;
        }
        #endregion

        #region Other
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
            txt_output.Clear();
            txt_input.MaxLength = 1;

            txt_input.Focus();
            txt_input.SelectionStart = txt_input.Text.Length;
            txt_input.SelectionLength = 0;
        }

        private void btn_p_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse((sender as Control).Width * 0.1f, (sender as Control).Height * 0.1f, (sender as Control).Width * 0.8f, (sender as Control).Height * 0.8f);
            (sender as Control).Region = new System.Drawing.Region(grPath);

        }
        #endregion

        private async void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "txt files (*.txt))|*.txt";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() != DialogResult.OK)
                return;


            txt_input.KeyPress -= txt_input_KeyPress;
            txt_input.TextChanged -= txt_input_TextChanged;

            string filePath = ofd.FileName;
            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => { Frm_Logs.WriteSingleLog($"File {Path.GetFileName(filePath)} opened"); }));

            //Read the contents of the file into a stream
            var fileStream = ofd.OpenFile();

            string fileContent = "";

            using (StreamReader reader = new StreamReader(fileStream))
            {
                fileContent = reader.ReadToEnd();
            }

            //var t = new Task
            await Task.Run(() => encrypt_text(fileContent));


            txt_input.KeyPress += txt_input_KeyPress;
            txt_input.TextChanged += txt_input_TextChanged;
        }

        private void encrypt_text(string text)
        {
            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() => {
                    Frm_Logs.WriteSingleLog($"Starting encryption...");
                    Frm_Logs.WriteSingleLog($"");
                }));

            for (int i = 0; i < text.Length; i++)
            {
                char ToCrypt = text[i];

                if (char.IsLower(ToCrypt))
                    ToCrypt = ToCrypt.ToString().ToUpper()[0];
                var crypted = ToCrypt;

                if (ToCrypt < 65 || ToCrypt > 90)
                {
                    txt_input.Invoke(new Action(() =>
                    {
                        txt_output.Text += crypted;
                        txt_input.Text += ToCrypt;                       
                    }));
                    if (Frm_Logs != null)
                        Frm_Logs.Invoke(new Action(() => {
                        Frm_Logs.WriteSingleLog($"Character {ToCrypt} can't be encrypted");
                    }));
                    continue;
                }

                crypted = CryptChar(ToCrypt);
                txt_input.Invoke(new Action(() =>
                {
                    txt_output.Text += crypted;
                    txt_input.Text += ToCrypt;
                }));

                if (Frm_Logs != null)
                    Frm_Logs.Invoke(new Action(() =>
                    {
                        Frm_Logs.WriteSingleLog($"Character crypted: {crypted}");
                        Frm_Logs.WriteSingleLog("");
                    }));
            }


            if (Frm_Logs != null)
                Frm_Logs.Invoke(new Action(() =>
                {
                    Frm_Logs.WriteSingleLog($"Encryption ended");
                    Frm_Logs.WriteSingleLog("");
                }));
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "txt files (*.txt)|*.txt";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = sfd.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }
    }
}
