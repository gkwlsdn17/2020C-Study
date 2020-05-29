using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            string message = "안녕하세요";
            char[] newmessage = new char[5];
            newmessage[0] = '안';
            newmessage[1] = '녕';
            newmessage[2] = '하';
            newmessage[3] = '세';
            newmessage[4] = '요';

            Console.WriteLine(message);
            Console.WriteLine(newmessage);
            Console.WriteLine(message + "!");
            Console.WriteLine(message[0]);
            Console.WriteLine(newmessage[0]);

            number = 100;
            Console.WriteLine(number.GetType());
            Console.WriteLine((123L).GetType());

            Console.Write('a');
            Console.Write('b');
            Console.WriteLine();

            int n;
            n = 100;
            var vn = 100; // var변수는 초기화 꼭 해줘야 함
            var vn2 = 100L;
            var vn3 = 100F;

            //vn = "string"; //여기서 var변수는 자료형 변환 불가
        }
    }
}
