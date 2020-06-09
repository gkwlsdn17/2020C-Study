using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement
{
    class Customer
    {
        private string name;
        private string tel;
        private string address;
        Car car;
        public Customer()
        {

        }
        public Customer(string name, string tel, string address,Car car)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.car = car;
        }
        public void showInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("전화번호: " + tel);
            Console.WriteLine("주소: " + address);
            car.showInfo();
            Console.WriteLine("----------------");
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public string TEL
        {
            get { return tel; }
            set { tel = value; }
        }
        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }

        public Car CAR
        {
            get { return car; }
            set { car = value; }
        }
    }
}
