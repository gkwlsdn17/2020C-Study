using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Student
    {
        public string mName;
        public int mId;
        public string mMajor;
        public double mGrade;
        public int mGender; //0:남, 1:여

        public void mStudy()
        {
            Console.WriteLine("공부중");
        }
        public void mPlay()
        {
            Console.WriteLine("노는중");
        }
        public static string mIdentity = "공부하는 사람";

        public void print()
        {
            Console.WriteLine($"name: {mName}");
            Console.WriteLine($"id: {mId}");
            Console.WriteLine($"major: {mMajor}");
            Console.WriteLine($"grade: {mGrade}");
            Console.WriteLine($"gender: {mGender}");

        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[4];
            Student temp = new Student();

            temp.mName = "김성영";
            temp.mId = 9004;
            temp.mMajor = "컴퓨터공학";
            temp.mGrade = 4.5;
            temp.mGender = 0;

            students[0] = temp;
            students[0].print();

            Student temp2 = new Student(); // class는 call by reference라서 새롭게 정의해줘야,,,
            temp2.mName = "이동준";
        }
    }
}
