namespace Enigma
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.pan_space_1 = new System.Windows.Forms.Panel();
            this.pan_rotori = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_rc2 = new System.Windows.Forms.Button();
            this.lbl_riflettore = new System.Windows.Forms.Label();
            this.btn_rc1 = new System.Windows.Forms.Button();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_p = new System.Windows.Forms.Label();
            this.lbl_o = new System.Windows.Forms.Label();
            this.lbl_i = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_t = new System.Windows.Forms.Label();
            this.lbl_r = new System.Windows.Forms.Label();
            this.lbl_e = new System.Windows.Forms.Label();
            this.lbl_w = new System.Windows.Forms.Label();
            this.lbl_q = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_s = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.pan_rotori.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pan_r1.SuspendLayout();
            this.pan_r2.SuspendLayout();
            this.pan_r3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(800, 45);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "ENIGMA";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_space_1
            // 
            this.pan_space_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_space_1.Location = new System.Drawing.Point(0, 45);
            this.pan_space_1.Name = "pan_space_1";
            this.pan_space_1.Size = new System.Drawing.Size(800, 45);
            this.pan_space_1.TabIndex = 1;
            // 
            // pan_rotori
            // 
            this.pan_rotori.Controls.Add(this.panel1);
            this.pan_rotori.Controls.Add(this.pan_r1);
            this.pan_rotori.Controls.Add(this.pan_r2);
            this.pan_rotori.Controls.Add(this.pan_r3);
            this.pan_rotori.Controls.Add(this.label4);
            this.pan_rotori.Controls.Add(this.label3);
            this.pan_rotori.Controls.Add(this.label1);
            this.pan_rotori.Controls.Add(this.label2);
            this.pan_rotori.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_rotori.Location = new System.Drawing.Point(0, 90);
            this.pan_rotori.Name = "pan_rotori";
            this.pan_rotori.Size = new System.Drawing.Size(800, 160);
            this.pan_rotori.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_rc2);
            this.panel1.Controls.Add(this.lbl_riflettore);
            this.panel1.Controls.Add(this.btn_rc1);
            this.panel1.Location = new System.Drawing.Point(87, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 120);
            this.panel1.TabIndex = 10;
            // 
            // btn_rc2
            // 
            this.btn_rc2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rc2.Location = new System.Drawing.Point(0, 90);
            this.btn_rc2.Name = "btn_rc2";
            this.btn_rc2.Size = new System.Drawing.Size(78, 30);
            this.btn_rc2.TabIndex = 7;
            this.btn_rc2.Text = "\\/";
            this.btn_rc2.UseVisualStyleBackColor = true;
            this.btn_rc2.Click += new System.EventHandler(this.ChangeReflector);
            // 
            // lbl_riflettore
            // 
            this.lbl_riflettore.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_riflettore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_riflettore.Location = new System.Drawing.Point(0, 30);
            this.lbl_riflettore.Name = "lbl_riflettore";
            this.lbl_riflettore.Size = new System.Drawing.Size(78, 60);
            this.lbl_riflettore.TabIndex = 6;
            this.lbl_riflettore.Text = "UKW";
            this.lbl_riflettore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_rc1
            // 
            this.btn_rc1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rc1.Location = new System.Drawing.Point(0, 0);
            this.btn_rc1.Name = "btn_rc1";
            this.btn_rc1.Size = new System.Drawing.Size(78, 30);
            this.btn_rc1.TabIndex = 1;
            this.btn_rc1.Text = "/\\";
            this.btn_rc1.UseVisualStyleBackColor = true;
            this.btn_rc1.Click += new System.EventHandler(this.ChangeReflector);
            // 
            // pan_r1
            // 
            this.pan_r1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_r1.Controls.Add(this.btn_r1d);
            this.pan_r1.Controls.Add(this.lbl_r1);
            this.pan_r1.Controls.Add(this.btn_r1u);
            this.pan_r1.Location = new System.Drawing.Point(633, 40);
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
            this.btn_r1d.Click += new System.EventHandler(this.Ruota);
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
            this.btn_r1u.Click += new System.EventHandler(this.Ruota);
            // 
            // pan_r2
            // 
            this.pan_r2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_r2.Controls.Add(this.btn_r2d);
            this.pan_r2.Controls.Add(this.lbl_r2);
            this.pan_r2.Controls.Add(this.btn_r2u);
            this.pan_r2.Location = new System.Drawing.Point(451, 40);
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
            this.btn_r2d.Click += new System.EventHandler(this.Ruota);
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
            this.btn_r2u.Click += new System.EventHandler(this.Ruota);
            // 
            // pan_r3
            // 
            this.pan_r3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_r3.Controls.Add(this.btn_r3d);
            this.pan_r3.Controls.Add(this.lbl_r3);
            this.pan_r3.Controls.Add(this.btn_r3u);
            this.pan_r3.Location = new System.Drawing.Point(269, 40);
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
            this.btn_r3d.Click += new System.EventHandler(this.Ruota);
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
            this.btn_r3u.Click += new System.EventHandler(this.Ruota);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(618, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rotore I";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(436, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rotore II";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(254, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rotore III";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(72, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Riflettore";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 45);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lbl_s);
            this.panel3.Controls.Add(this.lbl_a);
            this.panel3.Controls.Add(this.lbl_p);
            this.panel3.Controls.Add(this.lbl_o);
            this.panel3.Controls.Add(this.lbl_i);
            this.panel3.Controls.Add(this.lbl_y);
            this.panel3.Controls.Add(this.lbl_t);
            this.panel3.Controls.Add(this.lbl_r);
            this.panel3.Controls.Add(this.lbl_e);
            this.panel3.Controls.Add(this.lbl_w);
            this.panel3.Controls.Add(this.lbl_q);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 170);
            this.panel3.TabIndex = 4;
            // 
            // lbl_p
            // 
            this.lbl_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_p.Location = new System.Drawing.Point(610, 0);
            this.lbl_p.Name = "lbl_p";
            this.lbl_p.Size = new System.Drawing.Size(60, 60);
            this.lbl_p.TabIndex = 15;
            this.lbl_p.Text = "P";
            this.lbl_p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_o
            // 
            this.lbl_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_o.Location = new System.Drawing.Point(550, 0);
            this.lbl_o.Name = "lbl_o";
            this.lbl_o.Size = new System.Drawing.Size(60, 60);
            this.lbl_o.TabIndex = 14;
            this.lbl_o.Text = "O";
            this.lbl_o.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_i
            // 
            this.lbl_i.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_i.Location = new System.Drawing.Point(490, 0);
            this.lbl_i.Name = "lbl_i";
            this.lbl_i.Size = new System.Drawing.Size(60, 60);
            this.lbl_i.TabIndex = 13;
            this.lbl_i.Text = "I";
            this.lbl_i.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_y
            // 
            this.lbl_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_y.Location = new System.Drawing.Point(430, 0);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(60, 60);
            this.lbl_y.TabIndex = 12;
            this.lbl_y.Text = "Y";
            this.lbl_y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_t
            // 
            this.lbl_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_t.Location = new System.Drawing.Point(370, 0);
            this.lbl_t.Name = "lbl_t";
            this.lbl_t.Size = new System.Drawing.Size(60, 60);
            this.lbl_t.TabIndex = 11;
            this.lbl_t.Text = "T";
            this.lbl_t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_r
            // 
            this.lbl_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_r.Location = new System.Drawing.Point(310, 0);
            this.lbl_r.Name = "lbl_r";
            this.lbl_r.Size = new System.Drawing.Size(60, 60);
            this.lbl_r.TabIndex = 10;
            this.lbl_r.Text = "R";
            this.lbl_r.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_e
            // 
            this.lbl_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_e.Location = new System.Drawing.Point(250, 0);
            this.lbl_e.Name = "lbl_e";
            this.lbl_e.Size = new System.Drawing.Size(60, 60);
            this.lbl_e.TabIndex = 9;
            this.lbl_e.Text = "E";
            this.lbl_e.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_w
            // 
            this.lbl_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_w.Location = new System.Drawing.Point(190, 0);
            this.lbl_w.Name = "lbl_w";
            this.lbl_w.Size = new System.Drawing.Size(60, 60);
            this.lbl_w.TabIndex = 8;
            this.lbl_w.Text = "W";
            this.lbl_w.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_q
            // 
            this.lbl_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_q.Location = new System.Drawing.Point(130, 0);
            this.lbl_q.Name = "lbl_q";
            this.lbl_q.Size = new System.Drawing.Size(60, 60);
            this.lbl_q.TabIndex = 7;
            this.lbl_q.Text = "Q";
            this.lbl_q.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label5.Location = new System.Drawing.Point(570, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 60);
            this.label5.TabIndex = 23;
            this.label5.Text = "O";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label6.Location = new System.Drawing.Point(510, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 60);
            this.label6.TabIndex = 22;
            this.label6.Text = "I";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label7.Location = new System.Drawing.Point(450, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 60);
            this.label7.TabIndex = 21;
            this.label7.Text = "Y";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label8.Location = new System.Drawing.Point(390, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 60);
            this.label8.TabIndex = 20;
            this.label8.Text = "T";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label9.Location = new System.Drawing.Point(330, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 60);
            this.label9.TabIndex = 19;
            this.label9.Text = "R";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label10.Location = new System.Drawing.Point(270, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 60);
            this.label10.TabIndex = 18;
            this.label10.Text = "E";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_s
            // 
            this.lbl_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_s.Location = new System.Drawing.Point(210, 60);
            this.lbl_s.Name = "lbl_s";
            this.lbl_s.Size = new System.Drawing.Size(60, 60);
            this.lbl_s.TabIndex = 17;
            this.lbl_s.Text = "W";
            this.lbl_s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_a
            // 
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lbl_a.Location = new System.Drawing.Point(150, 60);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(60, 60);
            this.lbl_a.TabIndex = 16;
            this.lbl_a.Text = "A";
            this.lbl_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pan_rotori);
            this.Controls.Add(this.pan_space_1);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pan_rotori.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pan_r1.ResumeLayout(false);
            this.pan_r2.ResumeLayout(false);
            this.pan_r3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pan_space_1;
        private System.Windows.Forms.Panel pan_rotori;
        private System.Windows.Forms.Panel pan_r3;
        private System.Windows.Forms.Button btn_r3d;
        private System.Windows.Forms.Label lbl_r3;
        private System.Windows.Forms.Button btn_r3u;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pan_r1;
        private System.Windows.Forms.Button btn_r1d;
        private System.Windows.Forms.Label lbl_r1;
        private System.Windows.Forms.Button btn_r1u;
        private System.Windows.Forms.Panel pan_r2;
        private System.Windows.Forms.Button btn_r2d;
        private System.Windows.Forms.Label lbl_r2;
        private System.Windows.Forms.Button btn_r2u;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_rc2;
        private System.Windows.Forms.Label lbl_riflettore;
        private System.Windows.Forms.Button btn_rc1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_p;
        private System.Windows.Forms.Label lbl_o;
        private System.Windows.Forms.Label lbl_i;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_t;
        private System.Windows.Forms.Label lbl_r;
        private System.Windows.Forms.Label lbl_e;
        private System.Windows.Forms.Label lbl_w;
        private System.Windows.Forms.Label lbl_q;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_s;
        private System.Windows.Forms.Label lbl_a;
    }
}

