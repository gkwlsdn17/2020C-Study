using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Individual.Resume_menu3
{
    class ResumeInfo
    {

        static InsertResume Ir = new InsertResume();
        //DB연결
        string strconn = DBConnection.strconn;

        public void readRESUMEInfo(string id) //로그인 된 사용자의 정보를 읽기
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                string table_name = "RESUME";
                SqlCommand cmd = new SqlCommand($"select * from {table_name} where ID = '@id'", sqlcon);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader sdr = cmd.ExecuteReader();
                
                while (sdr.Read())
                {
                    Ir.resume_Subject = sdr["RE_SUBJECT"].ToString();
                    Ir.resume_Location = sdr["LOCATION"].ToString();
                    Ir.resume_License = sdr["LICENSE"].ToString();
                    Ir.resume_Exp = sdr["EXP"].ToString();
                    Ir.resume_Content = sdr["CONTENT"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (sqlcon != null)
                    sqlcon.Close();
            }


        }
        public static string getSubject() { return Ir.resume_Subject; }
        public static string getLocation() { return Ir.resume_Location; }
        public static string getLicense() { return Ir.resume_License; }
        public static string getExp() { return Ir.resume_Exp; }
        public static string getContent() { return Ir.resume_Content; }
    }
}
