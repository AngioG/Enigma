﻿using System;
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
    public partial class Frm_settings : Form
    {
        public Frm_settings()
        {
            InitializeComponent();
        }

        private void btn_res_rot_Click(object sender, EventArgs e)
        {
            Program.Enigma.Rotore1.Giri = 0;
            Program.Enigma.Rotore1.Lettera = 'A';

            Program.Enigma.Rotore2.Giri = 0;
            Program.Enigma.Rotore2.Lettera = 'A';

            Program.Enigma.Rotore3.Giri = 0;
            Program.Enigma.Rotore3.Lettera = 'A';

            Program.Enigma.SetRotorsValue();
        }

        private void ChangeRingSettings(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Rotor rtr = new Rotor(1);
            Label lbl = new Label();


            if (btn.Name.Contains("1"))
            {
                rtr = Program.Enigma.Rotore1;
                lbl = lbl_r1;
            }
            if (btn.Name.Contains("2"))
            {
                rtr = Program.Enigma.Rotore2;
                lbl = lbl_r2;
            }
            if (btn.Name.Contains("3"))
            {
                rtr = Program.Enigma.Rotore3;
                lbl = lbl_r3;
            }


            if (btn.Name.Contains("u"))
            { 
                rtr.RotateRing(true);
                lbl.Text = ((char)((lbl.Text[0] - 65) % 26 + 66)).ToString();
            }

            if (btn.Name.Contains("d"))
            {
                int letter = (int)((lbl.Text[0] - 66));
                if (letter < 0)
                    letter = 25;
                rtr.RotateRing(false);
                lbl.Text = ((char)(letter + 65)).ToString();
            }
        }

        private void btn_res_rings_Click(object sender, EventArgs e)
        {
            Program.Enigma.Rotore1.RingPos = 0;
            Program.Enigma.Rotore2.RingPos = 0;
            Program.Enigma.Rotore3.RingPos = 0;

            lbl_r1.Text = "A";
            lbl_r2.Text = "A";
            lbl_r3.Text = "A";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Enigma.ResetForm2();
        }

        private void btn_res_log_Click(object sender, EventArgs e)
        {
            if (Program.Enigma.Frm_Logs == null)
                return;

            Program.Enigma.Frm_Logs.Invoke(new Action (() => { Program.Enigma.Frm_Logs.DeleteLogs(); }));
        }

        private void Frm_settings_Load(object sender, EventArgs e)
        {
            cmb_r1.SelectedIndex = Program.Enigma.Rotore1.Tipo - 1;
            cmb_r2.SelectedIndex = Program.Enigma.Rotore2.Tipo - 1;
            cmb_r3.SelectedIndex = Program.Enigma.Rotore3.Tipo - 1;

            cmb_r1.SelectedIndexChanged += new EventHandler(change_rotor);
            cmb_r2.SelectedIndexChanged += new EventHandler(change_rotor);
            cmb_r3.SelectedIndexChanged += new EventHandler(change_rotor);
        }

        private void change_rotor(object sender, EventArgs e)
        {
            if (sender.GetType() != typeof(ComboBox))
                return;

            var cmb = sender as ComboBox;

            switch(cmb.Name.Substring(cmb.Name.Length-1))
            {
                case "1":
                    {
                        Program.Enigma.Rotore1 = new Rotor(cmb.SelectedIndex + 1);
                        break;
                    }
                case "2":
                    {
                        Program.Enigma.Rotore2 = new Rotor(cmb.SelectedIndex + 1);
                        break;
                    }
                case "3":
                    {
                        Program.Enigma.Rotore3 = new Rotor(cmb.SelectedIndex + 1);
                        break;
                    }
                default:
                    {
                        return;
                    }
            }

            Program.Enigma.SetRotorsValue();
        }
    }
}
