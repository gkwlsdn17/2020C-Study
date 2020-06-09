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

            lotto();

        }

        public static void lotto()
        {
            Random random = new Random();
            int[] lotto = new int[6];
            int k = 0;
            while (k < 10)
            {
                for (int i = 0; i < 6; i++)
                {
                    int r = random.Next(1, 46);
                    Console.Write(r + " ");

                    if (i == 0)
                    {
                        lotto[i] = r;
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (lotto[j] == r)
                            {
                                i = i - 1;
                                break;
                            }
                            else
                            {
                                lotto[i] = r;
                            }
                        }
                        
                    }

                }
                Console.WriteLine();

                for (int i = 0; i < 6; i++)
                {
                    Console.Write(lotto[i] + " ");
                }
                Console.WriteLine("\n---------------------------");


                for (int i = 0; i < 6; i++)
                {
                    lotto[i] = 0;
                }
                k++;
            }
        }
       
    }
}
