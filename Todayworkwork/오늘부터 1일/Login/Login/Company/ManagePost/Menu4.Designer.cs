namespace Login
{
    partial class Menu4
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_w_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w_subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w_content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_w_count_people = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label_login_id = new System.Windows.Forms.Label();
            this.btn_show_detail = new System.Windows.Forms.Button();
            this.btn_delete_post = new System.Windows.Forms.Button();
            this.btn_edit_detail = new System.Windows.Forms.Button();
            this.label_login_com = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_applicant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "내가 작성한 채용 공고";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_w_num,
            this.col_w_ID,
            this.col_w_subject,
            this.col_w_content,
            this.col_w_date,
            this.col_w_count,
            this.col_w_count_people});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 173);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(938, 432);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // col_w_num
            // 
            this.col_w_num.Text = "글 번호";
            this.col_w_num.Width = 70;
            // 
            // col_w_ID
            // 
            this.col_w_ID.Text = "ID";
            this.col_w_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_w_ID.Width = 120;
            // 
            // col_w_subject
            // 
            this.col_w_subject.Text = "제목";
            this.col_w_subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_w_subject.Width = 150;
            // 
            // col_w_content
            // 
            this.col_w_content.Text = "내용";
            this.col_w_content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_w_content.Width = 250;
            // 
            // col_w_date
            // 
            this.col_w_date.Text = "작성일자";
            this.col_w_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_w_date.Width = 150;
            // 
            // col_w_count
            // 
            this.col_w_count.Text = "조회수";
            this.col_w_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_w_count.Width = 100;
            // 
            // col_w_count_people
            // 
            this.col_w_count_people.Text = "지원자 수";
            this.col_w_count_people.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_w_count_people.Width = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID : ";
            // 
            // label_login_id
            // 
            this.label_login_id.AutoSize = true;
            this.label_login_id.Location = new System.Drawing.Point(75, 102);
            this.label_login_id.Name = "label_login_id";
            this.label_login_id.Size = new System.Drawing.Size(11, 12);
            this.label_login_id.TabIndex = 5;
            this.label_login_id.Text = "-";
            // 
            // btn_show_detail
            // 
            this.btn_show_detail.Location = new System.Drawing.Point(602, 131);
            this.btn_show_detail.Name = "btn_show_detail";
            this.btn_show_detail.Size = new System.Drawing.Size(112, 36);
            this.btn_show_detail.TabIndex = 6;
            this.btn_show_detail.Text = "자세히 보기";
            this.btn_show_detail.UseVisualStyleBackColor = true;
            this.btn_show_detail.Click += new System.EventHandler(this.btn_show_detail_Click);
            // 
            // btn_delete_post
            // 
            this.btn_delete_post.Location = new System.Drawing.Point(861, 131);
            this.btn_delete_post.Name = "btn_delete_post";
            this.btn_delete_post.Size = new System.Drawing.Size(112, 36);
            this.btn_delete_post.TabIndex = 7;
            this.btn_delete_post.Text = "공고 삭제";
            this.btn_delete_post.UseVisualStyleBackColor = true;
            this.btn_delete_post.Click += new System.EventHandler(this.btn_delete_post_Click);
            // 
            // btn_edit_detail
            // 
            this.btn_edit_detail.Location = new System.Drawing.Point(733, 131);
            this.btn_edit_detail.Name = "btn_edit_detail";
            this.btn_edit_detail.Size = new System.Drawing.Size(112, 36);
            this.btn_edit_detail.TabIndex = 8;
            this.btn_edit_detail.Text = "공고 수정";
            this.btn_edit_detail.UseVisualStyleBackColor = true;
            this.btn_edit_detail.Click += new System.EventHandler(this.btn_edit_detail_Click);
            // 
            // label_login_com
            // 
            this.label_login_com.AutoSize = true;
            this.label_login_com.Location = new System.Drawing.Point(209, 102);
            this.label_login_com.Name = "label_login_com";
            this.label_login_com.Size = new System.Drawing.Size(11, 12);
            this.label_login_com.TabIndex = 10;
            this.label_login_com.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "기업명 : ";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(927, 19);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(40, 40);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "새로고침";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_applicant
            // 
            this.btn_applicant.Location = new System.Drawing.Point(733, 75);
            this.btn_applicant.Name = "btn_applicant";
            this.btn_applicant.Size = new System.Drawing.Size(240, 38);
            this.btn_applicant.TabIndex = 13;
            this.btn_applicant.Text = "해당 공고 지원자 보기";
            this.btn_applicant.UseVisualStyleBackColor = true;
            this.btn_applicant.Click += new System.EventHandler(this.btn_applicant_Click);
            // 
            // Menu4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_applicant);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label_login_com);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_edit_detail);
            this.Controls.Add(this.btn_delete_post);
            this.Controls.Add(this.btn_show_detail);
            this.Controls.Add(this.label_login_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Menu4";
            this.Size = new System.Drawing.Size(995, 635);
            this.Load += new System.EventHandler(this.Menu4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader col_w_num;
        private System.Windows.Forms.ColumnHeader col_w_ID;
        private System.Windows.Forms.ColumnHeader col_w_subject;
        private System.Windows.Forms.ColumnHeader col_w_content;
        private System.Windows.Forms.ColumnHeader col_w_date;
        private System.Windows.Forms.ColumnHeader col_w_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_login_id;
        private System.Windows.Forms.Button btn_show_detail;
        private System.Windows.Forms.Button btn_delete_post;
        private System.Windows.Forms.Button btn_edit_detail;
        private System.Windows.Forms.Label label_login_com;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader col_w_count_people;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_applicant;
        public System.Windows.Forms.ListView listView1;
    }
}
