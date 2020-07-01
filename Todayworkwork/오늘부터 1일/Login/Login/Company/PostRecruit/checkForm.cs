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
using Login.PostRecruit;
using Login.Company.PostRecruit;

namespace Login.PostRecruit
{
    public partial class checkForm : Form
    {
        int count = 0;
        // DB연결
        string strConn = DBConnection.strconn;



        public checkForm()
        {
            InitializeComponent();

        }

        private void bringCount()
        {
            SqlConnection sqlconn = new SqlConnection(strConn);
            sqlconn.Open();
            SqlCommand rcmd = new SqlCommand("select * from RECRUIT where W_NUM = (select MAX(W_NUM) from RECRUIT)", sqlconn);
            SqlDataReader sdr = rcmd.ExecuteReader();
            sdr.Read();
            int.TryParse(sdr["W_NUM"].ToString(), out count);
            count++;
            sqlconn.Close();
        }
        private void insertData()
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(strConn);
                sqlconn.Open();
                string cmdText = "Insert Into RECRUIT (W_NUM,ID,NAME,SUBJECT,COM_NAME,FIELD, PAY, W_START_TIME, W_END_TIME, W_PLACE," +
                      "W_DATE, PERIOD, W_CONTENT) VALUES(@w_num,@id,@name,@sbj,@com_name,@field,@pay,@start,@finish,@w_place,@time,@dead,@w_content)";
                SqlCommand cmd = new SqlCommand(cmdText, sqlconn);

                int intPay = Convert.ToInt32(Menu1.getPay());

                cmd.Parameters.AddWithValue("@w_num", count);
                cmd.Parameters.AddWithValue("@id", MainForm.getID());
                cmd.Parameters.AddWithValue("@name", MainForm.getName());
                cmd.Parameters.AddWithValue("@sbj", Menu1.getSbj());
                cmd.Parameters.AddWithValue("@com_name", MainForm.getCom_name());
                cmd.Parameters.AddWithValue("@field", Menu1.getField());
                cmd.Parameters.AddWithValue("@pay", (intPay * 10000));
                cmd.Parameters.AddWithValue("@start", Menu1.getStart());
                cmd.Parameters.AddWithValue("@finish", Menu1.getFinish());
                cmd.Parameters.AddWithValue("@w_place", Menu1.getPlace());
                cmd.Parameters.AddWithValue("@time", DateTime.Now);
                cmd.Parameters.AddWithValue("@dead", Menu1.getDead());
                cmd.Parameters.AddWithValue("@w_content", Menu1.getContent());

                cmd.ExecuteNonQuery();
                sqlconn.Close();


                onYesExit();


            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
                MessageBox.Show(ee.StackTrace);
            }


        }

        private void onApplyBtn(object sender, EventArgs e)
        {
            try
            {

                bringCount();
                checkPost();
                //                        afterInsertData();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }

        }
        private void checkPost()
        {
            while (true)
            {

                if (String.IsNullOrEmpty(Menu1.getSbj()) || String.IsNullOrWhiteSpace(Menu1.getSbj()) ||
                      String.IsNullOrEmpty(Menu1.getField()) || String.IsNullOrWhiteSpace(Menu1.getField()) ||
                            String.IsNullOrEmpty(Menu1.getPay()) || String.IsNullOrWhiteSpace(Menu1.getPay()) ||
                                  String.IsNullOrEmpty(Menu1.getPlace()) || String.IsNullOrWhiteSpace(Menu1.getPlace()))
                {
                    MessageBox.Show("텍스트 박스에 문자를 삽입하여 주세요");
                    break;
                }
                if (Menu1.getStart().Date == Menu1.getFinish().Date || Menu1.getStart().Date == Menu1.getDead().Date)
                {
                    MessageBox.Show("날짜를 입력하세요");
                    break;
                }
                else
                {
                    insertData();
                    break;
                }
            }
        }

        private void onCancelBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onYesExit()
        {
            string str = "yes";
            Close();

            if (str == "yes")
            {

                Menu2.getInstance().BringToFront();

            }
        }




    }
}
