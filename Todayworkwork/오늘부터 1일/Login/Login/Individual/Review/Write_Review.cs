using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Individual.Review
{
    public partial class Write_Review : Form
    {
        public Write_Review()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();

        int r_num;       // 글번호 입력받을 변수
        private string review_ComName;  // 회사명
        private string review_Place;         // 근무지
        private string review_Field;          // 직종
        private string review_Rate;         // 평점
        private string review_Subject;       // 제목
        private string review_Content;      // 내용

        // Review Get Set
        public string RGS_ComName { get { return review_ComName; } set { review_ComName = value; } }
        public string RGS_Place { get { return review_Place; } set { review_Place = value; } }
        public string RGS_Field { get { return review_Field; } set { review_Field = value; } }
        public string RGS_Rate { get { return review_Rate; } set { review_Rate = value; } }
        public string RGS_Subject { get { return review_Subject; } set { review_Subject = value; } }
        public string RGS_Content { get { return review_Content; } set { review_Content = value; } }

        // 리뷰작성 버튼 클릭
        private void btn_confirm_write_Click(object sender, EventArgs e)
        {
            confirm_review();
        }
        private void confirm_review()
        {
            //RGS_ComName = 
            review_Place = txtb_rev_place.Text;
            review_Field = txtb_rev_field.Text;
            review_Rate = txtb_rev_rate.Text;
            review_Subject = txtb_rev_subject.Text;
            review_Content = txtb_rev_content.Text;
            insert_review();
        }
        // 리뷰 데이터 입력
        private void insert_review()
        {
            conn.ConnectionString = string.Format("Data Source={0}; " +
                        "Initial Catalog = {1};" +
                        "Persist Security Info = {2};" +
                        "User ID = {3};" +
                        "Password={4}"
            , "munggu.iptime.org,11113", "TodayWorkWork", "True", "sa", "8765432!");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
            Console.WriteLine("review DB 연결 성공");          // 테스트


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from review where r_num = (select max(r_num) from review)";
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int.TryParse(dr["R_Num"].ToString(), out r_num);
            r_num++;

            cmd.CommandText = "insert into review () values(@R_Num,@R_ID@ComName,@R_Place,@R_Field,@R_Rate,@R_Subject,@R_Content);";
            cmd.Parameters.AddWithValue("@R_Num", r_num);
            cmd.Parameters.AddWithValue("@R_ID", txtb_rev_ID.Text);
            cmd.Parameters.AddWithValue("@ComName", review_ComName);
            cmd.Parameters.AddWithValue("@R_Place", review_Place);
            cmd.Parameters.AddWithValue("@R_Field", review_Field);
            cmd.Parameters.AddWithValue("@R_Rate", review_Rate);
            cmd.Parameters.AddWithValue("@R_Subject", review_Subject);
            cmd.Parameters.AddWithValue("@R_Content", review_Content);
            cmd.ExecuteNonQuery();
            conn.Close();
            Close();
        }

        // 취소버튼
        private void btn_cancel_write_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
