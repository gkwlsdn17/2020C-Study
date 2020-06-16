using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraclePractice
{
    class Program
    {
        
        static string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User ID=hr;Password=1234;";
        static void dbConnection(OracleConnection conn)
        {
            try
            {
                conn.Open();
                Console.WriteLine("DB연결 성공");
            }
            catch(OracleException e)
            {
                Console.WriteLine("오류: " + e.Message);
            }
            
        }
        static void dbDisconnection(OracleConnection conn)
        {
            try
            {
                conn.Close();
                Console.WriteLine("DB 연결 해제 완료");

            }
            catch(OracleException e)
            {
                Console.WriteLine("오류: " + e.Message);
            }
        }
        static void createTable(OracleConnection conn, OracleCommand cmd)
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

                cmd.CommandText = "create table labview" +
                   "(id number not null, " +
                   "name varchar(20) not null, " +
                   "age number not null, " +
                   "addr varchar(80) not null)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "create sequence seq_id increment by 1 start with 1";
                cmd.ExecuteNonQuery();

                Console.WriteLine("테이블 및 시퀀스 생성이 완료 되었습니다!");
            }
            catch(OracleException e)
            {
                Console.WriteLine("테이블 생성 에러: " + e.Message);
            }
            

        }
        static void dropTable(OracleConnection conn,OracleCommand cmd)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "drop table student";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "drop table labview";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "drop sequence seq_id";
                cmd.ExecuteNonQuery();

                Console.WriteLine("테이블 및 시퀀스 삭제가 완료 되었습니다!");
            }
            catch(OracleException e)
            {
                Console.WriteLine("테이블 삭제 오류: " + e.Message);
            }
        }
        static void selectDB(OracleConnection conn, OracleCommand cmd)
        {
            int count = 0;
            cmd.Connection = conn;
            cmd.CommandText = "select * from student";
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

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
        static void insertDB(OracleConnection conn, OracleCommand cmd)
        {
            string[] nameArr = { "김길동", "최길동", "박길동", "홍길동", "이길동" };
            int age = new Random().Next(10, 65);
            string[] addrArr = { "서울시 동작구", "부산광역시 해운대구", "대구광역시 동구", "대구광역시 달서구" };

            try
            {
                //Console.Write("이름을 입력하세요: ");
                //string name = Console.ReadLine();
                //Console.Write("나이를 입력하세요: ");
                //int age; int.TryParse(Console.ReadLine(),out age);
                //Console.Write("주소를 입력하세요: ");
                //string addr = Console.ReadLine();



                cmd.Connection = conn;
                //cmd.CommandText = "insert into student values (seq_id.nextval, '최길동', 100, '대구 달서구')";
                cmd.CommandText = $"insert into student values (seq_id.nextval,'{nameArr[new Random().Next(5)]}',{age},'{addrArr[new Random().Next(4)]}')";
                cmd.ExecuteNonQuery();

                Console.WriteLine("테이블 삽입이 완료 되었습니다!");

            }
            catch(OracleException e)
            {
                Console.WriteLine("테이블 삽입 오류: " + e.Message);
            }
            

        }
        static void insertDB(OracleConnection conn, OracleCommand cmd,string name, int age, string addr)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = $"insert into student values (seq_id.nextval,'{name}',{age},'{addr}')";
                cmd.ExecuteNonQuery();

                Console.WriteLine("테이블 삽입이 완료 되었습니다!");

            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 삽입 오류: " + e.Message);
            }


        }
        static bool search_DB(OracleConnection conn,OracleCommand cmd,string data)
        {
            cmd.CommandText = $"select * from student where id={data}";
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
            
        }
        static void deleteDB(OracleConnection conn, OracleCommand cmd)
        {
            Console.WriteLine("삭제할 ID를 입력하세요");
            string delete_key = Console.ReadLine();
            bool check = false;
            try
            {
                cmd.Connection = conn;
                if (search_DB(conn, cmd, delete_key))
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
        static void updateDB(OracleConnection conn, OracleCommand cmd)
        {
            try
            {
                Console.WriteLine("수정 전 데이터의 이름을 입력하세요");
                string search_name = Console.ReadLine();
                Console.WriteLine("수정 할 데이터의 이름을 입력하세요");
                string modify_name = Console.ReadLine();
                cmd.Connection = conn;
                
                cmd.CommandText = $"update student set name = '{modify_name}' where name = '{search_name}'";
                cmd.ExecuteNonQuery();

                Console.WriteLine("데이터 수정을 완료 하였습니다!");

            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 수정 오류: " + e.Message);
            }
            
        }
        
        static void tableView(OracleConnection conn, OracleCommand cmd)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "desc student";
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.Write(dr);
                        Console.WriteLine();
                    }
                    
                }
                else
                {
                    Console.WriteLine("정보가 없습니다");
                }

                dr.Close();
            }
            catch(OracleException e)
            {
                Console.WriteLine("테이블 정보 보기 오류: " + e.Message);
            }


        }
        static void alterTable(OracleConnection conn, OracleCommand cmd)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "alter table student add(name2 varchar2(40))";
                cmd.CommandText = "alter table student modify(name2 varchar2(50))";
                cmd.CommandText = "alter table student rename column name2 to name4";
                cmd.CommandText = "alter table student drop column name4";
                
                Console.WriteLine("테이블 수정이 완료 되었습니다!");
            }
            catch(OracleException e)
            {
                Console.WriteLine("테이블 수정 오류: " + e.Message);
            }
           

        }
        static void setPrimaryKey(OracleConnection conn,OracleCommand cmd)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "alter table labview add constraint my_pk_student_id primary key(id)";
                cmd.ExecuteNonQuery();
            }
            catch(OracleException e)
            {
                Console.WriteLine("기본키 지정 오류: " + e.Message);
            }
            

        }
        static void Main(string[] args)
        {
            OracleConnection conn = new OracleConnection(ORADB);
            OracleCommand cmd = new OracleCommand();
            dbConnection(conn);

            bool program_run = true;

            while (program_run)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. 테이블 생성");
                Console.WriteLine("2. 테이블 삭제");
                Console.WriteLine("3. 테이블 수정");
                Console.WriteLine("4. 테이블 정보 보기");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("5. 데이터 검색");
                Console.WriteLine("6. 데이터 삽입");
                Console.WriteLine("7. 데이터 삭제");
                Console.WriteLine("8. 데이터 수정");
                Console.WriteLine("9. 기본키 설정");
                Console.WriteLine("10. 프로그램 종료");

                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        createTable(conn, cmd);
                        break;
                    case "2":
                        dropTable(conn, cmd);
                        break;
                    case "3":
                        alterTable(conn, cmd);
                        break;
                    case "4":
                        tableView(conn, cmd);
                        break;
                    case "5":
                        selectDB(conn, cmd);
                        break;
                    case "6":
                        //insertDB(conn, cmd);
                        insertDB(conn, cmd, RandomData.getName(), RandomData.getAge(), RandomData.getAddr());
                        break;
                    case "7":
                        deleteDB(conn, cmd);
                        break;
                    case "8":
                        updateDB(conn, cmd);
                        break;
                    case "9":
                        setPrimaryKey(conn, cmd);
                        break;
                    case "10":
                        dbDisconnection(conn);
                        program_run = false;
                        break;

                }
            }
            

            
        }
        
        
    }
}
