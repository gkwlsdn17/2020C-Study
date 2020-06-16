namespace OracleDBPrac
{
    partial class UpdateDataForm
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
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.tb_afterAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_afterAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_afterName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_searchName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_beforeAddr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_beforeAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_beforeName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(268, 267);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(105, 44);
            this.bt_cancel.TabIndex = 6;
            this.bt_cancel.Text = "취소";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.btn_cancel);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(157, 267);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(105, 44);
            this.bt_update.TabIndex = 5;
            this.bt_update.Text = "변경";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.btn_updateData);
            // 
            // tb_afterAddr
            // 
            this.tb_afterAddr.Location = new System.Drawing.Point(338, 209);
            this.tb_afterAddr.Name = "tb_afterAddr";
            this.tb_afterAddr.Size = new System.Drawing.Size(159, 21);
            this.tb_afterAddr.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(283, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "주소";
            // 
            // tb_afterAge
            // 
            this.tb_afterAge.Location = new System.Drawing.Point(338, 163);
            this.tb_afterAge.Name = "tb_afterAge";
            this.tb_afterAge.Size = new System.Drawing.Size(159, 21);
            this.tb_afterAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(283, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "나이";
            // 
            // tb_afterName
            // 
            this.tb_afterName.Location = new System.Drawing.Point(338, 118);
            this.tb_afterName.Name = "tb_afterName";
            this.tb_afterName.Size = new System.Drawing.Size(159, 21);
            this.tb_afterName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(283, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F);
            this.label4.Location = new System.Drawing.Point(25, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "변경 할 데이터의 이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15F);
            this.label5.Location = new System.Drawing.Point(371, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "변경후";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(397, 29);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(77, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_searchData);
            // 
            // tb_searchName
            // 
            this.tb_searchName.Location = new System.Drawing.Point(241, 29);
            this.tb_searchName.Name = "tb_searchName";
            this.tb_searchName.Size = new System.Drawing.Size(141, 21);
            this.tb_searchName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15F);
            this.label6.Location = new System.Drawing.Point(136, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "변경전";
            // 
            // tb_beforeAddr
            // 
            this.tb_beforeAddr.Location = new System.Drawing.Point(103, 208);
            this.tb_beforeAddr.Name = "tb_beforeAddr";
            this.tb_beforeAddr.Size = new System.Drawing.Size(159, 21);
            this.tb_beforeAddr.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 15F);
            this.label7.Location = new System.Drawing.Point(48, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "주소";
            // 
            // tb_beforeAge
            // 
            this.tb_beforeAge.Location = new System.Drawing.Point(103, 162);
            this.tb_beforeAge.Name = "tb_beforeAge";
            this.tb_beforeAge.Size = new System.Drawing.Size(159, 21);
            this.tb_beforeAge.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 15F);
            this.label8.Location = new System.Drawing.Point(48, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "나이";
            // 
            // tb_beforeName
            // 
            this.tb_beforeName.Location = new System.Drawing.Point(103, 117);
            this.tb_beforeName.Name = "tb_beforeName";
            this.tb_beforeName.Size = new System.Drawing.Size(159, 21);
            this.tb_beforeName.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 15F);
            this.label9.Location = new System.Drawing.Point(48, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "이름";
            // 
            // UpdateDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 338);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_beforeAddr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_beforeAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_beforeName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_searchName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_afterAddr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_afterAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_afterName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_update);
            this.Name = "UpdateDataForm";
            this.Text = "UpdateDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.TextBox tb_afterAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_afterAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_afterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_searchName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_beforeAddr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_beforeAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_beforeName;
        private System.Windows.Forms.Label label9;
    }
}