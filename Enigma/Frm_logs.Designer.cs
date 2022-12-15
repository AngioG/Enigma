namespace Enigma
{
    partial class Frm_logs
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.list_logs = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(515, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(25, 655);
            this.panel5.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 655);
            this.panel1.TabIndex = 32;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(50, 645);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(530, 50);
            this.panel7.TabIndex = 33;
            // 
            // list_logs
            // 
            this.list_logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_logs.FormattingEnabled = true;
            this.list_logs.Location = new System.Drawing.Point(25, 75);
            this.list_logs.Name = "list_logs";
            this.list_logs.Size = new System.Drawing.Size(490, 580);
            this.list_logs.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(25, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 25);
            this.panel3.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.label2.Location = new System.Drawing.Point(25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 50);
            this.label2.TabIndex = 35;
            this.label2.Text = "LOGS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(25, 630);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 25);
            this.panel2.TabIndex = 37;
            // 
            // Frm_logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.list_logs);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_logs";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListBox list_logs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}