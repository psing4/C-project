using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandingmachine
{
    class Selector
    {
        int COKE = 600;
        int FANTA = 550;
        int WATER = 420;
        int COFFEE = 370;
        string D1 = "콜라";
        string D2 = "환타";
        string D3 = "커피";
        string D4 = "물";
        public void SelectDrink(int money, Money money1)
        {
            int sel;
            Changer changer = new Changer();
            Console.WriteLine("음료를 선택해 ");
            sel = int.Parse(Console.ReadLine());

            if (sel < 1 || sel > 4)
            {
                Console.WriteLine("오류 선택 1~4까지 선택");
                SelectDrink(money, money1);
            }
            else
            {
                switch (sel)
                {
                    case 1:
                        changer.ChangePay(money, COKE, D1, money1);
                        break;
                    case 2:
                        changer.ChangePay(money, FANTA, D2, money1);
                        break;
                    case 3:
                        changer.ChangePay(money, COFFEE, D3, money1);
                        break;
                    case 4:
                        changer.ChangePay(money, WATER, D4, money1);
                        break;
                    default:
                        Console.WriteLine("Switch error");
                        break;
                }
            }
        }
    }
}
