namespace Login
{
    partial class IMenu2
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_seq_letter = new System.Windows.Forms.Button();
            this.btn_seq_point = new System.Windows.Forms.Button();
            this.btn_seq_apply = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_all = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 106);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(921, 480);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_seq_letter
            // 
            this.btn_seq_letter.Location = new System.Drawing.Point(93, 11);
            this.btn_seq_letter.Name = "btn_seq_letter";
            this.btn_seq_letter.Size = new System.Drawing.Size(81, 25);
            this.btn_seq_letter.TabIndex = 1;
            this.btn_seq_letter.Text = "가나다순";
            this.btn_seq_letter.UseVisualStyleBackColor = true;
            this.btn_seq_letter.Click += new System.EventHandler(this.btn_seq_letter_Click);
            // 
            // btn_seq_point
            // 
            this.btn_seq_point.Location = new System.Drawing.Point(177, 11);
            this.btn_seq_point.Name = "btn_seq_point";
            this.btn_seq_point.Size = new System.Drawing.Size(81, 25);
            this.btn_seq_point.TabIndex = 1;
            this.btn_seq_point.Text = "평점순";
            this.btn_seq_point.UseVisualStyleBackColor = true;
            this.btn_seq_point.Click += new System.EventHandler(this.btn_seq_point_Click);
            // 
            // btn_seq_apply
            // 
            this.btn_seq_apply.Location = new System.Drawing.Point(260, 11);
            this.btn_seq_apply.Name = "btn_seq_apply";
            this.btn_seq_apply.Size = new System.Drawing.Size(81, 25);
            this.btn_seq_apply.TabIndex = 1;
            this.btn_seq_apply.Text = "지원자순";
            this.btn_seq_apply.UseVisualStyleBackColor = true;
            this.btn_seq_apply.Click += new System.EventHandler(this.btn_seq_apply_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Location = new System.Drawing.Point(40, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 46);
            this.panel1.TabIndex = 2;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(68, 11);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(383, 21);
            this.tb_search.TabIndex = 1;
            this.tb_search.Text = "검색 할 기업을 입력하세요";
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(13, 9);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(48, 27);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_all);
            this.panel2.Controls.Add(this.btn_seq_letter);
            this.panel2.Controls.Add(this.btn_seq_point);
            this.panel2.Controls.Add(this.btn_seq_apply);
            this.panel2.Location = new System.Drawing.Point(599, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 46);
            this.panel2.TabIndex = 3;
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(6, 11);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(81, 25);
            this.btn_all.TabIndex = 1;
            this.btn_all.Text = "전체글";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // IMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IMenu2";
            this.Size = new System.Drawing.Size(995, 634);
            this.Load += new System.EventHandler(this.IMenu2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_seq_letter;
        private System.Windows.Forms.Button btn_seq_point;
        private System.Windows.Forms.Button btn_seq_apply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_all;
    }
}
