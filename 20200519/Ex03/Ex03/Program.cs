using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolbool = bool.Parse("true");
            bool boolbool2 = bool.Parse("false");
            Console.WriteLine(boolbool);
            Console.WriteLine(boolbool2);
            string test = "100";
            //int tester = int.Parse(test); //Parse는 문자열을 숫자 자료형으로 변환
            int tester;
            int.TryParse(test,out tester);  // 숫자 자료형으로 변환 실패하면 0을 반환 아니면 제대로 바꿈
            Console.WriteLine(tester);

            test = "abcdefg";
            int.TryParse(test, out tester);
            Console.WriteLine(tester);

            double doubleNumber = 51.923;
            int doubleValue = (int)doubleNumber;
            Console.WriteLine(doubleValue);

            long longNumber = 1L + 1L;
            int intValue = (int)longNumber;
            Console.WriteLine(intValue);

            //string input = Console.ReadLine();
            //Console.WriteLine("input: " + input);

            double number = 51.123;
            Console.WriteLine(number);
            Console.WriteLine(number.ToString("0.0"));
            Console.WriteLine(number.ToString("0.00")); //자리수 표시 가능
        }
    }
}
