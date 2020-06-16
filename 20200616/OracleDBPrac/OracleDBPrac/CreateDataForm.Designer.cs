namespace OracleDBPrac
{
    partial class CreateDataForm
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
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_age = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.lb_addr = new System.Windows.Forms.Label();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.bt_create = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_name.Location = new System.Drawing.Point(48, 48);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(49, 20);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "이름";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(132, 48);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(256, 21);
            this.tb_name.TabIndex = 1;
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_age.Location = new System.Drawing.Point(48, 93);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(49, 20);
            this.lb_age.TabIndex = 0;
            this.lb_age.Text = "나이";
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(132, 93);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(256, 21);
            this.tb_age.TabIndex = 2;
            // 
            // lb_addr
            // 
            this.lb_addr.AutoSize = true;
            this.lb_addr.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_addr.Location = new System.Drawing.Point(48, 139);
            this.lb_addr.Name = "lb_addr";
            this.lb_addr.Size = new System.Drawing.Size(49, 20);
            this.lb_addr.TabIndex = 0;
            this.lb_addr.Text = "주소";
            // 
            // tb_addr
            // 
            this.tb_addr.Location = new System.Drawing.Point(132, 139);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(256, 21);
            this.tb_addr.TabIndex = 3;
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(119, 187);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(105, 44);
            this.bt_create.TabIndex = 4;
            this.bt_create.Text = "생성";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.btn_createData);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(230, 187);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(105, 44);
            this.bt_cancel.TabIndex = 5;
            this.bt_cancel.Text = "취소";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // CreateDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 256);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.lb_addr);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.lb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Name = "CreateDataForm";
            this.Text = "Oracle 데이터 관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label lb_addr;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Button bt_cancel;
    }
}