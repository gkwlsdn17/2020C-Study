using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement
{
    class Car
    {
        private string model;
        private string color;
        private int age;
        private string manufacturer;

        public Car()
        {

        }
        public Car(string model,string color, int age, string manufacturer)
        {
            this.model = model;
            this.color = color;
            this.age = age;
            this.manufacturer = manufacturer;
        }

        public void setModel(string model)
        {
            this.model = model;
        }
        public string getModel()
        {
            return model;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return color;
        }
        public void setAge(int age)
        {
            this.age = age;

        }
        public int getAge()
        {
            return age;
        }
        public void setManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }
        public string getManufacturer()
        {
            return manufacturer;
        }

        public string MODEL
        {
            get { return model; }
            set { model = value; }
        }
        public string COLOR
        {
            get { return color; }
            set { color = value; }
        }
        public int AGE
        {
            get { return age; }
            set { age = value; }
        }
        public string MANUFACTURER
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public void showInfo()
        {
            Console.WriteLine("모델: " + model);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("연식: " + age);
            Console.WriteLine("제조사: " + manufacturer);

        }



    }
}
