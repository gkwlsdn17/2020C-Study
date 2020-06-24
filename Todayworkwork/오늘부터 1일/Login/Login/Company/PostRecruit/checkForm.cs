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

            public object textSubject { get; private set; }
            public object textField { get; private set; }
            public object textPay { get; private set; }
            public object dateTimeStart { get; private set; }
            public object dateTimeFinish { get; private set; }
            public object textPlace { get; private set; }
            public object deadLineTime { get; private set; }
            public object textContent { get; private set; }

            private void insertData()
            {
                  
                  SqlConnection sqlconn = new SqlConnection(strConn);
                  sqlconn.Open();
                  //SqlDataAdapter adpt = new SqlDataAdapter("");
                  string cmdText = "Insert Into RECRUIT (W_NUM,SUBJECT,FIELD, PAY, W_START_TIME, W_END_TIME, W_PLACE" +
                        "PERIOD, W_CONTENT) VALUES(@w_num@sbj,@field,@pay,getdate(),getdate(),@w_place,getdate(),@w_content)";
                  SqlCommand cmd = new SqlCommand(cmdText, sqlconn);
                  
                  int intPay = Convert.ToInt32(textPay);
                  
                  cmd.Parameters.AddWithValue("@w_num",count);
                  cmd.Parameters.AddWithValue("@sbj", textSubject.ToString());
                  cmd.Parameters.AddWithValue("@field", textField.ToString());
                  cmd.Parameters.AddWithValue("@pay", (intPay*10000));
                  cmd.Parameters.AddWithValue("@w_place", textPlace.ToString());
                  cmd.Parameters.AddWithValue("@w_content", textContent.ToString());

                  cmd.ExecuteNonQuery();
                  sqlconn.Close();
                  
            }
            /*
            private void selectData()
            {
                  DataSet ds = new DataSet();

                  SqlConnection sqlcon = new SqlConnection(strConn);
                  sqlcon.Open();

                  SqlDataAdapter adpt = new SqlDataAdapter("select * from COM_CUSTOMER ", sqlcon);
                  adpt.Fill(ds);

                  sqlcon.Close();
            }
             */
            private void onApplyBtn(object sender, EventArgs e)
            {
                  try
                  {
                        
                        count += 1;
                        insertData();

                  }
                  catch (Exception ee)
                  {
                        MessageBox.Show(ee.Message);
                        
                  }
                  
            }

            private void onCancelBtn(object sender, EventArgs e)
            {
                  this.Close();
            }

            private void checkForm_Load(object sender, EventArgs e)
            {
                  //selectData();
            }
      }
}
