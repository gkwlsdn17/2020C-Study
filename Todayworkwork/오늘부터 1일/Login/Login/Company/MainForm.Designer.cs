﻿namespace Login
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_menu4 = new System.Windows.Forms.Button();
            this.btn_menu3 = new System.Windows.Forms.Button();
            this.btn_menu2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_menu1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menu41 = new Login.Menu4();
            this.menu31 = new Login.Menu3();
            this.menu21 = new Login.Menu2();
            this.menu11 = new Login.Menu1();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.menu41);
            this.panel4.Controls.Add(this.menu31);
            this.panel4.Controls.Add(this.menu21);
            this.panel4.Controls.Add(this.menu11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(216, 124);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1137, 793);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lb_date);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(216, 917);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1137, 35);
            this.panel3.TabIndex = 6;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("HY강M", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_date.ForeColor = System.Drawing.Color.White;
            this.lb_date.Location = new System.Drawing.Point(851, 7);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(47, 19);
            this.lb_date.TabIndex = 0;
            this.lb_date.Text = "날짜";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1071, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY강M", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1167, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lee";
            // 
            // btn_menu4
            // 
            this.btn_menu4.FlatAppearance.BorderSize = 0;
            this.btn_menu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu4.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_menu4.ForeColor = System.Drawing.Color.White;
            this.btn_menu4.Location = new System.Drawing.Point(3, 596);
            this.btn_menu4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_menu4.Name = "btn_menu4";
            this.btn_menu4.Size = new System.Drawing.Size(213, 111);
            this.btn_menu4.TabIndex = 2;
            this.btn_menu4.Text = "채용관리";
            this.btn_menu4.UseVisualStyleBackColor = true;
            this.btn_menu4.Click += new System.EventHandler(this.btn_menu4_Click);
            // 
            // btn_menu3
            // 
            this.btn_menu3.FlatAppearance.BorderSize = 0;
            this.btn_menu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu3.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_menu3.ForeColor = System.Drawing.Color.White;
            this.btn_menu3.Location = new System.Drawing.Point(3, 456);
            this.btn_menu3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_menu3.Name = "btn_menu3";
            this.btn_menu3.Size = new System.Drawing.Size(213, 111);
            this.btn_menu3.TabIndex = 2;
            this.btn_menu3.Text = "인재정보";
            this.btn_menu3.UseVisualStyleBackColor = true;
            this.btn_menu3.Click += new System.EventHandler(this.btn_menu3_Click);
            // 
            // btn_menu2
            // 
            this.btn_menu2.FlatAppearance.BorderSize = 0;
            this.btn_menu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu2.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_menu2.ForeColor = System.Drawing.Color.White;
            this.btn_menu2.Location = new System.Drawing.Point(3, 314);
            this.btn_menu2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_menu2.Name = "btn_menu2";
            this.btn_menu2.Size = new System.Drawing.Size(213, 111);
            this.btn_menu2.TabIndex = 2;
            this.btn_menu2.Text = "구인목록";
            this.btn_menu2.UseVisualStyleBackColor = true;
            this.btn_menu2.Click += new System.EventHandler(this.btn_menu2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 124);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.btn_menu4);
            this.panel2.Controls.Add(this.btn_menu3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_menu2);
            this.panel2.Controls.Add(this.btn_menu1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 828);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_menu1
            // 
            this.btn_menu1.FlatAppearance.BorderSize = 0;
            this.btn_menu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu1.Font = new System.Drawing.Font("HY강M", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_menu1.ForeColor = System.Drawing.Color.White;
            this.btn_menu1.Location = new System.Drawing.Point(3, 176);
            this.btn_menu1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_menu1.Name = "btn_menu1";
            this.btn_menu1.Size = new System.Drawing.Size(213, 111);
            this.btn_menu1.TabIndex = 2;
            this.btn_menu1.Text = "구인관";
            this.btn_menu1.UseVisualStyleBackColor = true;
            this.btn_menu1.Click += new System.EventHandler(this.btn_menu1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(1251, 31);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(76, 61);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // menu41
            // 
            this.menu41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu41.Location = new System.Drawing.Point(0, 0);
            this.menu41.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.menu41.Name = "menu41";
            this.menu41.Size = new System.Drawing.Size(1137, 793);
            this.menu41.TabIndex = 3;
            this.menu41.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.menu41.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.menu41.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // menu31
            // 
            this.menu31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu31.Location = new System.Drawing.Point(0, 0);
            this.menu31.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.menu31.Name = "menu31";
            this.menu31.Size = new System.Drawing.Size(1137, 793);
            this.menu31.TabIndex = 2;
            this.menu31.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.menu31.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.menu31.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // menu21
            // 
            this.menu21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu21.Location = new System.Drawing.Point(0, 0);
            this.menu21.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.menu21.Name = "menu21";
            this.menu21.Size = new System.Drawing.Size(1137, 793);
            this.menu21.TabIndex = 1;
            this.menu21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.menu21.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.menu21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // menu11
            // 
            this.menu11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu11.Location = new System.Drawing.Point(0, 0);
            this.menu11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.menu11.Name = "menu11";
            this.menu11.Size = new System.Drawing.Size(1137, 793);
            this.menu11.TabIndex = 0;
            this.menu11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.menu11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.menu11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 952);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_menu4;
        private System.Windows.Forms.Button btn_menu3;
        private System.Windows.Forms.Button btn_menu2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_menu1;
        private Menu4 menu41;
        private Menu3 menu31;
        private Menu2 menu21;
        private Menu1 menu11;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}