using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandingmachine
{
    class Changer
    {
        //public static int money;
        //public static int t_money =0 ;
        public int inputCoin(Money money)
        {
      
            Console.WriteLine("금액을 입력해");
            money.setMoney( int.Parse(Console.ReadLine())); //돈 받기 
            money.setMoney(money.getMoney() + money.getTMoney());
            money.setTMoney(money.getMoney());
            
            return money.getMoney();
        }
        public void ChangePay(int money, int s, string drink, Money money1)
        {
            int temp;
            int m_1000, m_500, m_100, m_50, m_10;
            string sel;
            
            Changer changer = new Changer();
            

            Selector selctor = new Selector(); 
            if (money < s)
            {
                Console.WriteLine("오류 money < drink");

                Console.WriteLine((s - money) + "원 부족합니다.");
                Console.WriteLine("금액을 더 넣을까? y/n");
                sel = Console.ReadLine();
                if (sel == "Y" || sel == "y")
                {
                    inputCoin(money1);
                }
                else if (sel == "N" || sel == "n")
                {
                    Console.WriteLine("자판기 종료");
                    Environment.Exit(0);
                }
                else
                    selctor.SelectDrink(money, money1);

            }
            else
            {
                money -= s;
                
                m_1000 = money / 1000;  // 1000 
                temp = money % 1000;
                m_500 = temp / 500;     // 500
                temp = temp % 500;
                m_100 = temp / 100;     // 100
                temp = temp % 100;
                m_50 = temp / 50;     // 100
                temp = temp % 50;
                m_10 = temp / 10;       // 10

                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("뽑은 음료수는" + drink + "이며 거스름돈은" + money + "원이다.");
                Console.WriteLine("1000원" + m_1000);
                Console.WriteLine("500원" + m_500);
                Console.WriteLine("100원" + m_100);
                Console.WriteLine("50원" + m_50);
                Console.WriteLine("10원" + m_10);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("거스름돈 : "+money);

                money1.setTMoney(money);



            }



        }
    }
}
