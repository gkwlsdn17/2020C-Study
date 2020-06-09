using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            string[] gender = { "남", "여" };
            string[] address = { "조선 두메산골1", "조선 두메산골2",
                "조선 두메산골3", "조선 두메산골4","조선 두메산골5" };
            
            Student[] stdArr = new Student[10];
            Random rand = new Random();
            for(int i = 0; i < stdArr.Length; i++)
            {
                string rand_name = name[rand.Next(name.Length)];
                int rand_age = age[rand.Next(age.Length)];
                string rand_gender = gender[rand.Next(gender.Length)];
                string rand_address = address[rand.Next(address.Length)];

                stdArr[i] = new Student(rand_name, rand_age, rand_gender, rand_address);
            }

            for(int i = 0; i < stdArr.Length; i++)
            {
                stdArr[i].showInfo();
            }

            stdArr[9].NAME = "전우치";
            stdArr[9].AGE = 240;
            stdArr[9].GENDER = "남";
            stdArr[9].ADDRESS = "조선 강원 두메산골";

            for (int i = 0; i < stdArr.Length; i++)
            {
                stdArr[i].showInfo();
            }

        }
    }
}
