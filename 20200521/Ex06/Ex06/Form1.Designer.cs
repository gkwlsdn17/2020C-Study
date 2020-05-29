namespace Ex06
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.power_button = new System.Windows.Forms.Button();
            this.multi_button = new System.Windows.Forms.Button();
            this.s_result = new System.Windows.Forms.Label();
            this.m_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 2;
            // 
            // power_button
            // 
            this.power_button.Location = new System.Drawing.Point(171, 35);
            this.power_button.Name = "power_button";
            this.power_button.Size = new System.Drawing.Size(75, 23);
            this.power_button.TabIndex = 3;
            this.power_button.Text = "제곱";
            this.power_button.UseVisualStyleBackColor = true;
            this.power_button.Click += new System.EventHandler(this.power_button_Click);
            // 
            // multi_button
            // 
            this.multi_button.Location = new System.Drawing.Point(171, 99);
            this.multi_button.Name = "multi_button";
            this.multi_button.Size = new System.Drawing.Size(75, 23);
            this.multi_button.TabIndex = 4;
            this.multi_button.Text = "곱하기";
            this.multi_button.UseVisualStyleBackColor = true;
            this.multi_button.Click += new System.EventHandler(this.multi_button_Click);
            // 
            // s_result
            // 
            this.s_result.AutoSize = true;
            this.s_result.Location = new System.Drawing.Point(288, 40);
            this.s_result.Name = "s_result";
            this.s_result.Size = new System.Drawing.Size(38, 12);
            this.s_result.TabIndex = 5;
            this.s_result.Text = "label1";
            // 
            // m_result
            // 
            this.m_result.AutoSize = true;
            this.m_result.Location = new System.Drawing.Point(288, 104);
            this.m_result.Name = "m_result";
            this.m_result.Size = new System.Drawing.Size(38, 12);
            this.m_result.TabIndex = 6;
            this.m_result.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 290);
            this.Controls.Add(this.m_result);
            this.Controls.Add(this.s_result);
            this.Controls.Add(this.multi_button);
            this.Controls.Add(this.power_button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button power_button;
        private System.Windows.Forms.Button multi_button;
        private System.Windows.Forms.Label s_result;
        private System.Windows.Forms.Label m_result;
    }
}

