using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            //Console.WriteLine(52 + 273);
            //Console.WriteLine("52+273");
            //Console.WriteLine(10 / 4);
            //Console.WriteLine(5.0/3.0);
            //Console.WriteLine("가나다" + "마바사");

            //Console.WriteLine("안녕하세요"[0]);

            //Console.WriteLine('a' + 'b'); //아스키코드 더한 값이 나옴
            //Console.WriteLine("a" + "b");

            //bool test = true;

            //int integerValue = int.MaxValue;
            //long longValue = long.MaxValue;
            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);

            //integerValue = int.MinValue;
            //longValue = long.MinValue;
            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);

            //integerValue = integerValue - 1; //언더플로우
            //Console.WriteLine(integerValue);

            //uint unsignedInt = 4147483647;
            //ulong unsignedLong = 11223372036854775808;
            //Console.WriteLine(unsignedInt);
            //Console.WriteLine(unsignedLong);

            //unsignedInt = uint.MinValue; Console.WriteLine(unsignedInt);
            //unsignedInt = uint.MaxValue; Console.WriteLine(unsignedInt);

            //Console.WriteLine(123L); //long타입을 명시해줌

            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));

            Console.WriteLine($"int: {sizeof(int)}");
            Console.WriteLine(string.Format("long: {0}", sizeof(long)));
            Console.WriteLine(string.Format("float: {0}{1}double: {2}", sizeof(float), Environment.NewLine, sizeof(double)));
            Console.WriteLine("char: " + sizeof(char));

        }
    }
}
