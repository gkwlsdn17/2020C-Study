using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    class Student
    {
        public string name;
        public string gender;
        public string major;
        public Student(string name,string gender, string major)
        {
            this.name = name;
            this.gender = gender;
            this.major = major;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("이동준","남","C#");
            Student s2 = new Student("박명회", "남", "java");
            Student s3 = new Student("김은주", "여", "oracle");

            List<string> list = new List<string>();
            list.Add("안녕하세요");
            list.Add("감사합니다");
            list.Add("안녕히계세요");
            list.Add("랄ㄹ라랄라라라");
            list.Add("롤ㄹ롤로로로");

            Random random = new Random();
            int num = random.Next(6);
            Console.WriteLine(list[num]);
            
        }
    }
}
