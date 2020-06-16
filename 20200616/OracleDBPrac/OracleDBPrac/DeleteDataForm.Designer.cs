namespace OracleDBPrac
{
    partial class DeleteDataForm
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
            this.bt_create = new System.Windows.Forms.Button();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.lb_addr = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.lb_age = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_searchName = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(234, 179);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(105, 44);
            this.bt_cancel.TabIndex = 6;
            this.bt_cancel.Text = "취소";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.btn_cancel);
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(123, 179);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(105, 44);
            this.bt_create.TabIndex = 5;
            this.bt_create.Text = "삭제";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.btn_deleteData);
            // 
            // tb_addr
            // 
            this.tb_addr.Location = new System.Drawing.Point(136, 131);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(256, 21);
            this.tb_addr.TabIndex = 4;
            // 
            // lb_addr
            // 
            this.lb_addr.AutoSize = true;
            this.lb_addr.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_addr.Location = new System.Drawing.Point(52, 131);
            this.lb_addr.Name = "lb_addr";
            this.lb_addr.Size = new System.Drawing.Size(49, 20);
            this.lb_addr.TabIndex = 6;
            this.lb_addr.Text = "주소";
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(136, 97);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(256, 21);
            this.tb_age.TabIndex = 3;
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_age.Location = new System.Drawing.Point(52, 97);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(49, 20);
            this.lb_age.TabIndex = 7;
            this.lb_age.Text = "나이";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(136, 65);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(256, 21);
            this.tb_name.TabIndex = 2;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("굴림", 15F);
            this.lb_name.Location = new System.Drawing.Point(52, 65);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(49, 20);
            this.lb_name.TabIndex = 8;
            this.lb_name.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "삭제할이름";
            // 
            // tb_searchName
            // 
            this.tb_searchName.Location = new System.Drawing.Point(167, 23);
            this.tb_searchName.Name = "tb_searchName";
            this.tb_searchName.Size = new System.Drawing.Size(141, 21);
            this.tb_searchName.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(314, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_searchName);
            // 
            // DeleteDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 248);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_searchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.lb_addr);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.lb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Name = "DeleteDataForm";
            this.Text = "oracle 데이터 삭제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Label lb_addr;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_searchName;
        private System.Windows.Forms.Button btn_search;
    }
}