namespace Login
{
    partial class Menu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu2));
            this.panel_search = new System.Windows.Forms.Panel();
            this.btn_search = new Login.Recruit.CircularButton();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.W_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIELD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_allSearch = new System.Windows.Forms.Button();
            this.btn_comSearch = new System.Windows.Forms.Button();
            this.btn_fieldSearch = new System.Windows.Forms.Button();
            this.btn_countSearch = new System.Windows.Forms.Button();
            this.panel_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.panel_search.Controls.Add(this.btn_search);
            this.panel_search.Controls.Add(this.tb_search);
            this.panel_search.Location = new System.Drawing.Point(141, 23);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(855, 87);
            this.panel_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.AutoSize = true;
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(32, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(46, 46);
            this.btn_search.TabIndex = 2;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_search.ForeColor = System.Drawing.Color.White;
            this.tb_search.Location = new System.Drawing.Point(110, 27);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(710, 42);
            this.tb_search.TabIndex = 0;
            this.tb_search.Text = "검색 할 내용을 입력하세요";
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.W_NUM,
            this.ID,
            this.SUBJECT,
            this.COM_NAME,
            this.FIELD,
            this.COUNT});
            this.dataGridView1.Location = new System.Drawing.Point(51, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 548);
            this.dataGridView1.TabIndex = 1;
            // 
            // W_NUM
            // 
            this.W_NUM.HeaderText = "글번호";
            this.W_NUM.MinimumWidth = 6;
            this.W_NUM.Name = "W_NUM";
            // 
            // ID
            // 
            this.ID.HeaderText = "작성자";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // SUBJECT
            // 
            this.SUBJECT.HeaderText = "제목";
            this.SUBJECT.MinimumWidth = 6;
            this.SUBJECT.Name = "SUBJECT";
            // 
            // COM_NAME
            // 
            this.COM_NAME.HeaderText = "업체명";
            this.COM_NAME.MinimumWidth = 6;
            this.COM_NAME.Name = "COM_NAME";
            // 
            // FIELD
            // 
            this.FIELD.HeaderText = "직종";
            this.FIELD.MinimumWidth = 6;
            this.FIELD.Name = "FIELD";
            // 
            // COUNT
            // 
            this.COUNT.HeaderText = "조회수";
            this.COUNT.MinimumWidth = 6;
            this.COUNT.Name = "COUNT";
            // 
            // btn_allSearch
            // 
            this.btn_allSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.btn_allSearch.FlatAppearance.BorderSize = 0;
            this.btn_allSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allSearch.ForeColor = System.Drawing.Color.White;
            this.btn_allSearch.Location = new System.Drawing.Point(84, 137);
            this.btn_allSearch.Name = "btn_allSearch";
            this.btn_allSearch.Size = new System.Drawing.Size(107, 49);
            this.btn_allSearch.TabIndex = 2;
            this.btn_allSearch.Text = "전체글";
            this.btn_allSearch.UseVisualStyleBackColor = false;
            this.btn_allSearch.Click += new System.EventHandler(this.btn_allSearch_Click);
            // 
            // btn_comSearch
            // 
            this.btn_comSearch.BackColor = System.Drawing.Color.White;
            this.btn_comSearch.FlatAppearance.BorderSize = 0;
            this.btn_comSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comSearch.Location = new System.Drawing.Point(208, 137);
            this.btn_comSearch.Name = "btn_comSearch";
            this.btn_comSearch.Size = new System.Drawing.Size(107, 49);
            this.btn_comSearch.TabIndex = 2;
            this.btn_comSearch.Text = "업체명";
            this.btn_comSearch.UseVisualStyleBackColor = false;
            this.btn_comSearch.Click += new System.EventHandler(this.btn_comSearch_Click);
            // 
            // btn_fieldSearch
            // 
            this.btn_fieldSearch.BackColor = System.Drawing.Color.White;
            this.btn_fieldSearch.FlatAppearance.BorderSize = 0;
            this.btn_fieldSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fieldSearch.Location = new System.Drawing.Point(338, 137);
            this.btn_fieldSearch.Name = "btn_fieldSearch";
            this.btn_fieldSearch.Size = new System.Drawing.Size(107, 49);
            this.btn_fieldSearch.TabIndex = 2;
            this.btn_fieldSearch.Text = "직종";
            this.btn_fieldSearch.UseVisualStyleBackColor = false;
            this.btn_fieldSearch.Click += new System.EventHandler(this.btn_fieldSearch_Click);
            // 
            // btn_countSearch
            // 
            this.btn_countSearch.BackColor = System.Drawing.Color.White;
            this.btn_countSearch.FlatAppearance.BorderSize = 0;
            this.btn_countSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_countSearch.Location = new System.Drawing.Point(464, 137);
            this.btn_countSearch.Name = "btn_countSearch";
            this.btn_countSearch.Size = new System.Drawing.Size(107, 49);
            this.btn_countSearch.TabIndex = 2;
            this.btn_countSearch.Text = "조회수";
            this.btn_countSearch.UseVisualStyleBackColor = false;
            this.btn_countSearch.Click += new System.EventHandler(this.btn_countSearch_Click);
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_countSearch);
            this.Controls.Add(this.btn_fieldSearch);
            this.Controls.Add(this.btn_comSearch);
            this.Controls.Add(this.btn_allSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_search);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu2";
            this.Size = new System.Drawing.Size(1137, 794);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn COM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIELD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COUNT;
        private System.Windows.Forms.Button btn_allSearch;
        private System.Windows.Forms.Button btn_comSearch;
        private System.Windows.Forms.Button btn_fieldSearch;
        private System.Windows.Forms.Button btn_countSearch;
        private Recruit.CircularButton btn_search;
    }
}
