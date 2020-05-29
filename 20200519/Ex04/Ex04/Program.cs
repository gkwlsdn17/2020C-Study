using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void DDi(int year)
        {
            if (year == 0)
            {
                Console.WriteLine("원숭이띠");
            }
            else if (year == 1)
            {
                Console.WriteLine("닭띠");
            }
            else if (year == 2)
            {
                Console.WriteLine("개띠");
            }
            else if (year == 3)
            {
                Console.WriteLine("돼지띠");
            }
            else if (year == 4)
            {
                Console.WriteLine("쥐띠");
            }
            else if (year == 5)
            {
                Console.WriteLine("소띠");
            }
            else if (year == 6)
            {
                Console.WriteLine("호랑이띠");
            }
            else if (year == 7)
            {
                Console.WriteLine("토끼띠");
            }
            else if (year == 8)
            {
                Console.WriteLine("용띠");
            }
            else if (year == 9)
            {
                Console.WriteLine("뱀띠");
            }
            else if (year == 10)
            {
                Console.WriteLine("말띠");
            }
            else if (year == 11)
            {
                Console.WriteLine("양띠");
            }
        }
        static void season(int month)
        {
            if (month >= 3 && month < 6)
            {
                Console.WriteLine("봄 입니다");
            }
            else if (month >= 6 && month < 9)
            {
                Console.WriteLine("여름 입니다");
            }
            else if (month >= 9 && month < 12)
            {
                Console.WriteLine("가을 입니다");
            }
            else
            {
                Console.WriteLine("겨울 입니다");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("태어난 년도 입력: ");
            int input = int.Parse(Console.ReadLine());
            int sec = input % 12;
            DDi(sec);
            Console.Write("현재 년도("+DateTime.Now.Year+")의 띠는 ");
            DDi(DateTime.Now.Year % 12); //현재 년도 띠
            

            Console.WriteLine("현재 월을 입력하세요");
            int month = int.Parse(Console.ReadLine());
            season(month);
            Console.Write("현재 월("+DateTime.Now.Month+")의 계절은 ");
            season(DateTime.Now.Month);

            Console.WriteLine("hello 치면 안녕하세요 라고 출력");
            string line = Console.ReadLine();
            if (line.Contains("hello"))
            {
                Console.WriteLine("안녕하세요");
            }
            
            //Console.WriteLine("숫자 입력: ");
            //int input = int.Parse(Console.ReadLine());
            //if (input % 2 == 0)
            //{
            //    Console.WriteLine("짝수");
            //}
            //if(input % 2 == 1)
            //{
            //    Console.WriteLine("홀수");
            //}

        }
    }
}
