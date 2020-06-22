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
using System.Runtime.InteropServices;
using System.Drawing.Text;
using Login.Recruit;

namespace Login
{
    
    public partial class Menu2 : UserControl
    {
        private Button currentButton;
        //DB연결
        string strconn = "Data Source=munggu.iptime.org,11113;Initial Catalog=TodayWorkWork;Persist Security Info=True;User ID=sa;Password=8765432!";

        //컨트롤 둥글게 만들기 위해 참조
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);
        
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        public Menu2()
        {
            InitializeComponent();
        }
        /*
        public static void setFont(Control.ControlCollection controls,Font font)
        {
            foreach (Control childControl in controls)
            {
                childControl.Font = font;
                if (childControl.HasChildren)
                {
                    setFont(childControl.Controls, font);
                }
            }
        }
        */
        private void Menu2_Load(object sender, EventArgs e)
        {
            
            /*
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("hy강m-yoond1004.ttf");
            Font font = new Font(privateFonts.Families[0], 12f);
            setFont(Controls,font);
            */
            dataGridView1.Font = new Font("HY강M", 10, FontStyle.Regular);
            //검색창 테두리 둥글게
            IntPtr tbRound = CreateRoundRectRgn(0, 0, panel_search.Width, panel_search.Height, 15, 15);
            int i = SetWindowRgn(panel_search.Handle, tbRound, true);
            //정렬버튼 테두리 둥글게
            buttonInitSetting();
            this.Refresh();

            ActivateButton(btn_allSearch);

            //목록 뿌리기
            selectData();

        }
        private void buttonInitSetting()
        {
            IntPtr btnAllSearchRound = CreateRoundRectRgn(0, 0, btn_allSearch.Width, btn_allSearch.Height, 15, 15);
            int i2 = SetWindowRgn(btn_allSearch.Handle, btnAllSearchRound, true);
            IntPtr btn_comSearchRound = CreateRoundRectRgn(0, 0, btn_comSearch.Width, btn_comSearch.Height, 15, 15);
            int i3 = SetWindowRgn(btn_comSearch.Handle, btn_comSearchRound, true);
            IntPtr btn_countSearchRound = CreateRoundRectRgn(0, 0, btn_countSearch.Width, btn_countSearch.Height, 15, 15);
            int i4 = SetWindowRgn(btn_countSearch.Handle, btn_countSearchRound, true);
            IntPtr btn_subjectSearchRound = CreateRoundRectRgn(0, 0, btn_subjectSearch.Width, btn_subjectSearch.Height, 15, 15);
            int i5 = SetWindowRgn(btn_subjectSearch.Handle, btn_subjectSearchRound, true);
            IntPtr btn_paySearchRound = CreateRoundRectRgn(0, 0, btn_paySearch.Width, btn_paySearch.Height, 15, 15);
            int i6 = SetWindowRgn(btn_paySearch.Handle, btn_paySearchRound, true);
            IntPtr btn_w_placeSearchRound = CreateRoundRectRgn(0, 0, btn_w_placeSearch.Width, btn_w_placeSearch.Height, 15, 15);
            int i7 = SetWindowRgn(btn_w_placeSearch.Handle, btn_w_placeSearchRound, true);
            IntPtr btn_w_end_timeSearchRound = CreateRoundRectRgn(0, 0, btn_w_end_timeSearch.Width, btn_w_end_timeSearch.Height, 15, 15);
            int i8 = SetWindowRgn(btn_w_end_timeSearch.Handle, btn_w_end_timeSearchRound, true);

        }
        private void selectData()
        {

            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by W_NUM desc", sqlcon);
            adpt.Fill(ds);

            dataGridView1.Rows.Clear();
            gridViewSetting(ds.Tables[0]);
            
            sqlcon.Close();

        }
        private void selectData(string str)
        {
            if (str.Equals(""))
            {
                selectData();
            }
            else
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from RECRUIT where SUBJECT LIKE '%"+str+"%' or COM_NAME LIKE '%"+str+"%' order by SUBJECT ASC, COM_NAME DESC";
                /*
                cmd.CommandText = "select * from RECRUIT where SUBJECT LIKE '%@str1%' or COM_NAME LIKE '%@str2%' order by SUBJECT ASC, COM_NAME DESC";
                cmd.Parameters.AddWithValue("@str1", str);
                cmd.Parameters.AddWithValue("@str2", str);
                */
                cmd.Connection = sqlcon;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd.CommandText, sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);
                
