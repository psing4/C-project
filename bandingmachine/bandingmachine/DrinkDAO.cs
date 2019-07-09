using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandingmachine
{
    class DrinkDAO
    {
        static int[] suryang = new int[4];

        public static void panmae(int choice)
        {
            switch (choice)
            {
                case 1:
                    suryang[0] += 1;
                    break;
                case 2:
                    suryang[1] += 1;
                    break;
                case 3:
                    suryang[2] += 1;
                    break;
                case 4:
                    suryang[3] += 1;
                    break;

                default:

                    break;
            }


        }
        public void panmae_print()
        {
             
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("음료수의 판매 수량은 콜라 : " + suryang[0] + ", 환타 : " + suryang[1] +
                                                      ", 커피 : " + suryang[2] + ", 물 : " + suryang[3]);
            
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
    }
}
