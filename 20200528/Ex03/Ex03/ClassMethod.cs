using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class ClassMethod
    {
        public static int Power(int input)
        {
            return input * input;
        }

        public static int Power(int input, int count)
        {
            int output = 1;
            for (int i = 0; i < count; i++)
            {
                output = output * input;
            }
            return output;
        }
        public static int sumAll(int end)
        {
            return sumAll(0, end);
        }
        public static int sumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;

        }
    }
}
