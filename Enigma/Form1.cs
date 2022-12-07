using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{


    public partial class Form1 : Form
    {
        public Rotore Rotore1 { get; set; }
        public Rotore Rotore2 { get; set; }
        public Rotore Rotore3 { get; set; }
        public Riflettore Riflettore { get; set; }


        public Form1()
        {
            Rotore1 = new Rotore(1);
            Rotore2 = new Rotore(2);
            Rotore3 = new Rotore(3);
            Riflettore = new Riflettore(4);

            InitializeComponent();
        }

        private void Ruota(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Rotore rtr = new Rotore(1);

            if (btn.Name.Contains("1"))
            rtr = Rotore1;
            if (btn.Name.Contains("2"))
                rtr = Rotore2;
            if (btn.Name.Contains("3"))
                rtr = Rotore3;


            if (btn.Name.Contains("u"))
            {
                if (rtr.Gira(true))
                {
                    if (btn.Name.Contains("1"))
                        Rotore2.Gira(true);
                    else if (btn.Name.Contains("2"))
                        Rotore3.Gira(true);
                }
            }

            if (btn.Name.Contains("d"))
                if (rtr.Gira(false))
                {
                    if (btn.Name.Contains("1"))
                        Rotore2.Gira(false);
                    else if (btn.Name.Contains("2"))
                        Rotore3.Gira(false);
                }

            lbl_r1.Text = Rotore1.ToString();
            lbl_r2.Text = Rotore2.ToString();
            lbl_r3.Text = Rotore3.ToString();
        }
    }
}
