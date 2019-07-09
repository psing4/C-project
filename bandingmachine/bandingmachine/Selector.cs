using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandingmachine
{
    class Selector
    {
        //메뉴판
        readonly private int COKE = 600;
        readonly private int FANTA = 550;
        readonly private int WATER = 420;
        readonly private int COFFEE = 370;
        string D1 = "콜라";
        string D2 = "환타";
        string D3 = "커피";
        string D4 = "물";



        public void SelectDrink(int money, Money money_class)
        {
            //음료를 선택하세요
            int sel;
            Changer changer = new Changer();
            DrinkDAO drinkDAO = new DrinkDAO();
            Console.Write("음료를 선택해 주세요 :");
            sel = int.Parse(Console.ReadLine());

            if (sel < 1 || sel > 4) //1~4 까지 선택 
            {
                Console.WriteLine("오류 선택 1~4까지 선택");
                SelectDrink(money, money_class);
            }
            else
            {
                switch (sel)
                {
                    case 1:
                        changer.ChangePay(money, COKE, D1, money_class);
                   

                        break;
                    case 2:
                        changer.ChangePay(money, FANTA, D2, money_class);

                        break;
                    case 3:
                        changer.ChangePay(money, COFFEE, D3, money_class);

                        break;
                    case 4:
                        changer.ChangePay(money, WATER, D4, money_class);

                        break;
                    default:
                        Console.WriteLine("Switch error");
                        break;
                }
            }
        }
    }
}
