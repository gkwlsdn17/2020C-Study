using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Calculate
    {
        public int Power(int input)
        {
            return input * input;
        }

        public int Power(int input,int count)
        {
            int output = 1;
            for(int i = 0; i < count; i++)
            {
                output = output * input;
            }
            return output;
        }
        public int sumAll(int end)
        {
            //int sum = 0;
            //for(int i = 0; i <= end; i++)
            //{
            //    sum += end;
            //}
            //return sum;
            return sumAll(0, end);
        }
        public int sumAll(int start,int end)
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
