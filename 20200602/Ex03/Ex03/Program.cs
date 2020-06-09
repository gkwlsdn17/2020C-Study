using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Person
    {
        private string name;
        private int age;

        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }
        public void swapNum(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        public void swapNumRef(ref int num, ref int num2)
        {
            int temp = num;
            num = num2;
            num2 = temp;
        }

        public void add(int num, int num2, out int sum)
        {
            //return이 없어도 밖에서 선언한 변수 sum값이 자동으로 바뀐다

            sum = num + num2;

        }
        public int add(int num, int num2=0, int num3 = 0)
        {
            //default 매개변수
            //num2나 num3은 값을 넣지 않아도 자동으로 변수가 정해져있어서 괜찮음

            return num + num2 + num3;
        }
    }
    class User
    {
        public static double PI = 3.141592;
        public string name;
        public string password;
        public string address;
        public string telNum;
        public DateTime regDate;

        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.name = "홍길동";
            user.address = "조선 한양 산골";
            Console.WriteLine("이름: " + user.name);
            Console.WriteLine(User.PI);

            Person p = new Person();
            int num1 = 1, num2 = 2;
            Console.WriteLine("num1 = " + num1 + " num2 = " + num2);
            p.swapNum(num1, num2 );
            Console.WriteLine("num1 = " + num1 + " num2 = " + num2);
            p.swapNumRef(ref num1, ref num2);
            Console.WriteLine("num1 = " + num1 + " num2 = " + num2);

            //출력 전용 매개변수 out
            int sum=0;
            p.add(num1, num2, out sum);
            Console.WriteLine($"num1: {num1} num2: {num2} sum: {sum}");

            //오버로딩
            Console.WriteLine(p.add(10, 20, 30));
            Console.WriteLine(p.add(10, 100));
            Console.WriteLine(p.add(10));
            
        }
    }
}
