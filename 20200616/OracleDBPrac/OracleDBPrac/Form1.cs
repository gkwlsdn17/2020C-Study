using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleDBPrac
{
    public partial class Form1 : Form
    {
        static string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User ID=hr;Password=1234;";
        static OracleConnection conn = new OracleConnection(ORADB);
        static OracleCommand cmd = new OracleCommand();
        public Form1()
        {
            InitializeComponent();
            
            oracleDBConnection(conn);
            selectDB();
        }

        public void oracleDBConnection(OracleConnection conn)
        {
            try
            {
                conn.Open();
                Console.WriteLine("DB 연결 성공");
            }
            catch(OracleException e)
            {
                Console.WriteLine("DB 연결 실패: " + e.Message);
            }
            
        }
        public void oracleDBDisconnection(OracleConnection conn)
        {
            try
            {
                conn.Close();
                Console.WriteLine("DB 연결 해제 성공");
            }
            catch(OracleException e)
            {
                Console.WriteLine("DB 연결 실패: " + e.Message);
            }
        }
        public static OracleConnection getOracleConnection()
        {
            return conn;
        }
        public static  OracleCommand getOracleCommand()
        {
            return cmd;
        }
        private void btn_createTable(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "create table student0616( id int not null, name varchar(20) not null, age int not null, addr varchar(50) not null, constraint pk_id primary key(id))";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "create sequence seq_student0616_id increment by 1 start with 1";
                cmd.ExecuteNonQuery();

                MessageBox.Show("student0616 테이블이 생성 되었습니다!");
            }
            catch(OracleException oe)
            {
                MessageBox.Show("이미 student0616 테이블이 존재 합니다.\n"+oe.Message);
            }


        }

        private void btn_deleteTable(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "drop table student0616";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "drop sequence seq_student0616_id";
                cmd.ExecuteNonQuery();

                MessageBox.Show("student0616 테이블을 삭제하였습니다!");

            }
            catch(OracleException oe)
            {
                MessageBox.Show("테이블 삭제에 실패하였습니다.\n" + oe.Message);
            }
        }

        private void btn_EXIT(object sender, EventArgs e)
        {
            oracleDBDisconnection(conn);
            MessageBox.Show("프로그램을 종료합니다");
            Application.Exit();
        }

        private void btn_createData(object sender, EventArgs e)
        {
            CreateDataForm cdf = new CreateDataForm();
            cdf.ShowDialog();
            selectDB();
            
        }

        private void list_oracleDBdata(object sender, EventArgs e)
        {
            
        }
        private void selectDB()
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "select * from student0616";
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                tb_selectDB.Text = "ID\tNAME\tAGE\tADDRESS\r\n";
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        tb_selectDB.Text += dr["id"] + "\t" + dr["name"] + "\t" + dr["age"] + "\t" + dr["addr"] + "\r\n";
                    }
                }
            }
            catch (OracleException oe)
            {
                tb_selectDB.Text = "DB 오류 "+oe.Message;
            }
        }

        private void btn_deleteData(object sender, EventArgs e)
        {
            DeleteDataForm ddf = new DeleteDataForm();
            ddf.ShowDialog();
            selectDB();
        }

        private void tb_selectData(object sender, EventArgs e)
        {
            selectDB();
        }

        private void btn_updateData(object sender, EventArgs e)
        {
            UpdateDataForm udf = new UpdateDataForm();
            udf.ShowDialog();
            selectDB();
        }
    }
}
