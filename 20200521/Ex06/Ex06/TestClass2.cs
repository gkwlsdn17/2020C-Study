using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex06
{
    class TestClass2
    {
        public static int Power(int x)
        {
            return x * x;
        }
        public static int Multi(int x, int y)
        {
            return x * y;
        }
        public static void print()
        {
            MessageBox.Show("메시지 출력");
        }
    }
}
