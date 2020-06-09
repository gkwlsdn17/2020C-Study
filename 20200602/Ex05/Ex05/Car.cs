using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Car
    {
        private static string AGENCY;
        private string manufacturer;
        private string color;
        private string price;
        private string model;

        public Car()
        {
            manufacturer = "기아";
            color = "블랙";
            model = "K7";
            price = "4천만원";
            AGENCY = "동대구 영업소";
        }
        public Car(string agency, string manufacturer, string color, string price, string model)
        {
            AGENCY = agency;
            this.manufacturer = manufacturer;
            this.color = color;
            this.price = price;
            this.model = model;

        }

        public void showInfo()
        {
            Console.WriteLine("대리점명: " + AGENCY);
            Console.WriteLine("제조사: " + manufacturer);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("모델: " + model);
            Console.WriteLine("가격: " +price);
            
            
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        
    }
}
