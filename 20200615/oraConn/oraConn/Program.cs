using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraConn
{
    class Program
    {
        static string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
                            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
                            "User Id=hr;Password=1234;";
        static void dbConnect(OracleConnection conn)
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch(OracleException e)
            {
                Console.WriteLine("오라클 접속 오류: "+e.Message);
                return;
            }

        }
        static void dbClose(OracleConnection conn)
        {
            try
            {
                conn.Clone();
                Console.WriteLine("오라클 접속 해제");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류: "+e.Message);
                return;
            }

        }
        static void createTable(OracleConnection conn, OracleCommand cmd)
        {
            try
            {
                string query = "create table bigdata1" +
                "(id number not null," +
                "name varchar(20) not null," +
                "age number not null," +
                "addr varchar(80) not null," +
                "constraint pk_bigdata1_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string query2 = "create sequence seq_id increment by 1 start with 1";
                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블 및 시퀀스 생성 성공!");
            }
            catch(OracleException e)
            {
                Console.WriteLine("테이블 생성 에러 번호: " + e.Number);
                Console.WriteLine("테이블 생성 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("테이블 생성 에러 메시지: " + e.Message);
                return;
            }

        }
        static void dropTable(OracleConnection conn, OracleCommand cmd)
        {
            try
            {
                string query = "drop table bigdata1";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string query2 = "drop sequence seq_id";
                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();

                Console.WriteLine("테이블 및 시퀀스 삭제 성공!");
            }
            catch(OracleException e)
            {
                Console.WriteLine("테이블 삭제 에러 번호: " + e.Number);
                Console.WriteLine("테이블 삭제 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("테이블 삭제 에러 메시지: " + e.Message);
                return;
            }
        }
        static void insertDB(OracleConnection conn, OracleCommand cmd)
        {
            try
            {
                string name = "홍길동";
                int age = 300;
                string addr = "조선 한양 홍대감댁";

                string query = string.Format("insert into bigdata1 values(seq_id.nextval,'{0}','{1}','{2}')", name, age, addr);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                Console.WriteLine("데이터를 성공적으로 삽입했습니다!");
            }
            catch(OracleException e)
            {
                Console.WriteLine("데이터 삽입 에러 번호: " + e.Number);
                Console.WriteLine("데이터 삽입 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("데이터 삽입 에러 메시지: " + e.Message);
                return;
            }
            
        }
        static void Main(string[] args)
        {
            OracleConnection conn = new OracleConnection(ORADB);
            OracleCommand cmd = new OracleCommand();
            dbConnect(conn); //DB연결

            bool run = true;
            while (run)
            {
                printMenu();
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1": //테이블 생성
                        createTable(conn, cmd);
                        break;
                    case "2"://테이블 삭제
                        dropTable(conn, cmd);
                        break;
                    case "3":
                        insertDB(conn, cmd);
                        break;
                    case "4":
                        selectDB(conn, cmd);
                        break;
                    case "5":
                        dbClose(conn); //DB해제
                        Console.WriteLine("프로그램이 종료됩니다.");
                        run = false;
                        break;
                }
            }
            
        }
        static void selectDB(OracleConnection conn, OracleCommand cmd)
        {
            int count = 1;
            cmd.Connection = conn;
            cmd.CommandText = "select * from bigdata1 order by id desc";
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("번호\t이름\t나이\t주소");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("--------------------------------");
                    //Console.WriteLine("번호: " + count);
                    //Console.WriteLine("이름: " + dr["name"]);
                    //Console.WriteLine("나이: " + dr["age"]);
                    //Console.WriteLine("주소: " + dr["addr"]);
                    Console.Write(count + "\t" + dr["name"] + "\t" + dr["age"] + "\t" + dr["addr"]+"\n");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 없습니다");
            }
            dr.Close();
        }

        static void printMenu()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" 오라클 DB 관리 프로그램 v1.0");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. 테이블 생성");
            Console.WriteLine("2. 테이블 삭제");
            Console.WriteLine("3. 데이터 추가");
            Console.WriteLine("4. 데이터 보기");
            Console.WriteLine("5. 프로그램 종료");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("메뉴 선택: ");
            
        }
    }
}
