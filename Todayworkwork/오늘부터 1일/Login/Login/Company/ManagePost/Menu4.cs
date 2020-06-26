using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Login.Recruit;
using Login.Company.ManagePost;
using Login.PostRecruit;

namespace Login
{
    public partial class Menu4 : UserControl
    {
        // 로그인 정보 입력받기                                                                                  
        //string login_id = "testtestest_park";                                                             // 나중에 입력받은 값으로 수정하기
        //string login_com = "삼성전자";                                                                // 나중에 입력받은 값으로 수정하기

        // RECRUIT table에서 로그인 아이디와 일치하는 글 select where id=?? 로 입력 받기

        SqlConnection conn = new SqlConnection();
        string w_num;       // 글번호 입력받을 변수

        public Menu4()
        {
            InitializeComponent();
        }

        public void Menu4_Load(object sender, EventArgs e)
        {
            refresh_listview();     // 새로고침
            // 로그인 정보 표시
            //label_login_id.Text = login_id;
            //label_login_com.Text = login_com;
        }

        // 새로고침
        public void refresh_listview()
        {
            listView1.Items.Clear();    // 리스트뷰 목록 삭제
            ShowDB();                   // 리스트박스 입력
            conn.Close();
        }

        // DB 연결
        private void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source={0}; " +
                        "Initial Catalog = {1};" +
                        "Persist Security Info = {2};" +
                        "User ID = {3};" +
                        "Password={4}"
            , "munggu.iptime.org,11113", "TodayWorkWork", "True", "sa", "8765432!");

            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
            Console.WriteLine("DB 연결 성공(form4로드)");         // 테스트
        }

        // 리스트박스 DB보여주기
        public void ShowDB()
        {
            try
            {
                ConnectDB();
                Console.WriteLine("showDB 호출");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select w_num,id,subject,w_content,w_date,count from RECRUIT "; // where id=@W_ID
                                                                                                  //cmd.Parameters.AddWithValue("@W_ID", login_id);
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        listView1.Items.Add(new ListViewItem(
                            new string[]
                            {
                            DR["w_num"].ToString(),
                            DR["ID"].ToString(),
                            DR["SUBJECT"].ToString(),
                            DR["W_CONTENT"].ToString(),
                            DR["W_DATE"].ToString(),
                            DR["COUNT"].ToString()
                            }));
                    }
                }
                DR.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("showDB Error");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            try
            {
                ListViewItem item = listView1.SelectedItems[0];

                Console.WriteLine("선택한 글 번호 : " + item.SubItems[0].Text);   // 테스트
                w_num = item.SubItems[0].Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine("listview_SelectedIndexChanged Error");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
        }
        // 자세히보기 버튼 클릭
        private void btn_show_detail_Click(object sender, EventArgs e)
        {
            show_detail(w_num);
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            show_detail(w_num);
        }

        // 자세히보기 버튼 클릭 Recruit 안 WriteDetail.cs 호출
        private void show_detail(string num)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT where W_NUM=" + w_num, conn);
                adpt.Fill(ds);
                WriteDetail wd = new WriteDetail(ds);
                wd.MaximizeBox = false;         // WriteDetail 호출시 최소화,최대화 버튼 삭제
                wd.MinimizeBox = false;
                wd.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine("btn_show_detail_click Error");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
        }

        // 수정하기 버튼 클릭
        private void btn_edit_detail_Click(object sender, EventArgs e)
        {
            Edit_post_detail edit = new Edit_post_detail(w_num);
            edit.ShowDialog();
            refresh_listview();
        }

        // 새로고침 버튼 클릭
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh_listview();
        }

        // 공고등록 버튼 클릭
        private void btn_insert_post_Click(object sender, EventArgs e)
        {
            Menu1 m1 = new Menu1();
            m1.Show();
        }

        // 공고삭제 버튼 클릭
        private void btn_delete_post_Click(object sender, EventArgs e)
        {
            delete_post(w_num);
        }
        public void delete_post(string num)
        {
            ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from RECRUIT where w_num = @w_num";
            cmd.Parameters.AddWithValue("@w_num", num);
            cmd.ExecuteNonQuery();
            conn.Close();
            refresh_listview();
        }

        private void btn_applicant_Click(object sender, EventArgs e)
        {
            if (w_num != null)
            {
                ApplicantList ap_list = new ApplicantList(int.Parse(w_num));
                ap_list.Show();
            }
        }
    }
}
