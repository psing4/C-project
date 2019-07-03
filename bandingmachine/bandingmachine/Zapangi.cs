using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandingmachine
{
    class Zapangi
    {

        static void Main(string[] args)
        {
            string exit;
            
            //int money;
            //int t_money =0 ;
            Console.WriteLine("자판기 입니다. 음료를 고르세요.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1콜라(600), 2환타(550), 3커피(370), 4물(420" );
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            //money = 0;
            
            Selector selector = new Selector();
            Changer changer = new Changer();
            Money money = new Money();
           
            while (true)
            {
                if (money.getMoney() == 0)
                {
                    money.setMoney(changer.inputCoin(money)); //돈을 넣는다. 
                }
                
                selector.SelectDrink(money.getMoney(), money);//돈으로 고른다. 

                Console.WriteLine("추가 선택 할래?(y/n) ");
                exit = Console.ReadLine();
                //changer.money = changer.t_money;
                
                money.setMoney(money.getTMoney());
                Console.Write("현재 돈"+money.getMoney());
                if(exit=="n" || exit == "N")
                {
                    Console.WriteLine("음료 선택 종료");
                    break;
                }
                Console.WriteLine();


            }
        }



    }
}
