namespace Ex01
{
    partial class BasicCalc
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.input2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.result2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input4 = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.input3 = new System.Windows.Forms.TextBox();
            this.result3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input6 = new System.Windows.Forms.TextBox();
            this.btnMul = new System.Windows.Forms.Button();
            this.input5 = new System.Windows.Forms.TextBox();
            this.result4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input8 = new System.Windows.Forms.TextBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.input7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("바탕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOK.Location = new System.Drawing.Point(170, 290);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 46);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.onExit);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("바탕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInfo.Location = new System.Drawing.Point(283, 290);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(132, 46);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "프로그램 정보";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.onHelp);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(19, 92);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 21);
            this.input1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onAdd);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(179, 93);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 21);
            this.input2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(319, 92);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 21);
            this.result.TabIndex = 6;
            // 
            // result2
            // 
            this.result2.Location = new System.Drawing.Point(319, 129);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(100, 21);
            this.result2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(295, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "=";
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(179, 130);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(100, 21);
            this.input4.TabIndex = 9;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(123, 128);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(51, 23);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.onSub);
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(19, 129);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(100, 21);
            this.input3.TabIndex = 7;
            // 
            // result3
            // 
            this.result3.Location = new System.Drawing.Point(319, 167);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(100, 21);
            this.result3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(295, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "=";
            // 
            // input6
            // 
            this.input6.Location = new System.Drawing.Point(179, 168);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(100, 21);
            this.input6.TabIndex = 14;
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(123, 166);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(51, 23);
            this.btnMul.TabIndex = 13;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.onMul);
            // 
            // input5
            // 
            this.input5.Location = new System.Drawing.Point(19, 167);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(100, 21);
            this.input5.TabIndex = 12;
            // 
            // result4
            // 
            this.result4.Location = new System.Drawing.Point(319, 204);
            this.result4.Name = "result4";
            this.result4.Size = new System.Drawing.Size(100, 21);
            this.result4.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(295, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "=";
            // 
            // input8
            // 
            this.input8.Location = new System.Drawing.Point(179, 205);
            this.input8.Name = "input8";
            this.input8.Size = new System.Drawing.Size(100, 21);
            this.input8.TabIndex = 19;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(123, 203);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(51, 23);
            this.btnDiv.TabIndex = 18;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.onDiv);
            // 
            // input7
            // 
            this.input7.Location = new System.Drawing.Point(19, 204);
            this.input7.Name = "input7";
            this.input7.Size = new System.Drawing.Size(100, 21);
            this.input7.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("바탕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(61, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onClear);
            // 
            // BasicCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(429, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input8);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.input7);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input6);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnOK);
            this.Name = "BasicCalc";
            this.Text = "기본 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox result2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input4;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox result3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input6;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.TextBox input5;
        private System.Windows.Forms.TextBox result4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input8;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox input7;
        private System.Windows.Forms.Button button1;
    }
}

