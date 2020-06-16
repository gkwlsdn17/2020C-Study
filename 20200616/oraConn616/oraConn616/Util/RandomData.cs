using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraConn616
{
    class RandomData
    {
        static string[] first = { "동", "아", "경", "수", "호" };
        static string[] mid = { "길", "세", "나", "민", "연" };
        static string[] last = { "김", "이", "박", "최", "홍" };
        static int[] age = { 10, 20, 30, 40, 50 };
        static string[] addr = { "대구 동구 신암1동", "대구 동구 신암2동", "대구 동구 신암3동", "대구 동구 신암4동" };

        static Random r = new Random();
        public static string getName()
        {
            string fullName = last[r.Next(last.Length)] + mid[r.Next(mid.Length)] + first[r.Next(first.Length)];
            return fullName;
        }
        public static int getAge()
        {
            return age[r.Next(age.Length)];
        }
        public static string getAddr()
        {
            return addr[r.Next(addr.Length)];
        }
    }
}
