using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Individual.CompanyInfo;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Login
{
    public partial class IMenu2 : UserControl
    {
        private Button currentButton;
        string strconn = "Data Source=munggu.iptime.org,11113;Initial Catalog=TodayWorkWork;Persist Security Info=True;User ID=sa;Password=8765432!";
        int count;
        string search_keyword;
        bool search_on = false; //검색한 내용만 정렬할 때 확인용

        //컨트롤 둥글게 만들기 위해 참조
        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        public IMenu2()
        {
            InitializeComponent();
        }
        private void infoItemView(DataSet ds)
        {
            flowLayoutPanel1.Controls.Clear();
            InfoItem[] infolist = new InfoItem[count];
            int i = 0;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                infolist[i] = new InfoItem();
                infolist[i].lb_COM_NAME = item["COM_NAME"].ToString();
                infolist[i].lb_FIELD = item["FIELD"].ToString();
                double point;
                double.TryParse(item["STAR_PT"].ToString(), out point);
                infolist[i].lb_POINT = point;
                int sales;
                int.TryParse(item["SALES"].ToString(), out sales);
                infolist[i].lb_SALES = sales;
                infolist[i].lb_COM_TEL = item["COM_TEL"].ToString();
                int ap_count;
                int.TryParse(item["AP_COUNT"].ToString(), out ap_count);
                infolist[i].lb_AP_COUNT = ap_count;
                infolist[i].lb_COM_ADDR = item["COM_ADDR"].ToString();
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                flowLayoutPanel1.Controls.Add(infolist[i]);
                i++;
            }
        }

        private void IMenu2_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select * from COM_INFO", sqlcon);
            adpt.Fill(ds);
            count = ds.Tables[0].Rows.Count;
            infoItemView(ds);
            sqlcon.Close();

            //검색창 테두리 둥글게
            IntPtr tbRound = CreateRoundRectRgn(0, 0, panel_search.Width, panel_search.Height, 15, 15);
            int i = SetWindowRgn(panel_search.Handle, tbRound, true);
            //정렬버튼 테두리 둥글게
            buttonInitSetting();
            this.Refresh();
            ActivateButton(btn_all);
            
        }
        private void buttonInitSetting()
        {
            //정렬버튼 테두리 둥글게
            IntPtr btnAllSearchRound = CreateRoundRectRgn(0, 0, btn_all.Width, btn_all.Height, 15, 15);
            int i2 = SetWindowRgn(btn_all.Handle, btnAllSearchRound, true);
            IntPtr btn_comSearchRound = CreateRoundRectRgn(0, 0, btn_seq_letter.Width, btn_seq_letter.Height, 15, 15);
            int i3 = SetWindowRgn(btn_seq_letter.Handle, btn_comSearchRound, true);
            IntPtr btn_pointSearchRound = CreateRoundRectRgn(0, 0, btn_seq_point.Width, btn_seq_point.Height, 15, 15);
            int i4 = SetWindowRgn(btn_seq_point.Handle, btn_pointSearchRound, true);
            IntPtr btn_applySearchRound = CreateRoundRectRgn(0, 0, btn_seq_apply.Width, btn_seq_apply.Height, 15, 15);
            int i5 = SetWindowRgn(btn_seq_apply.Handle, btn_applySearchRound, true);

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
        private void btn_search_Click(object sender, EventArgs e)
        {
            search_keyword = tb_search.Text;
            tb_search.Text = "";
            search_on = true;
            DataSet ds = new DataSet();
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select * from COM_INFO where COM_NAME LIKE '%"+search_keyword+"%'", sqlcon);
            adpt.Fill(ds);
            count = ds.Tables[0].Rows.Count;
            infoItemView(ds);
            sqlcon.Close();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            search_on = false;
            DataSet ds = new DataSet();
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select * from COM_INFO", sqlcon);
            adpt.Fill(ds);
            count = ds.Tables[0].Rows.Count;
            infoItemView(ds);
            sqlcon.Close();

        }
        private bool firstClick = false; //맨 처음 검색박스 클릭 시 안내 글자 사라짐
        private void tb_search_Click(object sender, EventArgs e)
        {
            if (firstClick == false)
            {
                search_keyword = tb_search.Text;
                tb_search.Text = "";
                firstClick = true;
            }
        }
        private bool seq_letter_asc = true; //true면 글자순 오름차순, false면 글자수 내림차순, 기본 오름차순 셋팅
        private void btn_seq_letter_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DataSet ds = new DataSet();
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();
            SqlDataAdapter adpt;
            if (search_on == true)
            {
                if (seq_letter_asc == true)
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO where COM_NAME LIKE '%"+search_keyword+"%' order by COM_NAME ASC", sqlcon);
                    seq_letter_asc = false;
                }
                else
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO where COM_NAME LIKE '%" + search_keyword + "%' order by COM_NAME DESC", sqlcon);
                    seq_letter_asc = true;
                }
                
            }
            else
            {
                if(seq_letter_asc == true)
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO order by COM_NAME ASC", sqlcon);
                    seq_letter_asc = false;
                }
                else
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO order by COM_NAME DESC", sqlcon);
                    seq_letter_asc = true;
                }
            }
            adpt.Fill(ds);
            count = ds.Tables[0].Rows.Count;
            infoItemView(ds);
            sqlcon.Close();

        }
        private bool seq_point_asc = false; //true면 평점 오름차순, false면 평점 내림차순,기본 내림차순 셋팅
        private void btn_seq_point_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DataSet ds = new DataSet();
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();
            SqlDataAdapter adpt;
            if (search_on == true)
            {
                if (seq_point_asc == true)
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO where COM_NAME LIKE '%" + search_keyword + "%' order by STAR_PT ASC", sqlcon);
                    seq_point_asc = false;
                }
                else
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO where COM_NAME LIKE '%" + search_keyword + "%' order by STAR_PT DESC", sqlcon);
                    seq_point_asc = true;
                }

            }
            else
            {
                if (seq_point_asc == true)
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO order by STAR_PT ASC", sqlcon);
                    seq_point_asc = false;
                }
                else
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO order by STAR_PT DESC", sqlcon);
                    seq_point_asc = true;
                }
            }
            adpt.Fill(ds);
            count = ds.Tables[0].Rows.Count;
            infoItemView(ds);
            sqlcon.Close();
        }
        private bool seq_apply_asc = false; //true면 지원자수 오름차순, false면 지원자수 내림차순, 기본 지원자수 내림차순 셋팅
        private void btn_seq_apply_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DataSet ds = new DataSet();
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();
            SqlDataAdapter adpt;
            if (search_on == true)
            {
                if (seq_apply_asc == true)
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO where COM_NAME LIKE '%" + search_keyword + "%' order by AP_COUNT ASC", sqlcon);
                    seq_apply_asc = false;
                }
                else
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO where COM_NAME LIKE '%" + search_keyword + "%' order by AP_COUNT DESC", sqlcon);
                    seq_apply_asc = true;
                }

            }
            else
            {
                if (seq_apply_asc == true)
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO order by AP_COUNT ASC", sqlcon);
                    seq_apply_asc = false;
                }
                else
                {
                    adpt = new SqlDataAdapter("select * from COM_INFO order by AP_COUNT DESC", sqlcon);
                    seq_apply_asc = true;
                }
            }
            adpt.Fill(ds);
            count = ds.Tables[0].Rows.Count;
            infoItemView(ds);
            sqlcon.Close();
        }

        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_on = true;
                search_keyword = tb_search.Text;

                DataSet ds = new DataSet();
                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from COM_INFO where COM_NAME LIKE '%" + search_keyword + "%'", sqlcon);
                adpt.Fill(ds);
                count = ds.Tables[0].Rows.Count;
                infoItemView(ds);
                sqlcon.Close();

                tb_search.Text = "";
            }
        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //엔터시 띵띵 소리나는거 제거
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;

            }
        }
    }
}
