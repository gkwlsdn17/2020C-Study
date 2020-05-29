using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            string[] studentname = new string[3];
            int[] id = new int[3];
            studentname[0] = "김성영";
            studentname[1] = "권강혁";
            studentname[2] = "이동준";

            id[0] = 9004;
            id[1] = 1001;
            id[2] = 0902;

            //Student[] students = new Student[4];
            //students[0].mName = "김성영";
            //students[0].mId = 9004;
            //students[0].mMajor = "컴퓨터공학";
            //students[0].mGrade = 4.5;
            //students[0].mGender = 0;
            //students[0].mPlay();
            //students[0].print();

            Student temporaryStudent = new Student();
            temporaryStudent.mName = "이동준";
            temporaryStudent.mId = 0909;
            temporaryStudent.mMajor = "정보전자과";
            temporaryStudent.mGrade=3.0;
            temporaryStudent.mGender = 0;

            Console.WriteLine(Student.mIdentity);
            Console.WriteLine(Math.PI);
        }
    }
}
