using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Singletone
    {
        private static Singletone inst;
        private int data;
        private static Random ra;

        public Singletone(Random rand)
        {
            ra = rand;
            data = rand.Next(1, 100);
        }
        public int getData()
        {
            return data;
        }
        public static Singletone getInstance()
        {
            if (inst == null)
            {
                inst = new Singletone(ra);
            }
            return inst;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Singletone st1 = new Singletone(r);
            Console.WriteLine(st1.getData());

            
            Console.WriteLine(new Singletone(r).getData());
            Console.WriteLine(new Singletone(r).getData());

            Console.WriteLine(Singletone.getInstance().getData());
            Console.WriteLine(Singletone.getInstance().getData());
            Console.WriteLine(Singletone.getInstance().getData());
            //같은 객체를 이용하기 때문에 같은 값이 나온다.
        }
    }
}
