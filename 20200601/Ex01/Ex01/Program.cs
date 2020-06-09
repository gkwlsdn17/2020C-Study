using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        
        static void Main(string[] args)
        {

            while (true)
            {
                int money = 0;
                Console.WriteLine("금액을 입력하세요 : ");
                if (int.TryParse(Console.ReadLine(), out money))
                {
                    change_money(money);
                }
                else
                {
                    Console.WriteLine("종료합니다");
                    break;
                }
            }

        }

        public static void change_money(int money)
        {
            int coin_500 = 0;
            int coin_100 = 0;
            int coin_50 = 0;
            int coin_10 = 0;
            int coin = 0;
            
                coin_500 = money / 500;
                coin_100 = (money % 500) / 100;
                coin_50 = ((money % 500) % 100) / 50;
                coin_10 = (((money % 500) % 100) % 50) / 10;
                coin = (((money % 500) % 100) % 50) % 10;
                Console.WriteLine("----------------------------");
                Console.WriteLine("  동전 교환기 프로그램 1.0");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"500원 갯수 : {coin_500}개");
                Console.WriteLine($"100원 갯수 : {coin_100}개");
                Console.WriteLine($"50원 갯수 : {coin_50}개");
                Console.WriteLine($"10원 갯수 : {coin_10}개");
                Console.WriteLine($"바꾸지 못한 잔돈 : {coin}개");
                Console.WriteLine("----------------------------");
            
        }
    }
}
