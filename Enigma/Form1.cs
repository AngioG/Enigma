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
            Label lbl = new Label();

            if (btn.Name.Contains("1"))
            {
                rtr = Rotore1;
                lbl = lbl_r1;
            }
            if (btn.Name.Contains("2"))
            {
                rtr = Rotore2;
                lbl = lbl_r2;
            }
            if (btn.Name.Contains("3"))
            {
                rtr = Rotore3;
                lbl = lbl_r3;
            }


            if (btn.Name.Contains("u"))
                rtr.Gira(true);
            if (btn.Name.Contains("d"))
                rtr.Gira(false);

            lbl.Text = rtr.ToString();
        }
    }
}
