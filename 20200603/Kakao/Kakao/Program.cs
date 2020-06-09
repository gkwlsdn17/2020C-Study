using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao
{
    class Program
    {
        static void Main(string[] args)
        {
            fiveArr();
            sixArr();
        }
        public static void fiveArr()
        {
            int n = 5;

            //int.TryParse(Console.ReadLine(), out n);

            int[] arr1 = { 9, 20, 28, 18, 11 };
            int[] arr2 = { 30, 1, 21, 17, 28 };
            Console.Write("[\"");
            for (int i = 0; i < arr1.Length; i++)
            {
                string[] temp = new string[n];
                string[] temp2 = new string[n];

                int count = 0;

                getBinary(arr1[i], ref count, temp);
                count = 0;
                getBinary(arr2[i], ref count, temp2);

                int len = temp.Length - 1;
                for (int j = len; j >= 0; j--)
                {
                    if (temp[j] == null) { temp[j] = "0"; }
                    if (temp2[j] == null) { temp2[j] = "0"; }
                }

                for (int j = len; j >= 0; j--)
                {
                    if (temp[j] == temp2[j] && int.Parse(temp[j]) == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                if (i != arr1.Length - 1)
                {
                    Console.Write("\",\"");
                }
                else
                {
                    Console.Write("\"");
                }

            }
            Console.WriteLine("]");
        }
        public static void sixArr()
        {
            int n = 6;

            //int.TryParse(Console.ReadLine(), out n);

            int[] arr1 = { 46,33,33,22,31,50 };
            int[] arr2 = { 27,56,19,14,14,10 };
            Console.Write("[\"");
            for (int i = 0; i < arr1.Length; i++)
            {
                string[] temp = new string[n];
                string[] temp2 = new string[n];

                int count = 0;

                getBinary(arr1[i], ref count, temp);
                count = 0;
                getBinary(arr2[i], ref count, temp2);

                int len = temp.Length - 1;
                for (int j = len; j >= 0; j--)
                {
                    if (temp[j] == null) { temp[j] = "0"; }
                    if (temp2[j] == null) { temp2[j] = "0"; }
                }

                for (int j = len; j >= 0; j--)
                {
                    if (temp[j] == temp2[j] && int.Parse(temp[j]) == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                if (i != arr1.Length - 1)
                {
                    Console.Write("\",\"");
                }
                else
                {
                    Console.Write("\"");
                }

            }
            Console.WriteLine("]");
        }
        public static int getBinary(int num,ref int count,string[] temp)
        {

            if (num < 1) { return 0; }
            else
            {
                temp[count] = (num % 2).ToString();
                count++;
                return getBinary(num / 2,ref count,temp);
            }

        }
    }
}
