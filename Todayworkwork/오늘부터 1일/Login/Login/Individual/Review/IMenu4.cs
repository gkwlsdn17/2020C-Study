using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Individual.Review;
using System.Data.SqlClient;

namespace Login
{
    public partial class IMenu4 : UserControl
    {
        public IMenu4()
        {
            InitializeComponent();
        }
        private void IMenu4_Load(object sender, EventArgs e)
        {
            ShowDB();
            label_username.Text = IMemberMainForm.getName();
        }
        SqlConnection conn = new SqlConnection();
        string r_num;

        // 리스트박스 DB보여주기
        public void ShowDB()
        {
            try
            {
                conn.ConnectionString = DBConnection.strconn;

                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();
                Console.WriteLine("showDB 호출");                                     // 테스트
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                // cmd.CommandText = "select ** from RECRUIT where id = @W_ID";                   *************** 수정하기!***************
                cmd.Parameters.AddWithValue("@W_ID", IMemberMainForm.getID());
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        listView1.Items.Add(new ListViewItem(new string[]
                            {
                            DR["w_num"].ToString(),
                            DR["ID"].ToString(),
                            DR["SUBJECT"].ToString(),
                            DR["W_CONTENT"].ToString(),
                            DR["W_DATE"].ToString(),
                            DR["COUNT"].ToString()
                            }));
                    }
                }else
                {
                    Console.WriteLine("작성한 리뷰가 없음을 보여주는 곳");
                }
                DR.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("showDB Error");                      // 에러메세지
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // 선택한값 r_num 지정
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
                r_num = item.SubItems[0].Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine("listview_SelectedIndexChanged Error");                   // 에러메세지
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
        }

        // 후기 작성 버튼 클릭
        private void btn_write_review_Click(object sender, EventArgs e)
        {
            Write_Review wr = new Write_Review();
            wr.MaximizeBox = false;
            wr.MinimizeBox = false;
            wr.ShowDialog();
        }

        // 후기 자세히보기 버튼 클릭
        private void btn_show_rev_detail_Click(object sender, EventArgs e)
        {
            show_review_detail();
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            show_review_detail();
        }
        private void show_review_detail()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter("select * from review where R_NUM=" + r_num, conn);
                adpt.Fill(ds);
                View_Review vr = new View_Review(ds);
                vr.MaximizeBox = false;
                vr.MinimizeBox = false;
                vr.Show();
            }
            catch (Exception)
            {

                if (conn != null)
                {
                    conn.Close();
                }
            
            }
            
        }


    }
}
