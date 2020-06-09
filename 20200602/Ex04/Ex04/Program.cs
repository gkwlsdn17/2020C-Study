using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class student
    {
        private string name;
        private int age;

        //기본 생성자
        //객체가 생성될 때 1번만 호출되는 특수한 메소드
        //클래스 정보 초기화;
        public student()
        {
            name = "홍길동";
            age = 500;
            Console.WriteLine("생성자 호출");
        }
        public student(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        ~student()
        {
            Console.WriteLine("소멸자 호출");
        }
        public void stShowInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("나이: " + age);
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new student().stShowInfo();
            student std = new student();
            std.Name = "김길동";
            std.Age = 100;
            Console.WriteLine(std.Name);
            Console.WriteLine(std.Age);

            new student("전우치", 200).stShowInfo();

        }
    }
}
