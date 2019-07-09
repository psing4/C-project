using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandingmachine
{
    class Screen
   
    {
        public void Screen_Start()
        {
            //객체 선언 및 지역 변수설정
            string exit;
            string sel;
            
            Selector selector = new Selector();
            Changer changer = new Changer();
            Money money_class = new Money();
            DrinkDAO drinkDAO = new DrinkDAO();

            //수행 화면 1 부분 
            Console.WriteLine("자판기 입니다. 음료를 고르세요.");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1. 콜라(600), 2. 환타(550), 3. 커피(370), 4. 물(420)");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine();


            while (true)
            {
                if (money_class.getMoney() == 0) //현재돈이 0원 이라면 
                {
                    money_class.setMoney(changer.inputCoin(money_class)); //돈을 넣는다. -> 돈을 더한다.
                }

                selector.SelectDrink(money_class.getMoney(), money_class);//돈으로 음료를 고른다.

                money_class.setMoney(money_class.getTMoney()); //잔액을 내 돈에 넣는다.
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("현재 돈" + money_class.getMoney());
                Console.WriteLine("------------------------------------------------------");
                if (money_class.getMoney()>=600)
                {
                    Console.WriteLine("현재 선택할수 있는 음료");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("1. 콜라(600), 2. 환타(550), 3. 커피(370), 4. 물(420)");
                    Console.WriteLine("------------------------------------------------------");

                }
                else if ((money_class.getMoney() >= 550))
                {
                    Console.WriteLine("현재 선택할수 있는 음료");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("2. 환타(550), 3. 커피(370), 4. 물(420)");
                    Console.WriteLine("------------------------------------------------------");
                }
                else if ((money_class.getMoney() >= 420))
                {
                    Console.WriteLine("현재 선택할수 있는 음료");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("3. 커피(370), 4. 물(420)");
                    Console.WriteLine("------------------------------------------------------");
                }
                else if ((money_class.getMoney() >= 370))
                {
                    Console.WriteLine("현재 선택할수 있는 음료");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("3. 커피(370)");
                    Console.WriteLine("------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("현재 돈으로 살수 있는 음료가 없어요");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("돈을 더 넣을래요? Y|N");
                    Console.WriteLine("------------------------------------------------------");
                    sel = Console.ReadLine();
                    if (sel == "Y" || sel == "y")
                    {
                        changer.inputCoin(money_class);

                    }
                    else if (sel == "N" || sel == "n")
                    {
                        Console.WriteLine("자판기 종료");
                        drinkDAO.panmae_print();
                        Console.WriteLine("거스름돈 : {0}", money_class.getMoney());
                        Environment.Exit(0);
                    }
                }
                Console.WriteLine("추가 선택 할래?(y/n) ");
                exit = Console.ReadLine();//추가 선택하지를 정한다.

                
                
                if (exit == "n" || exit == "N")
                {
                    Console.WriteLine("음료 선택 종료");
                    drinkDAO.panmae_print();
                    Console.WriteLine("거스름돈 : {0}",money_class.getMoney());
                    break;
                }
                Console.WriteLine();


            }
        }
    }
}
