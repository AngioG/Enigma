namespace Enigma
{
    partial class Frm_settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pan_rotori = new System.Windows.Forms.Panel();
            this.pan_r1 = new System.Windows.Forms.Panel();
            this.btn_r1d = new System.Windows.Forms.Button();
            this.lbl_r1 = new System.Windows.Forms.Label();
            this.btn_r1u = new System.Windows.Forms.Button();
            this.pan_r2 = new System.Windows.Forms.Panel();
            this.btn_r2d = new System.Windows.Forms.Button();
            this.lbl_r2 = new System.Windows.Forms.Label();
            this.btn_r2u = new System.Windows.Forms.Button();
            this.pan_r3 = new System.Windows.Forms.Panel();
            this.btn_r3d = new System.Windows.Forms.Button();
            this.lbl_r3 = new System.Windows.Forms.Label();
            this.btn_r3u = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btn_dd = new System.Windows.Forms.Button();
            this.lbl_delay = new System.Windows.Forms.Label();
            this.btn_du = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_res_log = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_res_rot = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_res_rings = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pan_rotori.SuspendLayout();
            this.pan_r1.SuspendLayout();
            this.pan_r2.SuspendLayout();
            this.pan_r3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_rotori
            // 
            this.pan_rotori.Controls.Add(this.pan_r1);
            this.pan_rotori.Controls.Add(this.pan_r2);
            this.pan_rotori.Controls.Add(this.pan_r3);
            this.pan_rotori.Controls.Add(this.label4);
            this.pan_rotori.Controls.Add(this.label3);
            this.pan_rotori.Controls.Add(this.label1);
            this.pan_rotori.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_rotori.Location = new System.Drawing.Point(0, 0);
            this.pan_rotori.Name = "pan_rotori";
            this.pan_rotori.Size = new System.Drawing.Size(530, 160);
            this.pan_rotori.TabIndex = 8;
            // 
            // pan_r1
            // 
            this.pan_r1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_r1.Controls.Add(this.btn_r1d);
            this.pan_r1.Controls.Add(this.lbl_r1);
            this.pan_r1.Controls.Add(this.btn_r1u);
            this.pan_r1.Location = new System.Drawing.Point(382, 40);
            this.pan_r1.Name = "pan_r1";
            this.pan_r1.Size = new System.Drawing.Size(80, 120);
            this.pan_r1.TabIndex = 9;
            // 
            // btn_r1d
            // 
            this.btn_r1d.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_r1d.Location = new System.Drawing.Point(0, 90);
            this.btn_r1d.Name = "btn_r1d";
            this.btn_r1d.Size = new System.Drawing.Size(78, 30);
            this.btn_r1d.TabIndex = 7;
            this.btn_r1d.Text = "\\/";
            this.btn_r1d.UseVisualStyleBackColor = true;
            this.btn_r1d.Click += new System.EventHandler(this.ChangeRingSettings);
            // 
            // lbl_r1
            // 
            this.lbl_r1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_r1.Location = new System.Drawing.Point(0, 30);
            this.lbl_r1.Name = "lbl_r1";
            this.lbl_r1.Size = new System.Drawing.Size(78, 60);
            this.lbl_r1.TabIndex = 6;
            this.lbl_r1.Text = "A";
            this.lbl_r1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_r1u
            // 
            this.btn_r1u.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_r1u.Location = new System.Drawing.Point(0, 0);
            this.btn_r1u.Name = "btn_r1u";
            this.btn_r1u.Size = new System.Drawing.Size(78, 30);
            this.btn_r1u.TabIndex = 1;
            this.btn_r1u.Text = "/\\";
            this.btn_r1u.UseVisualStyleBackColor = true;
            this.btn_r1u.Click += new System.EventHandler(this.ChangeRingSettings);
            // 
            // pan_r2
            // 
            this.pan_r2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_r2.Controls.Add(this.btn_r2d);
            this.pan_r2.Controls.Add(this.lbl_r2);
            this.pan_r2.Controls.Add(this.btn_r2u);
            this.pan_r2.Location = new System.Drawing.Point(200, 40);
            this.pan_r2.Name = "pan_r2";
            this.pan_r2.Size = new System.Drawing.Size(80, 120);
            this.pan_r2.TabIndex = 8;
            // 
            // btn_r2d
            // 
            this.btn_r2d.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_r2d.Location = new System.Drawing.Point(0, 90);
            this.btn_r2d.Name = "btn_r2d";
            this.btn_r2d.Size = new System.Drawing.Size(78, 30);
            this.btn_r2d.TabIndex = 7;
            this.btn_r2d.Text = "\\/";
            this.btn_r2d.UseVisualStyleBackColor = true;
            this.btn_r2d.Click += new System.EventHandler(this.ChangeRingSettings);
            // 
            // lbl_r2
            // 
            this.lbl_r2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_r2.Location = new System.Drawing.Point(0, 30);
            this.lbl_r2.Name = "lbl_r2";
            this.lbl_r2.Size = new System.Drawing.Size(78, 60);
            this.lbl_r2.TabIndex = 6;
            this.lbl_r2.Text = "A";
            this.lbl_r2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_r2u
            // 
            this.btn_r2u.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_r2u.Location = new System.Drawing.Point(0, 0);
            this.btn_r2u.Name = "btn_r2u";
            this.btn_r2u.Size = new System.Drawing.Size(78, 30);
            this.btn_r2u.TabIndex = 1;
            this.btn_r2u.Text = "/\\";
            this.btn_r2u.UseVisualStyleBackColor = true;
            this.btn_r2u.Click += new System.EventHandler(this.ChangeRingSettings);
            // 
            // pan_r3
            // 
            this.pan_r3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_r3.Controls.Add(this.btn_r3d);
            this.pan_r3.Controls.Add(this.lbl_r3);
            this.pan_r3.Controls.Add(this.btn_r3u);
            this.pan_r3.Location = new System.Drawing.Point(18, 40);
            this.pan_r3.Name = "pan_r3";
            this.pan_r3.Size = new System.Drawing.Size(80, 120);
            this.pan_r3.TabIndex = 7;
            // 
            // btn_r3d
            // 
            this.btn_r3d.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_r3d.Location = new System.Drawing.Point(0, 90);
            this.btn_r3d.Name = "btn_r3d";
            this.btn_r3d.Size = new System.Drawing.Size(78, 30);
            this.btn_r3d.TabIndex = 7;
            this.btn_r3d.Text = "\\/";
            this.btn_r3d.UseVisualStyleBackColor = true;
            this.btn_r3d.Click += new System.EventHandler(this.ChangeRingSettings);
            // 
            // lbl_r3
            // 
            this.lbl_r3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_r3.Location = new System.Drawing.Point(0, 30);
            this.lbl_r3.Name = "lbl_r3";
            this.lbl_r3.Size = new System.Drawing.Size(78, 60);
            this.lbl_r3.TabIndex = 6;
            this.lbl_r3.Text = "A";
            this.lbl_r3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_r3u
            // 
            this.btn_r3u.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_r3u.Location = new System.Drawing.Point(0, 0);
            this.btn_r3u.Name = "btn_r3u";
            this.btn_r3u.Size = new System.Drawing.Size(78, 30);
            this.btn_r3u.TabIndex = 1;
            this.btn_r3u.Text = "/\\";
            this.btn_r3u.UseVisualStyleBackColor = true;
            this.btn_r3u.Click += new System.EventHandler(this.ChangeRingSettings);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(367, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ring I";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(185, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ring II";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ring III";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 50);
            this.label2.TabIndex = 26;
            this.label2.Text = "ADVANCE SETINGS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 664);
            this.panel1.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(50, 645);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(530, 50);
            this.panel7.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(50, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 50);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.pan_rotori);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(50, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 614);
            this.panel4.TabIndex = 30;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.btn_res_log);
            this.panel11.Controls.Add(this.panel9);
            this.panel11.Controls.Add(this.btn_res_rot);
            this.panel11.Controls.Add(this.panel10);
            this.panel11.Controls.Add(this.btn_res_rings);
            this.panel11.Controls.Add(this.panel8);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 160);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(480, 454);
            this.panel11.TabIndex = 30;
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.btn_dd);
            this.panel15.Controls.Add(this.lbl_delay);
            this.panel15.Controls.Add(this.btn_du);
            this.panel15.Location = new System.Drawing.Point(130, 283);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(80, 120);
            this.panel15.TabIndex = 46;
            // 
            // btn_dd
            // 
            this.btn_dd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dd.Location = new System.Drawing.Point(0, 90);
            this.btn_dd.Name = "btn_dd";
            this.btn_dd.Size = new System.Drawing.Size(78, 30);
            this.btn_dd.TabIndex = 7;
            this.btn_dd.Text = "\\/";
            this.btn_dd.UseVisualStyleBackColor = true;
            this.btn_dd.Click += new System.EventHandler(this.btn_dd_Click);
            // 
            // lbl_delay
            // 
            this.lbl_delay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_delay.Location = new System.Drawing.Point(0, 30);
            this.lbl_delay.Name = "lbl_delay";
            this.lbl_delay.Size = new System.Drawing.Size(78, 60);
            this.lbl_delay.TabIndex = 6;
            this.lbl_delay.Text = "750";
            this.lbl_delay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_du
            // 
            this.btn_du.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_du.Location = new System.Drawing.Point(0, 0);
            this.btn_du.Name = "btn_du";
            this.btn_du.Size = new System.Drawing.Size(78, 30);
            this.btn_du.TabIndex = 1;
            this.btn_du.Text = "/\\";
            this.btn_du.UseVisualStyleBackColor = true;
            this.btn_du.Click += new System.EventHandler(this.btn_du_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(3, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 58);
            this.label7.TabIndex = 45;
            this.label7.Text = "Operation Delay:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 404);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(480, 50);
            this.panel13.TabIndex = 44;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 240);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(480, 40);
            this.panel12.TabIndex = 43;
            // 
            // btn_res_log
            // 
            this.btn_res_log.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_res_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_res_log.Location = new System.Drawing.Point(0, 200);
            this.btn_res_log.Name = "btn_res_log";
            this.btn_res_log.Size = new System.Drawing.Size(480, 40);
            this.btn_res_log.TabIndex = 42;
            this.btn_res_log.Text = "Reset Logs";
            this.btn_res_log.UseVisualStyleBackColor = true;
            this.btn_res_log.Click += new System.EventHandler(this.btn_res_log_Click);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 160);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(480, 40);
            this.panel9.TabIndex = 41;
            // 
            // btn_res_rot
            // 
            this.btn_res_rot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_res_rot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_res_rot.Location = new System.Drawing.Point(0, 120);
            this.btn_res_rot.Name = "btn_res_rot";
            this.btn_res_rot.Size = new System.Drawing.Size(480, 40);
            this.btn_res_rot.TabIndex = 40;
            this.btn_res_rot.Text = "Reset Rotors";
            this.btn_res_rot.UseVisualStyleBackColor = true;
            this.btn_res_rot.Click += new System.EventHandler(this.btn_res_rot_Click);
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 80);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(480, 40);
            this.panel10.TabIndex = 39;
            // 
            // btn_res_rings
            // 
            this.btn_res_rings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_res_rings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_res_rings.Location = new System.Drawing.Point(0, 40);
            this.btn_res_rings.Name = "btn_res_rings";
            this.btn_res_rings.Size = new System.Drawing.Size(480, 40);
            this.btn_res_rings.TabIndex = 38;
            this.btn_res_rings.Text = "Reset Rings";
            this.btn_res_rings.UseVisualStyleBackColor = true;
            this.btn_res_rings.Click += new System.EventHandler(this.btn_res_rings_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(480, 40);
            this.panel8.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(480, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 454);
            this.panel2.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(239, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 121);
            this.label5.TabIndex = 47;
            this.label5.Text = "Software representing Enigma machine from 1939 realised by ITIS Paleocapa class 5" +
    "IC using windows forms and the programming language C#";
            // 
            // Frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 714);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Frm_settings";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.pan_rotori.ResumeLayout(false);
            this.pan_r1.ResumeLayout(false);
            this.pan_r2.ResumeLayout(false);
            this.pan_r3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_rotori;
        private System.Windows.Forms.Panel pan_r1;
        private System.Windows.Forms.Button btn_r1d;
        private System.Windows.Forms.Label lbl_r1;
        private System.Windows.Forms.Button btn_r1u;
        private System.Windows.Forms.Panel pan_r2;
        private System.Windows.Forms.Button btn_r2d;
        private System.Windows.Forms.Label lbl_r2;
        private System.Windows.Forms.Button btn_r2u;
        private System.Windows.Forms.Panel pan_r3;
        private System.Windows.Forms.Button btn_r3d;
        private System.Windows.Forms.Label lbl_r3;
        private System.Windows.Forms.Button btn_r3u;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btn_dd;
        private System.Windows.Forms.Label lbl_delay;
        private System.Windows.Forms.Button btn_du;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btn_res_log;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_res_rot;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_res_rings;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}