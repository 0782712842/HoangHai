﻿using System.Windows.Forms;

namespace ChikenFIGHT
{
    partial class Form1
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
            this.Winpanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quaaman = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Winpanel.SuspendLayout();
            this.quaaman.SuspendLayout();
            this.SuspendLayout();
            // 
            // Winpanel
            // 
            this.Winpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Winpanel.Controls.Add(this.label4);
            this.Winpanel.Controls.Add(this.label2);
            this.Winpanel.Controls.Add(this.label1);
            this.Winpanel.Controls.Add(this.label3);
            this.Winpanel.Location = new System.Drawing.Point(201, 98);
            this.Winpanel.Name = "Winpanel";
            this.Winpanel.Size = new System.Drawing.Size(361, 258);
            this.Winpanel.TabIndex = 0;
            this.Winpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(71, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 55);
            this.label4.TabIndex = 3;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(64, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 55);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 256);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // quaaman
            // 
            this.quaaman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quaaman.Controls.Add(this.label8);
            this.quaaman.Controls.Add(this.label5);
            this.quaaman.Controls.Add(this.label6);
            this.quaaman.Controls.Add(this.label7);
            this.quaaman.Location = new System.Drawing.Point(201, 98);
            this.quaaman.Name = "quaaman";
            this.quaaman.Size = new System.Drawing.Size(357, 242);
            this.quaaman.TabIndex = 1;
            this.quaaman.Paint += new System.Windows.Forms.PaintEventHandler(this.quaaman_Paint);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(71, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 55);
            this.label5.TabIndex = 3;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(72, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 55);
            this.label6.TabIndex = 1;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 55);
            this.label7.TabIndex = 0;
            this.label7.Text = "Score";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(-14, -13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(407, 319);
            this.label8.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.quaaman);
            this.Controls.Add(this.Winpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Winpanel.ResumeLayout(false);
            this.quaaman.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Winpanel;
        private Label label1;
        private Label label2;
        private Label label4;
        private Panel quaaman;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label8;
    }
}
