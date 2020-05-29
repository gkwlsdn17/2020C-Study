using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Console.WriteLine("Inch를 입력하세요");
            input = Console.ReadLine();

            //double cm = Convert.ToDouble(input) * 2.54;
            double cm;
            //double.Parse(input);
            double.TryParse(input, out cm);
            cm = cm * 2.54;
            Console.WriteLine("cm: "+cm);

            Console.WriteLine("kg을 입력하세요");
            input = Console.ReadLine();
            double pound = Convert.ToDouble(input) * 2.20462262;
            Console.WriteLine("pound: "+pound);
            
            Console.WriteLine("원의 반지름을 입력 하세요");
            input = Console.ReadLine();
            double round = 2 * 3.14 * Convert.ToDouble(input);
            double area = 3.14 * Convert.ToDouble(input) * Convert.ToDouble(input);
            Console.WriteLine("반지름이 "+input+"인 원의 둘레는 "+round);
            Console.WriteLine("반지름이 "+input+"인 원의 넓이는 "+area);


            //int number = 0;
            //Console.WriteLine("Inch를 입력하세요");
            //input = Console.ReadLine();
            //int.TryParse(input, out number);
            //Console.WriteLine(number);

            //double cm = number * 2.54;
            //Console.WriteLine(cm);

            //Console.WriteLine("kg을 입력하세요");
            //input = Console.ReadLine();
            //int.TryParse(input, out number);
            //double pound = number * 2.20462262;
            //Console.WriteLine(pound);

            //Console.WriteLine("원의 반지름을 입력하세요");
            //input = Console.ReadLine();
            //int.TryParse(input, out number);

            //double area = number * number * 3.141592;
            //double round = 2 * 3.14 * number;

            //Console.WriteLine(round);
            //Console.WriteLine(area);
        }
    }
}
