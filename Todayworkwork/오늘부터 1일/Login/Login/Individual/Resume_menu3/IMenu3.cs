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
using Login.Individual.Resume_menu3;
using LogIn;

namespace Login
{
    public partial class IMenu3 : UserControl
    {
        //DB연결
        string strconn = DBConnection.strconn;
        //Customer 클래스
        static Customer user = Form1.getUserInstance();
        //이력서insert
        static InsertResume Ir = new InsertResume();
        //이력서 정보 가져오기
        static ResumeInfo Ri = new ResumeInfo();
        //이력서 번호
        int count = 0;

        public IMenu3()
        {
            InitializeComponent();
        }
        private void CountReNum()
        {
            SqlConnection sqlconn = new SqlConnection(strconn);
            sqlconn.Open();
            SqlCommand rcmd = new SqlCommand("select * from RESUME where RE_NUM = (select MAX(RE_NUM) from RESUME)", sqlconn);
            SqlDataReader sdr = rcmd.ExecuteReader();
            sdr.Read();
            int.TryParse(sdr["RE_NUM"].ToString(), out count);
            count++;
            sqlconn.Close();
        }
        //이력서 insert sql
        private void Resume_Insert()
        {
            CountReNum();
            SqlConnection sqlconn = new SqlConnection(strconn);
            try
            {
                sqlconn.Open();
                string InsertText = "Insert Into RESUME (RE_NUM,ID,NAME,ADDR,EMAIL,PHONE,RE_SUBJECT,LICENSE,EXP,CONTENT,LOCATION) VALUES(@re_num,@id,@name,@addr,@email,@phone,@re_subject,@license,@exp,@content,@location) ON DUPLICATE ON KEY UPDATE id = VALUES(@id)";
                SqlCommand cmd = new SqlCommand(InsertText, sqlconn);

                cmd.Parameters.AddWithValue("@re_num", count);
                cmd.Parameters.AddWithValue("@id", IMemberMainForm.getID());
                cmd.Parameters.AddWithValue("@name", IMemberMainForm.getName());
                cmd.Parameters.AddWithValue("@addr", IMemberMainForm.getAddr());
                cmd.Parameters.AddWithValue("@email", IMemberMainForm.getEmail());
                cmd.Parameters.AddWithValue("@phone", IMemberMainForm.getPhone());
                cmd.Parameters.AddWithValue("@re_subject", IMenu3.getSbj());
                cmd.Parameters.AddWithValue("@license", IMenu3.getLic());
                cmd.Parameters.AddWithValue("@exp", IMenu3.getEx());
                cmd.Parameters.AddWithValue("@content", IMenu3.getCon());
                cmd.Parameters.AddWithValue("@location", IMenu3.getLoca());

                cmd.ExecuteNonQuery();
                sqlconn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                MessageBox.Show(ee.StackTrace);
            }
            finally
            {
                sqlconn.Close();
            }
        }
        //이력서 수정
        private void Resume_Update()
        {
            SqlConnection sqlconn = new SqlConnection(strconn);
            try
            {
                sqlconn.Open();
                string UpdateText = "update RESUME set RE_SUBJECT = @re_subject, LICENSE=@license, EXP =@exp, CONTENT =@content, LOCATION =@location where ID = @id";

                SqlCommand cmd = new SqlCommand(UpdateText, sqlconn);
                cmd.Parameters.AddWithValue("@id", IMemberMainForm.getID());
                cmd.Parameters.AddWithValue("@re_subject", IMenu3.getSbj());
                cmd.Parameters.AddWithValue("@license", IMenu3.getLic());
                cmd.Parameters.AddWithValue("@exp", IMenu3.getEx());
                cmd.Parameters.AddWithValue("@content", IMenu3.getCon());
                cmd.Parameters.AddWithValue("@location", IMenu3.getLoca());

                cmd.BeginExecuteNonQuery();
                sqlconn.Close();
            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
                MessageBox.Show(ee.StackTrace);
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void Resume_Name_Click(object sender, EventArgs e) { }
        //iMenu폼에 로그인시 바로 개인정보 불러오기
        private void IMenu3_Load(object sender, EventArgs e)
        {
            /*
            Resume_Name.Text = user.NAME;
            Resume_Phone.Text = user.PHONE;
            Resume_Addr.Text = user.ADDR;
            Resume_Email.Text = user.EMAIL;
            Subject_text.Text = ResumeInfo.getSubject();
            Location_text.Text = ResumeInfo.getLocation();
            Exp_text.Text = ResumeInfo.getExp();
            License_text.Text = ResumeInfo.getLicense();
            Introduce_text.Text = ResumeInfo.getContent();
            */
            setting();
        }
        
        public void setting()
        {
            Resume_Name.Text = user.NAME;
            Resume_Phone.Text = user.PHONE;
            Resume_Addr.Text = user.ADDR;
            Resume_Email.Text = user.EMAIL;
            ResumeInfo info = new ResumeInfo();
            info.readRESUMEInfo(user.ID);
            Subject_text.Text = ResumeInfo.getSubject();
            Location_text.Text = ResumeInfo.getLocation();
            Exp_text.Text = ResumeInfo.getExp();
            License_text.Text = ResumeInfo.getLicense();
            Introduce_text.Text = ResumeInfo.getContent();
        }
        private void Resume_Location_Click(object sender, EventArgs e) { }

        //찾기버튼과 선택폼 연동(희망지역)
        private void btn_Location_Click(object sender, EventArgs e)
        {
            Resume_LocationForm Rlf = new Resume_LocationForm("");
            Rlf.onSubFormSendEvent += setTextBox;
            Rlf.ShowDialog();

        }
        //연동된 데이터값 확인(희망지역)
        public void setTextBox(string loc)
        {
            if (loc == "")
            {
                Location_text.Text = "전달 받은 Data가 없습니다!";
            }
            else
            {
                Location_text.Text = loc;
            }
        }
        //자격증 연동
        private void btn_License_Click(object sender, EventArgs e)
        {
            Resume_License Rlc = new Resume_License("");
            Rlc.onSubFormSendEvent += setTextBox1;
            Rlc.ShowDialog();
        }
        //연동된 데이터값 확인(자격증)
        public void setTextBox1(string lic)
        {
            if (lic == "")
            {
                License_text.Text = "전달 받은 Data가 없습니다!";
            }
            else
            {
                License_text.Text = lic;
            }
        }

        //데이터값 저장
        public static string getSbj()
        {
            return Ir.resume_Subject;
        }
        public static string getLoca()
        {
            return Ir.resume_Location;
        }
        public static string getEx()
        {
            return Ir.resume_Exp;
        }
        public static string getLic()
        {
            return Ir.resume_License;
        }
        public static string getCon()
        {
            return Ir.resume_Content;
        }

        private void Insert_Resume_Click(object sender, EventArgs e)
        {
            Ir.resume_Subject = Subject_text.Text;
            Ir.resume_Location = Location_text.Text;
            Ir.resume_Exp = Exp_text.Text;
            Ir.resume_License = License_text.Text;
            Ir.resume_Content = Introduce_text.Text;

            Resume_Insert();
            MessageBox.Show("등록되었습니다.");
        }

        private void Update_Resume_Click(object sender, EventArgs e)
        {
            Ir.resume_Subject = Subject_text.Text;
            Ir.resume_Location = Location_text.Text;
            Ir.resume_Exp = Exp_text.Text;
            Ir.resume_License = License_text.Text;
            Ir.resume_Content = Introduce_text.Text;

            Resume_Update();
            MessageBox.Show("수정되었습니다.");
        }
    }
}
