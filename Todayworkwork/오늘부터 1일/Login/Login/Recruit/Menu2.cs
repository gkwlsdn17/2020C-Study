﻿using System;
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
        private void buttonInitSetting()
        {
            IntPtr btnAllSearchRound = CreateRoundRectRgn(0, 0, btn_allSearch.Width, btn_allSearch.Height, 15, 15);
            int i2 = SetWindowRgn(btn_allSearch.Handle, btnAllSearchRound, true);
            IntPtr btn_comSearchRound = CreateRoundRectRgn(0, 0, btn_comSearch.Width, btn_comSearch.Height, 15, 15);
            int i3 = SetWindowRgn(btn_comSearch.Handle, btn_comSearchRound, true);
            IntPtr btn_countSearchRound = CreateRoundRectRgn(0, 0, btn_countSearch.Width, btn_countSearch.Height, 15, 15);
            int i4 = SetWindowRgn(btn_countSearch.Handle, btn_countSearchRound, true);
            IntPtr btn_fieldSearchRound = CreateRoundRectRgn(0, 0, btn_fieldSearch.Width, btn_fieldSearch.Height, 15, 15);
            int i5 = SetWindowRgn(btn_fieldSearch.Handle, btn_fieldSearchRound, true);
        }
        private void selectData()
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();
            
            SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by W_NUM desc", sqlcon);
            adpt.Fill(ds);

            dataGridView1.Rows.Clear();
            foreach (DataRow viewData in ds.Tables[0].Rows)
            {

                dataGridView1.Rows.Add(viewData["W_NUM"], viewData["SUBJECT"], viewData["COM_NAME"], viewData["FIELD"], viewData["ID"], viewData["COUNT"]);
            }
            
            
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
                cmd.Connection = sqlcon;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd.CommandText, sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                foreach (DataRow viewData in ds.Tables[0].Rows)
                {

                    dataGridView1.Rows.Add(viewData["W_NUM"], viewData["SUBJECT"], viewData["COM_NAME"], viewData["FIELD"], viewData["ID"],  viewData["COUNT"]);
                }


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
                foreach (DataRow viewData in ds.Tables[0].Rows)
                {

                    dataGridView1.Rows.Add(viewData["W_NUM"], viewData["SUBJECT"], viewData["COM_NAME"], viewData["FIELD"], viewData["ID"], viewData["COUNT"]);
                }


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
                foreach (DataRow viewData in ds.Tables[0].Rows)
                {

                    dataGridView1.Rows.Add(viewData["W_NUM"], viewData["SUBJECT"], viewData["COM_NAME"], viewData["FIELD"], viewData["ID"], viewData["COUNT"]);
                }


                sqlcon.Close();
                comSearchChoice = true;
            }
            ActivateButton(sender);
        }

        private bool fieldSearchChoice = true; //true면 직종 오름차순, false면 직종 내림차순
        private void btn_fieldSearch_Click(object sender, EventArgs e)
        {
            if(fieldSearchChoice == true)
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by FIELD ASC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                foreach (DataRow viewData in ds.Tables[0].Rows)
                {

                    dataGridView1.Rows.Add(viewData["W_NUM"], viewData["SUBJECT"], viewData["COM_NAME"], viewData["FIELD"], viewData["ID"], viewData["COUNT"]);
                }


                sqlcon.Close();
                fieldSearchChoice = false;
            }
            else
            {
                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT order by FIELD DESC, W_NUM DESC;", sqlcon);
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                foreach (DataRow viewData in ds.Tables[0].Rows)
                {

                    dataGridView1.Rows.Add(viewData["W_NUM"], viewData["SUBJECT"], viewData["COM_NAME"], viewData["FIELD"], viewData["ID"], viewData["COUNT"]);
                }


                sqlcon.Close();
                fieldSearchChoice = true;
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
                foreach (DataRow viewData in ds.Tables[0].Rows)
                {

                    dataGridView1.Rows.Add(viewData["W_NUM"], viewData["SUBJECT"], viewData["COM_NAME"], viewData["FIELD"], viewData["ID"], viewData["COUNT"]);
                }


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
                foreach (DataRow viewData in ds.Tables[0].Rows)
                {

                    dataGridView1.Rows.Add(viewData["W_NUM"], viewData["SUBJECT"], viewData["COM_NAME"], viewData["FIELD"], viewData["ID"], viewData["COUNT"]);
                }


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

        private void Menu2_Load(object sender, EventArgs e)
        {
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


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //맨 마지막 행은 데이터가 없으므로 클릭해도 정보가 뜨지 않게 함
            if(e.RowIndex!=dataGridView1.Rows.Count-1)
            {
                int w_num = int.Parse(dataGridView1[0, e.RowIndex].Value.ToString());

                DataSet ds = new DataSet();

                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();

                //글번호가 같은 데이터를 불러온 후 WriteDetail폼에 전달
                SqlDataAdapter adpt = new SqlDataAdapter("select * from RECRUIT where W_NUM="+w_num, sqlcon);
                adpt.Fill(ds);
                WriteDetail writedetail = new WriteDetail(ds);

                //조회수 증가
                SqlCommand cmd = new SqlCommand("update RECRUIT set COUNT = COUNT+1 where W_NUM = "+ ds.Tables[0].Rows[0]["W_NUM"],sqlcon);
                cmd.ExecuteNonQuery();

                writedetail.TopLevel = false;
                writedetail.FormBorderStyle = FormBorderStyle.None;
                writedetail.Dock = DockStyle.Fill;
                this.Controls.Add(writedetail);
                writedetail.BringToFront();
                writedetail.Show();
                sqlcon.Close();
            }
           
            
            
        }
    }
}
