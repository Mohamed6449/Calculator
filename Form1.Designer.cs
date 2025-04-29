namespace Calculator3
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
            panel1 = new Panel();
            label2 = new Label();
            calculating = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            roundButton17 = new RoundButton();
            roundButton16 = new RoundButton();
            roundButton15 = new RoundButton();
            roundButton14 = new RoundButton();
            roundButton13 = new RoundButton();
            roundButton12 = new RoundButton();
            roundButton11 = new RoundButton();
            roundButton10 = new RoundButton();
            roundButton9 = new RoundButton();
            roundButton8 = new RoundButton();
            roundButton7 = new RoundButton();
            roundButton6 = new RoundButton();
            roundButton5 = new RoundButton();
            roundButton4 = new RoundButton();
            roundButton3 = new RoundButton();
            roundButton2 = new RoundButton();
            roundButton1 = new RoundButton();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(calculating);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 78);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(261, 8);
            label2.Name = "label2";
            label2.Size = new Size(318, 66);
            label2.TabIndex = 3;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // calculating
            // 
            calculating.AutoSize = true;
            calculating.ForeColor = Color.FromArgb(224, 224, 224);
            calculating.Location = new Point(3, 26);
            calculating.Name = "calculating";
            calculating.Size = new Size(141, 36);
            calculating.TabIndex = 2;
            calculating.Text = "Calculating";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 73);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(262, -3);
            label3.Name = "label3";
            label3.Size = new Size(318, 66);
            label3.TabIndex = 4;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 74);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(roundButton17);
            panel3.Controls.Add(roundButton16);
            panel3.Controls.Add(roundButton15);
            panel3.Controls.Add(roundButton14);
            panel3.Controls.Add(roundButton13);
            panel3.Controls.Add(roundButton12);
            panel3.Controls.Add(roundButton11);
            panel3.Controls.Add(roundButton10);
            panel3.Controls.Add(roundButton9);
            panel3.Controls.Add(roundButton8);
            panel3.Controls.Add(roundButton7);
            panel3.Controls.Add(roundButton6);
            panel3.Controls.Add(roundButton5);
            panel3.Controls.Add(roundButton4);
            panel3.Controls.Add(roundButton3);
            panel3.Controls.Add(roundButton2);
            panel3.Controls.Add(roundButton1);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 597);
            panel3.TabIndex = 2;
            // 
            // roundButton17
            // 
            roundButton17.BackColor = Color.Crimson;
            roundButton17.FlatAppearance.BorderSize = 0;
            roundButton17.FlatStyle = FlatStyle.Flat;
            roundButton17.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton17.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton17.Location = new Point(12, 411);
            roundButton17.Name = "roundButton17";
            roundButton17.Size = new Size(109, 83);
            roundButton17.TabIndex = 17;
            roundButton17.Tag = "";
            roundButton17.Text = "reset";
            roundButton17.UseVisualStyleBackColor = false;
            roundButton17.Click += roundButton17_Click;
            // 
            // roundButton16
            // 
            roundButton16.BackColor = Color.CadetBlue;
            roundButton16.FlatAppearance.BorderSize = 0;
            roundButton16.FlatStyle = FlatStyle.Flat;
            roundButton16.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton16.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton16.Location = new Point(4, 105);
            roundButton16.Name = "roundButton16";
            roundButton16.Size = new Size(70, 74);
            roundButton16.TabIndex = 16;
            roundButton16.Tag = "*";
            roundButton16.Text = "*";
            roundButton16.TextAlign = ContentAlignment.TopCenter;
            roundButton16.UseVisualStyleBackColor = false;
            roundButton16.Click += Btn_sign;
            // 
            // roundButton15
            // 
            roundButton15.BackColor = Color.CadetBlue;
            roundButton15.FlatAppearance.BorderSize = 0;
            roundButton15.FlatStyle = FlatStyle.Flat;
            roundButton15.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton15.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton15.Location = new Point(51, 3);
            roundButton15.Name = "roundButton15";
            roundButton15.Size = new Size(70, 74);
            roundButton15.TabIndex = 15;
            roundButton15.Tag = "/";
            roundButton15.Text = "/";
            roundButton15.TextAlign = ContentAlignment.TopCenter;
            roundButton15.UseVisualStyleBackColor = false;
            roundButton15.Click += Btn_sign;
            // 
            // roundButton14
            // 
            roundButton14.BackColor = Color.CadetBlue;
            roundButton14.FlatAppearance.BorderSize = 0;
            roundButton14.FlatStyle = FlatStyle.Flat;
            roundButton14.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton14.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton14.Location = new Point(444, 6);
            roundButton14.Name = "roundButton14";
            roundButton14.Size = new Size(70, 74);
            roundButton14.TabIndex = 14;
            roundButton14.Tag = "-";
            roundButton14.Text = "-";
            roundButton14.TextAlign = ContentAlignment.TopCenter;
            roundButton14.UseVisualStyleBackColor = false;
            roundButton14.Click += Btn_sign;
            // 
            // roundButton13
            // 
            roundButton13.BackColor = Color.CadetBlue;
            roundButton13.FlatAppearance.BorderSize = 0;
            roundButton13.FlatStyle = FlatStyle.Flat;
            roundButton13.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton13.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton13.Location = new Point(507, 80);
            roundButton13.Name = "roundButton13";
            roundButton13.Size = new Size(70, 74);
            roundButton13.TabIndex = 13;
            roundButton13.Tag = "+";
            roundButton13.Text = "+";
            roundButton13.TextAlign = ContentAlignment.TopCenter;
            roundButton13.UseVisualStyleBackColor = false;
            roundButton13.Click += Btn_sign;
            // 
            // roundButton12
            // 
            roundButton12.BackColor = Color.SlateBlue;
            roundButton12.FlatAppearance.BorderSize = 0;
            roundButton12.FlatStyle = FlatStyle.Flat;
            roundButton12.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton12.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton12.Location = new Point(239, 378);
            roundButton12.Name = "roundButton12";
            roundButton12.Size = new Size(70, 74);
            roundButton12.TabIndex = 12;
            roundButton12.Tag = "7";
            roundButton12.Text = "7";
            roundButton12.TextAlign = ContentAlignment.TopCenter;
            roundButton12.UseVisualStyleBackColor = false;
            roundButton12.Click += btn_Click;
            // 
            // roundButton11
            // 
            roundButton11.BackColor = Color.SlateBlue;
            roundButton11.FlatAppearance.BorderSize = 0;
            roundButton11.FlatStyle = FlatStyle.Flat;
            roundButton11.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton11.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton11.Location = new Point(316, 38);
            roundButton11.Name = "roundButton11";
            roundButton11.Size = new Size(70, 74);
            roundButton11.TabIndex = 11;
            roundButton11.Tag = "1";
            roundButton11.Text = "1";
            roundButton11.TextAlign = ContentAlignment.TopCenter;
            roundButton11.UseVisualStyleBackColor = false;
            roundButton11.Click += btn_Click;
            // 
            // roundButton10
            // 
            roundButton10.BackColor = Color.SlateBlue;
            roundButton10.FlatAppearance.BorderSize = 0;
            roundButton10.FlatStyle = FlatStyle.Flat;
            roundButton10.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton10.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton10.Location = new Point(208, 38);
            roundButton10.Name = "roundButton10";
            roundButton10.Size = new Size(70, 74);
            roundButton10.TabIndex = 10;
            roundButton10.Tag = "2";
            roundButton10.Text = "2";
            roundButton10.TextAlign = ContentAlignment.TopCenter;
            roundButton10.UseVisualStyleBackColor = false;
            roundButton10.Click += btn_Click;
            // 
            // roundButton9
            // 
            roundButton9.BackColor = Color.SlateBlue;
            roundButton9.FlatAppearance.BorderSize = 0;
            roundButton9.FlatStyle = FlatStyle.Flat;
            roundButton9.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton9.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton9.Location = new Point(116, 81);
            roundButton9.Name = "roundButton9";
            roundButton9.Size = new Size(70, 74);
            roundButton9.TabIndex = 9;
            roundButton9.Tag = "3";
            roundButton9.Text = "3";
            roundButton9.TextAlign = ContentAlignment.TopCenter;
            roundButton9.UseVisualStyleBackColor = false;
            roundButton9.Click += btn_Click;
            // 
            // roundButton8
            // 
            roundButton8.BackColor = Color.SlateBlue;
            roundButton8.FlatAppearance.BorderSize = 0;
            roundButton8.FlatStyle = FlatStyle.Flat;
            roundButton8.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton8.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton8.Location = new Point(444, 192);
            roundButton8.Name = "roundButton8";
            roundButton8.Size = new Size(70, 74);
            roundButton8.TabIndex = 8;
            roundButton8.Tag = ".";
            roundButton8.Text = ".";
            roundButton8.TextAlign = ContentAlignment.TopCenter;
            roundButton8.UseVisualStyleBackColor = false;
            roundButton8.Click += btn_Click;
            // 
            // roundButton7
            // 
            roundButton7.BackColor = Color.SlateBlue;
            roundButton7.FlatAppearance.BorderSize = 0;
            roundButton7.FlatStyle = FlatStyle.Flat;
            roundButton7.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton7.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton7.Location = new Point(422, 290);
            roundButton7.Name = "roundButton7";
            roundButton7.Size = new Size(70, 74);
            roundButton7.TabIndex = 7;
            roundButton7.Tag = "9";
            roundButton7.Text = "9";
            roundButton7.TextAlign = ContentAlignment.TopCenter;
            roundButton7.UseVisualStyleBackColor = false;
            roundButton7.Click += btn_Click;
            // 
            // roundButton6
            // 
            roundButton6.BackColor = Color.SlateBlue;
            roundButton6.FlatAppearance.BorderSize = 0;
            roundButton6.FlatStyle = FlatStyle.Flat;
            roundButton6.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton6.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton6.Location = new Point(346, 361);
            roundButton6.Name = "roundButton6";
            roundButton6.Size = new Size(70, 74);
            roundButton6.TabIndex = 6;
            roundButton6.Tag = "8";
            roundButton6.Text = "8";
            roundButton6.TextAlign = ContentAlignment.TopCenter;
            roundButton6.UseVisualStyleBackColor = false;
            roundButton6.Click += btn_Click;
            // 
            // roundButton5
            // 
            roundButton5.BackColor = Color.SlateBlue;
            roundButton5.FlatAppearance.BorderSize = 0;
            roundButton5.FlatStyle = FlatStyle.Flat;
            roundButton5.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton5.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton5.Location = new Point(148, 342);
            roundButton5.Name = "roundButton5";
            roundButton5.Size = new Size(70, 74);
            roundButton5.TabIndex = 5;
            roundButton5.Tag = "6";
            roundButton5.Text = "6";
            roundButton5.TextAlign = ContentAlignment.TopCenter;
            roundButton5.UseVisualStyleBackColor = false;
            roundButton5.Click += btn_Click;
            // 
            // roundButton4
            // 
            roundButton4.BackColor = Color.SlateBlue;
            roundButton4.FlatAppearance.BorderSize = 0;
            roundButton4.FlatStyle = FlatStyle.Flat;
            roundButton4.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton4.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton4.Location = new Point(88, 262);
            roundButton4.Name = "roundButton4";
            roundButton4.Size = new Size(70, 74);
            roundButton4.TabIndex = 4;
            roundButton4.Tag = "5";
            roundButton4.Text = "5";
            roundButton4.TextAlign = ContentAlignment.TopCenter;
            roundButton4.UseVisualStyleBackColor = false;
            roundButton4.Click += btn_Click;
            // 
            // roundButton3
            // 
            roundButton3.BackColor = Color.SlateBlue;
            roundButton3.FlatAppearance.BorderSize = 0;
            roundButton3.FlatStyle = FlatStyle.Flat;
            roundButton3.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton3.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton3.Location = new Point(88, 172);
            roundButton3.Name = "roundButton3";
            roundButton3.Size = new Size(70, 74);
            roundButton3.TabIndex = 3;
            roundButton3.Tag = "4";
            roundButton3.Text = "4";
            roundButton3.TextAlign = ContentAlignment.TopCenter;
            roundButton3.UseVisualStyleBackColor = false;
            roundButton3.Click += btn_Click;
            // 
            // roundButton2
            // 
            roundButton2.BackColor = Color.SlateBlue;
            roundButton2.FlatAppearance.BorderSize = 0;
            roundButton2.FlatStyle = FlatStyle.Flat;
            roundButton2.Font = new Font("Segoe UI", 25.7910442F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton2.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton2.Location = new Point(404, 90);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(70, 74);
            roundButton2.TabIndex = 2;
            roundButton2.Tag = "0";
            roundButton2.Text = "0";
            roundButton2.TextAlign = ContentAlignment.TopCenter;
            roundButton2.UseVisualStyleBackColor = false;
            roundButton2.Click += btn_Click;
            // 
            // roundButton1
            // 
            roundButton1.BackColor = Color.DarkSlateBlue;
            roundButton1.FlatAppearance.BorderSize = 0;
            roundButton1.FlatStyle = FlatStyle.Flat;
            roundButton1.Font = new Font("Segoe UI", 70F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundButton1.ForeColor = Color.FromArgb(224, 224, 224);
            roundButton1.Location = new Point(208, 137);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(190, 209);
            roundButton1.TabIndex = 1;
            roundButton1.Text = "c";
            roundButton1.TextAlign = ContentAlignment.TopCenter;
            roundButton1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 509);
            button1.Name = "button1";
            button1.Size = new Size(580, 88);
            button1.TabIndex = 0;
            button1.Tag = "=";
            button1.Text = "=";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 748);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 13.970149F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private RoundButton roundButton1;
        private Label calculating;
        private Label label2;
        private Label label3;
        private Label label1;
        private RoundButton roundButton2;
        private RoundButton roundButton12;
        private RoundButton roundButton11;
        private RoundButton roundButton10;
        private RoundButton roundButton9;
        private RoundButton roundButton8;
        private RoundButton roundButton7;
        private RoundButton roundButton6;
        private RoundButton roundButton5;
        private RoundButton roundButton4;
        private RoundButton roundButton3;
        private RoundButton roundButton16;
        private RoundButton roundButton15;
        private RoundButton roundButton14;
        private RoundButton roundButton13;
        private RoundButton roundButton17;
    }
}
