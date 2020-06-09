using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Ex05.Car();
            car.showInfo();

            Car car2 = new Car("서대구 영업소", "기아", "실버", "4천만원", "K7");
            car2.showInfo();
        }
    }
}
