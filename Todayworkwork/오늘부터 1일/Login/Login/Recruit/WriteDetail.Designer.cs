namespace Login.Recruit
{
    partial class WriteDetail
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
            this.btn_뒤로가기 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_subject = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_뒤로가기
            // 
            this.btn_뒤로가기.Location = new System.Drawing.Point(981, 31);
            this.btn_뒤로가기.Name = "btn_뒤로가기";
            this.btn_뒤로가기.Size = new System.Drawing.Size(100, 76);
            this.btn_뒤로가기.TabIndex = 0;
            this.btn_뒤로가기.Text = "뒤로가기";
            this.btn_뒤로가기.UseVisualStyleBackColor = true;
            this.btn_뒤로가기.Click += new System.EventHandler(this.btn_뒤로가기_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_subject);
            this.panel1.Location = new System.Drawing.Point(44, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 76);
            this.panel1.TabIndex = 1;
            // 
            // lb_subject
            // 
            this.lb_subject.AutoSize = true;
            this.lb_subject.Location = new System.Drawing.Point(56, 31);
            this.lb_subject.Name = "lb_subject";
            this.lb_subject.Size = new System.Drawing.Size(54, 15);
            this.lb_subject.TabIndex = 0;
            this.lb_subject.Text = "subject";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(44, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 227);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(44, 383);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1035, 332);
            this.panel3.TabIndex = 3;
            // 
            // WriteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 747);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_뒤로가기);
            this.Name = "WriteDetail";
            this.Text = "글정보";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.WriteDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_뒤로가기;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_subject;
    }
}