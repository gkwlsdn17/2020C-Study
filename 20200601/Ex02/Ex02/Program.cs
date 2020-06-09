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
            int[] arrInt = { 10, 20, 30, 40, 50 };
            for(int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]+" ");
                string str = string.Format("배열[{0}]:{1}", i, arrInt[i]);
                Console.WriteLine(str);
            }

            char[] arrCh = new char[5] { '이', '박', '김', '홍', '최' };

            string[] arrStr = new string[5];
            Random rand = new Random();
            string[] name = {"홍길동","최길동","김길동"};
            for(int i = 0; i < name.Length; i++)
            {
                int r = rand.Next(name.Length);
                Console.WriteLine(name[r]);
            }

            int[,] arr2Int = new int[,]
            {
                {1,2,3 },
                {4,5,6 }
            };

            for(int i = 0; i < arr2Int.GetLength(0); i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(arr2Int[i,j]);
                }
                Console.WriteLine();
            }

            string[][] arrStr2 = new string[2][];
            arrStr2[0] = new string[] { "홍길동", "이길동", "박길동" };
            arrStr2[1] = new string[] { "최길동" };
            for(int i = 0; i < arrStr2.Length; i++)
            {
                for(int j= 0; j < arrStr2[i].Length; j++)
                {
                    Console.Write(arrStr2[i][j]);
                }
                Console.WriteLine();
            }

            int[] arrEach = { 10, 20, 30, 40, 50 };
            foreach (var item in arrEach)
            {
                Console.WriteLine(item);
            }

            string[,] arr2Each =
            {
                {"홍길동","김길동" },
                {"박길동","전우치" }
            };
            foreach (var item in arr2Each)
            {
                Console.Write(item+"");
            }
            Console.WriteLine();

            int[] arrRand = new int[6];
            for (int i = 0; i < 6; i++)
            {
                int num = rand.Next(1, 46);
                if (arrRand.Contains(num))
                {
                    i--;
                    Console.WriteLine("충돌났음");
                }
                else
                {
                    arrRand[i] = num;
                }
            }

            for (int i = 0; i < arrRand.Length; i++)
            {
                Console.WriteLine(arrRand[i]);
            }

            //for(int i = 0; i < 6; i++)
            //{
            //    arrRand[i]= rand.Next(1, 46);
            //    int count = 0;
            //    while (count < i)
            //    {
            //        if (arrRand[i] == arrRand[count])
            //        {
            //            arrRand[i] = rand.Next(1, 46);
            //            count = 0;
            //            Console.WriteLine("충돌났음");
            //        }
            //        else
            //        {
            //            count++;
            //        }
            //    }
            //}
            //for (int i = 0; i < arrRand.Length; i++)
            //{
            //    Console.WriteLine(arrRand[i]);
            //}
        }
    }
}
