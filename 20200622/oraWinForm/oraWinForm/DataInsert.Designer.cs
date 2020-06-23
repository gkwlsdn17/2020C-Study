namespace oraWinForm
{
    partial class DataInsert
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_age = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_addr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onSendData);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_name
            // 
            this.tb_name.Depth = 0;
            this.tb_name.Hint = "";
            this.tb_name.Location = new System.Drawing.Point(106, 55);
            this.tb_name.MaxLength = 32767;
            this.tb_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.SelectedText = "";
            this.tb_name.SelectionLength = 0;
            this.tb_name.SelectionStart = 0;
            this.tb_name.Size = new System.Drawing.Size(175, 23);
            this.tb_name.TabIndex = 3;
            this.tb_name.TabStop = false;
            this.tb_name.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(45, 55);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "이름";
            // 
            // tb_age
            // 
            this.tb_age.Depth = 0;
            this.tb_age.Hint = "";
            this.tb_age.Location = new System.Drawing.Point(106, 93);
            this.tb_age.MaxLength = 32767;
            this.tb_age.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_age.Name = "tb_age";
            this.tb_age.PasswordChar = '\0';
            this.tb_age.SelectedText = "";
            this.tb_age.SelectionLength = 0;
            this.tb_age.SelectionStart = 0;
            this.tb_age.Size = new System.Drawing.Size(175, 23);
            this.tb_age.TabIndex = 3;
            this.tb_age.TabStop = false;
            this.tb_age.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(45, 93);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "나이";
            // 
            // tb_addr
            // 
            this.tb_addr.Depth = 0;
            this.tb_addr.Hint = "";
            this.tb_addr.Location = new System.Drawing.Point(106, 135);
            this.tb_addr.MaxLength = 32767;
            this.tb_addr.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.PasswordChar = '\0';
            this.tb_addr.SelectedText = "";
            this.tb_addr.SelectionLength = 0;
            this.tb_addr.SelectionStart = 0;
            this.tb_addr.Size = new System.Drawing.Size(175, 23);
            this.tb_addr.TabIndex = 3;
            this.tb_addr.TabStop = false;
            this.tb_addr.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(45, 135);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(39, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "주소";
            // 
            // DataInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 304);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DataInsert";
            this.Text = "데이터삽입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_age;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_addr;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}