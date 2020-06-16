using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraConn616
{
    class DbManager
    {
        static DbManager instance;
        string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User ID=hr;Password=1234;";
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;
        public static DbManager getInstance()
        {
            if (instance == null)
            {
                instance = new DbManager();
            }
            return instance;
        }
        public DbManager() //생성자
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            
        }

        ~DbManager() //소멸자
        {
            dbDisconnection();
        }

        public void dbConnection()
        {
            try
            {
                conn.Open();
                Console.WriteLine("DB 연결 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오류: " + e.Message);
            }

        }
        void dbDisconnection()
        {
            try
            {
                conn.Close();
                Console.WriteLine("DB 연결 해제 완료");

            }
            catch (OracleException e)
            {
                Console.WriteLine("오류: " + e.Message);
            }
        }

        public void createTable()
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "create table student" +
                    "(id number not null, " +
                    "name varchar(20) not null, " +
                    "age number not null, " +
                    "addr varchar(80) not null, " +
                    "constraint pk_student_id primary key(id))";
                cmd.ExecuteNonQuery();
                
                cmd.CommandText = "create sequence seq_id increment by 1 start with 1";
                cmd.ExecuteNonQuery();

                Console.WriteLine("테이블 및 시퀀스 생성이 완료 되었습니다!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 생성 에러: " + e.Message);
            }
        }
        public void dropTable()
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "drop table student";
                cmd.ExecuteNonQuery();
                
                cmd.CommandText = "drop sequence seq_id";
                cmd.ExecuteNonQuery();

                Console.WriteLine("테이블 및 시퀀스 삭제가 완료 되었습니다!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 삭제 오류: " + e.Message);
            }
        }
        public void selectDB()
        {
            int count = 0;
            cmd.Connection = conn;
            cmd.CommandText = "select * from student";
            cmd.CommandType = System.Data.CommandType.Text;
            dr = cmd.ExecuteReader();

            Console.WriteLine("ID\tNAME\tAGE\tADDR\t");
            Console.WriteLine("-------------------------------------------");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.Write(dr["id"] + "\t" + dr["name"] + "\t" + dr["age"] + "\t" + dr["addr"]);
                    Console.WriteLine();
                    count++;
                }
                Console.WriteLine("총 데이터의 행의 갯수는 " + count + "개 입니다.");
            }
            else
            {
                Console.WriteLine("데이터가 없습니다");
            }

            dr.Close();
        }
        public void insertDB()
        {
           
            try
            {
               
                cmd.Connection = conn;
                cmd.CommandText = $"insert into student values (seq_id.nextval,'{RandomData.getName()}',{RandomData.getAge()},'{RandomData.getAddr()}')";
                cmd.ExecuteNonQuery();

                Console.WriteLine("테이블 삽입이 완료 되었습니다!");

            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 삽입 오류: " + e.Message);
            }
        }
        bool search_DB(string data,string type)
        {
            switch (type)
            {
                case "id":
                    cmd.CommandText = $"select * from student where id={data}";
                    cmd.CommandType = System.Data.CommandType.Text;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "name":
                    cmd.CommandText = $"select * from student where name='{data}'";
                    cmd.CommandType = System.Data.CommandType.Text;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;

            }
        }
        public void deleteDB()
        {
            Console.WriteLine("삭제할 ID를 입력하세요");
            string delete_key = Console.ReadLine();
            bool check = false;
            try
            {
                cmd.Connection = conn;
                if (search_DB(delete_key,"id"))
                {
                    check = true;
                }

                cmd.CommandText = $"delete from student where id={delete_key}";
                cmd.ExecuteNonQuery();
                if (check)
                {
                    Console.WriteLine("삭제를 완료하였습니다");
                }
                else
                {
                    Console.WriteLine("데이터가 없습니다");
                }

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);

            }
        }
        public void updateDB()
        {
            try
            {
                Console.WriteLine("수정 전 데이터의 이름을 입력하세요");
                string search_name = Console.ReadLine();
                Console.WriteLine("수정 할 데이터의 이름을 입력하세요");
                string modify_name = Console.ReadLine();

                bool check = search_DB(search_name, "name");
                cmd.Connection = conn;
                cmd.CommandText = $"update student set name = '{modify_name}' where name = '{search_name}'";
                cmd.ExecuteNonQuery();
                
                if (check)
                {
                    Console.WriteLine("데이터 수정을 완료 하였습니다!");
                }
                else
                {
                    Console.WriteLine("데이터가 없습니다");
                }
                
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 수정 오류: " + e.Message);
            }

        }
    }
}
