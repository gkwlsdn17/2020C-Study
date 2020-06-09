using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            string[] tel = {"010-1111-1234",
                            "010-1222-1234",
                            "010-1133-1234","010-1144-1234","010-1155-1234"};
            string[] address =
            {
                "대구 동구 신암1동", "서울 동구 신암1동",
                "부산 동구 신암1동", "대전 동구 신암1동",
                "광주 동구 신암1동"
            };

            string[] model = { "SM6", "쏘나타", "싼타페", "K7", "그랜저" };
            string[] color = { "블랙", "은색", "흰색", "빨강", "파랑" };
            int[] year = { 2017, 2018, 2019, 2020, 2021 };
            string[] company = { "삼성르노", "현대", "기아", "쌍용" };

            Customer[] cst = new Customer[10];
            Random rand = new Random();
            for(int i = 0; i < cst.Length; i++)
            {
                cst[i] = new Customer(
                    name[rand.Next(name.Length)], 
                    tel[rand.Next(tel.Length)], 
                    address[rand.Next(address.Length)],
                    new Car(model[rand.Next(model.Length)],color[rand.Next(color.Length)],year[rand.Next(year.Length)],company[rand.Next(company.Length)])
                    );
            }

            for(int i = 0; i < cst.Length; i++)
            {
                cst[i].showInfo();
            }
        }
    }
}
