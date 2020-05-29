using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool enter = true;
            //1번 
            for(int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10-i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //2번
            //int[] arr = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i + "번째 숫자를 입력하세요");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (max < arr[i])
            //    {
            //        max = arr[i];
            //    }
            //    if (min > arr[i])
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine("가장 큰 수는 " + max);
            //Console.WriteLine("가장 작은 수는 " + min);

            //3번
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i + 1) + "번째: " + start);
                string end = "";
                char number = start[0];
                int count = 0;
                for(int j = 0; j < start.Length; j++)
                {
                    if(number != start[j])
                    {
                        end = end + number + count;
                        number = start[j];
                        count = 1;
                        
                    }
                    else
                    {
                        count++;
                    }
                    
                }
                end = end + number + count;
                start = end;
            }
            
        }
    }
}