                sqlcon.Close();
            }
           
        }
        
        private void btn_search_Click(object sender, EventArgs e)
        {
            selectData(tb_search.Text.ToString());
        }

        private void btn_allSearch_Click(object sender, EventArgs e)
        {
            selectData();
            ActivateButton(sender);
        }

        private bool comSearchChoice = true; // true면 업체명 오름차순, false면 내림차순
        private void btn_comSearch_Click(object sender, EventArgs e)
        {
            if(comSearchChoice == true)
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by COM_NAME ASC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);


                sqlcon.Close();
                comSearchChoice = false;
            }
            else
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by COM_NAME DESC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);


                sqlcon.Close();
                comSearchChoice = true;
            }
            ActivateButton(sender);
        }
        
        private bool countSearchChoice = true; //true면 조회수 내림차순, false면 오름차순
        private void btn_countSearch_Click(object sender, EventArgs e)
        {
            if(countSearchChoice == true)
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by COUNT DESC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);


                sqlcon.Close();
                countSearchChoice = false;
            }
            else
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by COUNT ASC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);


                sqlcon.Close();
                countSearchChoice = true;
            }
            ActivateButton(sender);
        }
        private void ActivateButton(object btnSender)
        {
            
            if (btnSender != null)
            {
                if (currentButton != null)
                {
                    currentButton.BackColor = System.Drawing.Color.White;
                    currentButton.ForeColor = System.Drawing.Color.Gray;


                }

                currentButton = (Button)btnSender;
                currentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
                currentButton.ForeColor = System.Drawing.Color.White;


            }
        }
        private bool firstClick = false; //맨 처음 검색박스 클릭 시 안내 글자 사라짐
        private void tb_search_Click(object sender, EventArgs e)
        {
            if (firstClick == false)
            {
                firstClick = true;
                tb_search.Text = "";
            }
            
        }

       


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int w_num = int.Parse(dataGridView1[0, e.RowIndex].Value.ToString());

            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            //글번호가 같은 데이터를 불러온 후 WriteDetail폼에 전달
            SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT where W_NUM=" + w_num, sqlcon);
            adpt.Fill(ds);
            WriteDetail writedetail = new WriteDetail(ds);

            //조회수 증가
            SqlCommand cmd = new SqlCommand("update RECRUIT set COUNT = COUNT+1 where W_NUM = " + ds.Tables[0].Rows[0]["W_NUM"], sqlcon);
            cmd.ExecuteNonQuery();

            writedetail.TopLevel = false;
            writedetail.FormBorderStyle = FormBorderStyle.None;
            writedetail.Dock = DockStyle.Fill;
            this.Controls.Add(writedetail);
            writedetail.BringToFront();
            writedetail.Show();
            sqlcon.Close();




        }

        private bool paySearchChoice = true; //true는 내림차순, false는 오름차순, 기본은 내림차순으로 설정
        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (paySearchChoice == true)
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by PAY DESC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);


                sqlcon.Close();
                paySearchChoice = false;
            }
            else
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by PAY ASC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);


                sqlcon.Close();
                paySearchChoice = true;
            }
            ActivateButton(sender);
        }

        private bool w_placeSearchChoice = false; //false는 오름차순, true는 내림차순, 기본은 오름차순으로 설정
        private void btn_w_place_Click(object sender, EventArgs e)
        {
            if (w_placeSearchChoice == true)
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by W_PLACE DESC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);


                sqlcon.Close();
                w_placeSearchChoice = false;
            }
            else
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by W_PLACE ASC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);


                sqlcon.Close();
                w_placeSearchChoice = true;
            }
            ActivateButton(sender);
        }

        private bool w_end_timeSearchChoice = false; //true면 내림차순, false면 오름차순, 기본은 오름차순으로 설정
        private void btn_w_end_time_Click(object sender, EventArgs e)
        {
            if (w_end_timeSearchChoice == true)
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by W_END_TIME DESC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);


                sqlcon.Close();
                w_end_timeSearchChoice = false;
            }
            else
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by W_END_TIME ASC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);

                sqlcon.Close();
                w_end_timeSearchChoice = true;
            }
            ActivateButton(sender);
        }

        private bool subjectSearchChoice = false; //false면 오름차순, ture면 내림차순 기본은 제목 오름차순으로 설정
        private void btn_subjectSearch_Click(object sender, EventArgs e)
        {
            if (subjectSearchChoice == true)
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by SUBJECT DESC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);

                sqlcon.Close();
                subjectSearchChoice = false;
            }
            else
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by SUBJECT ASC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                gridViewSetting(ds.Tables[0]);

                sqlcon.Close();
                subjectSearchChoice = true;
            }
            ActivateButton(sender);
        }
        private void gridViewSetting(DataTable table)
        {
            foreach (DataRow viewData in table.Rows)
            {
                DateTime w_end_time = (DateTime)viewData["W_END_TIME"];
                string w_end_time_convert = w_end_time.ToString("MM") + "/" + w_end_time.ToString("dd") + "(" + w_end_time.ToString("ddd") + ")";
                int pay = (int)viewData["PAY"];
                string pay_convert = string.Format("{0}", pay.ToString("#,##0")) + " 원";
                dataGridView1.Rows.Add(viewData["W_NUM"], viewData["COM_NAME"], viewData["SUBJECT"], pay_convert.ToString(), viewData["W_PLACE"], w_end_time_convert, viewData["COUNT"]);
            }
        }
        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selectData(tb_search.Text);
                tb_search.Text = "";
            }
        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //엔터시 띵띵 소리나는거 제거
            if(e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                
            }
        }
    }
}
