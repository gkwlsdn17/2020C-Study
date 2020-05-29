﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01
{
    public partial class Form1 : Form
    {
        class Student
        {
            public string mName;
            public int mGender; //0남 1여
            public string mMajor;
            public Student()
            {

            }
            public Student(string name, int gender, string major)
            {
                mName = name;
                mGender = gender;
                mMajor = major;
            }
        }
        public Form1()
        {
            InitializeComponent();
            Student st1 = new Student();
            st1.mName = "이동준";
            st1.mGender = 0;
            st1.mMajor = "c#";

            Student st2 = new Student() { mName = "박명회", mGender = 0, mMajor = "java" };
            Student st3 = new Student("김은주", 1, "oracle");

            Student[] students = new Student[3];
            students[0] = st1;
            students[1] = new Student() { mName = "박명회", mGender = 0, mMajor = "java" };
            students[2] = new Student("김은주", 1, "oracle");

            string gender = st1.mGender == 0 ? "남" : "여";
            label1.Text = $"이름: {st1.mName}, 성별: {gender}, 주과목: {st1.mMajor}";

            gender = st2.mGender == 0 ? "남" : "여";
            label2.Text = $"이름: {st2.mName}, 성별: {gender}, 주과목: {st2.mMajor}";

            gender = st3.mGender == 0 ? "남" : "여";
            label3.Text = $"이름: {st3.mName}, 성별: {gender}, 주과목: {st3.mMajor}";

            for(int i = 0; i < 3; i++)
            {
                Label lb1 = new Label();
                gender = students[i].mGender == 0 ? "남" : "여";
                lb1.Text = $"이름: {students[i].mName}, 성별: {gender}, 주과목: {students[i].mMajor}";
                Controls.Add(lb1);
                lb1.AutoSize=true;
                lb1.Location = new Point(30, 130+30*i);
            }
            
        }
    }
}
