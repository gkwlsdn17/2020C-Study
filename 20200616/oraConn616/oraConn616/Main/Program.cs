using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraConn616
{
    class Program
    {
        static void Main(string[] args)
        {
            //DB.DbManager db = new DB.DbManager();
            //db.dbConnection();

            DbManager.getInstance().dbConnection();
            
            
            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. 테이블 생성");
                Console.WriteLine("2. 테이블 삭제");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("3. 데이터 검색");
                Console.WriteLine("4. 데이터 삽입");
                Console.WriteLine("5. 데이터 삭제");
                Console.WriteLine("6. 데이터 수정");
                Console.WriteLine("7. 프로그램 종료");

                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        DbManager.getInstance().createTable();
                        break;
                    case "2":
                        DbManager.getInstance().dropTable();
                        break;
                    case "3":
                        DbManager.getInstance().selectDB();
                        break;
                    case "4":
                        DbManager.getInstance().insertDB();
                        break;
                    case "5":
                        DbManager.getInstance().deleteDB();
                        break;
                    case "6":
                        DbManager.getInstance().updateDB();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;

                }
             }
             
        }

    }
}
