namespace Calculator
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
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(30, 71);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(46, 32);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(82, 71);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(46, 32);
            this.button_8.TabIndex = 0;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(134, 71);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(46, 32);
            this.button_9.TabIndex = 0;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(30, 109);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(46, 32);
            this.button_4.TabIndex = 0;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(82, 109);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(46, 32);
            this.button_5.TabIndex = 0;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(134, 109);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(46, 32);
            this.button_6.TabIndex = 0;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(30, 147);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(46, 32);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(82, 147);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(46, 32);
            this.button_2.TabIndex = 0;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(134, 147);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(46, 32);
            this.button_3.TabIndex = 0;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(30, 185);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(98, 32);
            this.button_0.TabIndex = 0;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(134, 185);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 32);
            this.button11.TabIndex = 0;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(186, 185);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(46, 32);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_sub
            // 
            this.button_sub.Location = new System.Drawing.Point(186, 147);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(46, 32);
            this.button_sub.TabIndex = 0;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_mul
            // 
            this.button_mul.Location = new System.Drawing.Point(186, 109);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(46, 32);
            this.button_mul.TabIndex = 0;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(186, 71);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(46, 32);
            this.button_div.TabIndex = 0;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.onBtnClick);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(30, 27);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(254, 38);
            this.textBox_result.TabIndex = 1;
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(238, 71);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(46, 32);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "←";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(238, 109);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(46, 32);
            this.button_clear.TabIndex = 0;
            this.button_clear.Text = "AC";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.onBtnClick);
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(238, 147);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(46, 70);
            this.button_result.TabIndex = 0;
            this.button_result.Text = "=";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.onBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 239);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "간단한 계산기 v1.0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_result;
    }
}

