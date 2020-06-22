namespace Login
{
    partial class IMemberMainForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_date = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_menu4 = new System.Windows.Forms.Button();
            this.btn_menu3 = new System.Windows.Forms.Button();
            this.btn_menu2 = new System.Windows.Forms.Button();
            this.btn_menu1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iMenu41 = new Login.IMenu4();
            this.iMenu31 = new Login.IMenu3();
            this.iMenu21 = new Login.IMenu2();
            this.iMenu11 = new Login.IMenu1();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lb_date);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 917);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1353, 35);
            this.panel3.TabIndex = 10;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.ForeColor = System.Drawing.Color.White;
            this.lb_date.Location = new System.Drawing.Point(1067, 11);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(37, 15);
            this.lb_date.TabIndex = 0;
            this.lb_date.Text = "날짜";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_menu4);
            this.panel2.Controls.Add(this.btn_menu3);
            this.panel2.Controls.Add(this.btn_menu2);
            this.panel2.Controls.Add(this.btn_menu1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 793);
            this.panel2.TabIndex = 9;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 91);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lee";
            // 
            // btn_menu4
            // 
            this.btn_menu4.FlatAppearance.BorderSize = 0;
            this.btn_menu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.btn_menu3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.btn_menu2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            // btn_menu1
            // 
            this.btn_menu1.FlatAppearance.BorderSize = 0;
            this.btn_menu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 124);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1246, 15);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(93, 85);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "종료";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.iMenu41);
            this.panel4.Controls.Add(this.iMenu31);
            this.panel4.Controls.Add(this.iMenu21);
            this.panel4.Controls.Add(this.iMenu11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(216, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1137, 793);
            this.panel4.TabIndex = 11;
            // 
            // iMenu41
            // 
            this.iMenu41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iMenu41.Location = new System.Drawing.Point(0, 0);
            this.iMenu41.Name = "iMenu41";
            this.iMenu41.Size = new System.Drawing.Size(1137, 793);
            this.iMenu41.TabIndex = 3;
            // 
            // iMenu31
            // 
            this.iMenu31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iMenu31.Location = new System.Drawing.Point(0, 0);
            this.iMenu31.Name = "iMenu31";
            this.iMenu31.Size = new System.Drawing.Size(1137, 793);
            this.iMenu31.TabIndex = 2;
            // 
            // iMenu21
            // 
            this.iMenu21.BackColor = System.Drawing.Color.White;
            this.iMenu21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iMenu21.Location = new System.Drawing.Point(0, 0);
            this.iMenu21.Name = "iMenu21";
            this.iMenu21.Size = new System.Drawing.Size(1137, 793);
            this.iMenu21.TabIndex = 1;
            // 
            // iMenu11
            // 
            this.iMenu11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iMenu11.Location = new System.Drawing.Point(0, 0);
            this.iMenu11.Name = "iMenu11";
            this.iMenu11.Size = new System.Drawing.Size(1137, 793);
            this.iMenu11.TabIndex = 0;
            // 
            // IMemberMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 952);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IMemberMainForm";
            this.Text = "IndividualMemberMainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_menu4;
        private System.Windows.Forms.Button btn_menu3;
        private System.Windows.Forms.Button btn_menu2;
        private System.Windows.Forms.Button btn_menu1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Panel panel4;
        private IMenu4 iMenu41;
        private IMenu3 iMenu31;
        private IMenu2 iMenu21;
        private IMenu1 iMenu11;
    }
}