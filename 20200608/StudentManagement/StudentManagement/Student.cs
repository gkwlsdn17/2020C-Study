using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Student
    {
        private string name;
        private int age;
        private string gender;
        private string address;

        public Student()
        {

        }
        public Student(string name, int age, string gender, string address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public int AGE
        {
            get { return age; }
            set { age = value; }
        }
        public string GENDER
        {
            get { return gender; }
            set { gender = value; }
        }
        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }

        public void showInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("나이: " + age);
            Console.WriteLine("성별: " + gender);
            Console.WriteLine("주소: " + address);
            Console.WriteLine("-------------------------");
        }

    }
}
