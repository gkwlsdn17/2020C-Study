using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Car
    {
        public static string agency;
        private string manufacturer;
        private string color;
        private string price;
        private string model;

        public Car()
        {
            manufacturer = "기아";
            color = "블랙";
            model = "K7";
            price = "40000000";
            agency = "동대구 영업소";
        }
        public Car(string manufacturer, string color, string price, string model, string _agency)
        {
            this.manufacturer = manufacturer;
            this.color = color;
            this.price = price;
            this.model = model;
            agency = _agency;
        }

        public void showInfo()
        {
            Console.WriteLine("제조사: " + manufacturer);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("모델: " + model);
            Console.Write("가격: ");
            char[] str = price.ToCharArray();
            int count = str.Length-1;
            for(int i = 0; i < str.Length; i++)
            {
                if (count % 3 == 0)
                {
                    Console.Write(str[i]);
                    if (i != str.Length - 1)
                    {
                        Console.Write(",");
                    }

                }
                else
                {
                    Console.Write(str[i]);
                }
                count--;
                
            }
            Console.WriteLine("원");

            Console.WriteLine("대리점명: " + agency);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.showInfo();
        }
    }
}
