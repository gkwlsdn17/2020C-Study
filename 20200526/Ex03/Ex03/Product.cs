using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Product
    {
        public static int mCounter = 0;
        public int mId;
        public string mName;
        public int mPrice;
        public const int test = 1;

        public Product(string name, int price)
        {
            mCounter++;
            mId = mCounter;
            mName = name;
            mPrice = price;
        }
    }
}
