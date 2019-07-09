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
        public int inputCoin(Money money_class)
        {
      
            Console.Write("금액을 입력해 주세요 :");
            money_class.setMoney( int.Parse(Console.ReadLine())); //돈 받기 
            money_class.setMoney(money_class.getMoney() + money_class.getTMoney());//temp 머니랑 더해서 현재 돈이랑 더한다.
            money_class.setTMoney(money_class.getMoney());//자판기에 들어가는 돈 추가 
            
            return money_class.getMoney();
        }
        public void ChangePay(int money, int s, string drink, Money money_class)
        {
            int temp;
            int m_1000, m_500, m_100, m_50, m_10;
            string sel;

            Selector selctor = new Selector();
            DrinkDAO drinkDAO = new DrinkDAO();
            if (money < s)
            {
                Console.WriteLine("오류 money < drink");

                Console.WriteLine((s - money) + "원 부족합니다.");
                Console.WriteLine("금액을 더 넣을까? y/n");
                sel = Console.ReadLine();
                if (sel == "Y" || sel == "y")
                {
                    inputCoin(money_class);
                }
                else if (sel == "N" || sel == "n")
                {
                    Console.WriteLine("자판기 종료");
                    drinkDAO.panmae_print();
                    Console.WriteLine("거스름돈 : {0}", money_class.getMoney());
                    Environment.Exit(0);
                }
                else
                    selctor.SelectDrink(money, money_class);

            }
            else
            {
                money -= s; //현재 남은 돈 (계산한 돈) 
                
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
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("뽑은 음료수는" + drink + " 이며 거스름돈은 " + money + " 원이다.");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("1000원" + m_1000);
                Console.WriteLine("500원" + m_500);
                Console.WriteLine("100원" + m_100);
                Console.WriteLine("50원" + m_50);
                Console.WriteLine("10원" + m_10);
                Console.WriteLine("------------------------------------------------------");
                if(drink == "콜라")
                {
                    Console.WriteLine("test");
              
                    DrinkDAO.panmae(1);
                }
                else if (drink == "환타")
                {
                    
                    DrinkDAO.panmae(2);
                }
                else if (drink == "커피")
                {
                  
                    DrinkDAO.panmae(3);
                }
                else if (drink == "물")
                {
                 
                    DrinkDAO.panmae(4);
                }


                money_class.setTMoney(money); //잔돈 money 개체에 추가 



            }



        }
    }
}
