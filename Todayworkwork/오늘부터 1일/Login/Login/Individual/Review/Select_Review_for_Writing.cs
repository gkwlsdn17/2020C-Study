﻿using System;
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
    public partial class Select_Review_for_Writing : Form
    {
        public Select_Review_for_Writing()
        {
            InitializeComponent();
            ConnectDB();
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string com_names = string.Empty;    // 콤보박스 회사명 선택값
        string w_num = string.Empty;    // 콤보박스 공고글번호 선택값
        string com_field = string.Empty;    // 콤보박스 공고직종 선택값
        string a_num = string.Empty;    // 어플라이넘버값
        bool double_check = false;          // 후기 중복 체크     // false면 중복아님(진행), true면 이미작성해서 작성불가
        string double_check_input;        // 중복값 초기화변수

        private void ConnDB()
        {
            conn.ConnectionString = DBConnection.strconn;
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void ConnectDB()
        {
            ConnDB();
            cmd.CommandText = "select a_num,w_num,a_id,a_name,a_com_name,a_com_field from a_list where a_id = @id";
            cmd.Parameters.AddWithValue("@id", IMemberMainForm.getID());
            SqlDataReader DR = cmd.ExecuteReader();

            if (DR.HasRows)
            {
                while (DR.Read())
                {
                    com_names = DR["a_com_name"].ToString();
                    w_num = DR["w_num"].ToString();
                    com_field = DR["a_com_field"].ToString();
                    comboBox1.Items.Add(com_names);
                }
            }
            DR.Close();
            conn.Close();
        }
        // 콤보박스 값 선택시 변화
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label_comname.Text = comboBox1.SelectedItem.ToString();

                ConnDB();
                cmd.CommandText = "select a_num,a_com_name,w_num from a_list where a_id = @id AND a_com_name = @com_name";
                cmd.Parameters.AddWithValue("@id", IMemberMainForm.getID());
                cmd.Parameters.AddWithValue("@com_name", label_comname.Text);
                DataSet ds = new DataSet();
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        a_num = DR["a_num"].ToString();
                        com_names = DR["a_com_name"].ToString();
                        w_num = DR["w_num"].ToString();
                    }
                }
                DR.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
            Console.WriteLine("선택된 a_num값 = " + a_num);
        }

        // 공고 선택 버튼 클릭
        private void btn_select_Click(object sender, EventArgs e)
        {
            check_double_write_review();    // 중복체크
            if (comboBox1.SelectedItem == null) // 콤보박스 선택안할시
            {
                MessageBox.Show("후기 남길 공고를 선택하세요");
                Close();
            }
            else if (double_check == true)   // 이미 작성되어 있다면
            {
                MessageBox.Show("이미 후기를 작성한 공고입니다.");
                Close();
            }
            else if(double_check == false)  // 정상
            {
                show_applied_post();
                Close();
            }
        }
        // 후기 중복체크 false면 중복아님(진행), true면 이미작성해서 작성불가
        private bool check_double_write_review()
        {
            ConnDB();
            cmd.CommandText = "select rev_place,rev_field,w_num from review where rev_id=@rev_id and rev_comname=@comName " +
                            "intersect select a_com_place,a_com_field,w_num from a_list where a_id=@a_id and a_com_name =@a_comName";
            cmd.Parameters.AddWithValue("@rev_id", IMemberMainForm.getID());
            cmd.Parameters.AddWithValue("@a_id", IMemberMainForm.getID());
            cmd.Parameters.AddWithValue("@comName", com_names);
            cmd.Parameters.AddWithValue("@a_comName", com_names);
            DataSet ds = new DataSet();
            SqlDataReader DR = cmd.ExecuteReader();
            if (DR.HasRows)
            {
                while (DR.Read())
                {
                    double_check_input = DR["w_num"].ToString();
                }
            }
            Console.WriteLine("double_check_input = "+ double_check_input);
            DR.Close();
            conn.Close();
            if (double_check_input != null)
            {
                double_check = true;
            }
            else
            {
                double_check = false;
            }
            return double_check;
        }
        private void show_applied_post()
        {
            Write_Review wr = new Write_Review(a_num);
            wr.MaximizeBox = false;
            wr.MinimizeBox = false;
            wr.ShowDialog();
        }
        // 취소 버튼 클릭
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
