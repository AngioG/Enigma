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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pan_r3 = new System.Windows.Forms.Panel();
            this.btn_r3u = new System.Windows.Forms.Button();
            this.lbl_r3 = new System.Windows.Forms.Label();
            this.btn_r3d = new System.Windows.Forms.Button();
            this.pan_r2 = new System.Windows.Forms.Panel();
            this.btn_r2d = new System.Windows.Forms.Button();
            this.lbl_r2 = new System.Windows.Forms.Label();
            this.btn_r2u = new System.Windows.Forms.Button();
            this.pan_r1 = new System.Windows.Forms.Panel();
            this.btn_r1d = new System.Windows.Forms.Button();
            this.lbl_r1 = new System.Windows.Forms.Label();
            this.btn_r1u = new System.Windows.Forms.Button();
            this.pan_rotori.SuspendLayout();
            this.pan_r3.SuspendLayout();
            this.pan_r2.SuspendLayout();
            this.pan_r1.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pan_rotori);
            this.Controls.Add(this.pan_space_1);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pan_rotori.ResumeLayout(false);
            this.pan_r3.ResumeLayout(false);
            this.pan_r2.ResumeLayout(false);
            this.pan_r1.ResumeLayout(false);
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
    }
}

