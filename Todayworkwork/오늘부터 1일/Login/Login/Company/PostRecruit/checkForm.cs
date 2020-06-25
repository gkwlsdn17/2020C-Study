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

namespace Login.PostRecruit
{
    public partial class checkForm : Form
    {
        int count = 0;
        // DB연결
        string strConn = "Data Source=munggu.iptime.org,11113;Initial Catalog=TodayWorkWork;Persist Security Info=True;User ID=sa;Password=8765432!";


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
                insertData();
                onYesExit(sender, e);
                
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }

        }
        
        private void onCancelBtn(object sender, EventArgs e)
        {
            string str = "no";
            onCheckFormSendEvent(str);
            this.Close();
        }
        public delegate void checkFormSendEvent(string msg);
        public event checkFormSendEvent onCheckFormSendEvent;
        private void onYesExit(object sender, EventArgs e)
        {
            string str = "yes";
            onCheckFormSendEvent(str);
            Close();
        }

    }
}
