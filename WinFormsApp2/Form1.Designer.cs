﻿namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(8, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "+\\-";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(100, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(192, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = ",";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equal.Location = new System.Drawing.Point(284, 520);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(94, 63);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(284, 459);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(94, 63);
            this.plus.TabIndex = 7;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(192, 459);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 63);
            this.button6.TabIndex = 6;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Window;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(100, 459);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 63);
            this.button7.TabIndex = 5;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Window;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(8, 459);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 63);
            this.button8.TabIndex = 4;
            this.button8.Text = "1";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.numbers_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(284, 398);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(94, 63);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Window;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(192, 398);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 63);
            this.button10.TabIndex = 10;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Window;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(100, 398);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 63);
            this.button11.TabIndex = 9;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Window;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(8, 398);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 63);
            this.button12.TabIndex = 8;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.numbers_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mult.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mult.Location = new System.Drawing.Point(284, 337);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(94, 63);
            this.mult.TabIndex = 15;
            this.mult.Text = "x";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.Window;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(192, 337);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(94, 63);
            this.button14.TabIndex = 14;
            this.button14.Text = "9";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.Window;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(100, 337);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(94, 63);
            this.button15.TabIndex = 13;
            this.button15.Text = "8";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.Window;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(8, 337);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(94, 63);
            this.button16.TabIndex = 12;
            this.button16.Text = "7";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.numbers_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.div.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.div.Location = new System.Drawing.Point(284, 277);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(94, 63);
            this.div.TabIndex = 16;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(191, 277);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 63);
            this.clear.TabIndex = 17;
            this.clear.Text = "c";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button19.Location = new System.Drawing.Point(8, 277);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(94, 63);
            this.button19.TabIndex = 18;
            this.button19.Text = "x";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button20.Location = new System.Drawing.Point(100, 277);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(94, 63);
            this.button20.TabIndex = 19;
            this.button20.Text = "x";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(153, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 143);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 132);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(500, 682);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button equal;
        private Button plus;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button minus;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button mult;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button div;
        private Button clear;
        private Button button19;
        private Button button20;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}