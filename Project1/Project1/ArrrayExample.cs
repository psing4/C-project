using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ArrrayExample
    {
        public ArrrayExample()
        {
            //for each 반복문을 많이 사용한다. -> 컬렉션에 쉽게 적용할때 사용 
            //컬렉션 : 여러개체가 모여 집합을 이루는 것 
            //foreach(자료형 변수 in 컬랙션){}
            string[] arr = { "사과", "포도", "딸기", "수박", "바나나" };
            for(int i =0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]); 
            }

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
            //dangling else -else가 가장 가까운 if에 
            /*ex) 
             *    a=3, b=5
             *    if(a>3)
                    if(a>5) 출력 a
                  else 출력 b
            */
            for(int i=1; i<=5; i++)
            {
                for (int k=5-i; k >0;k-- )
                {
                    Console.Write(" ");
                }
               
                for(int j=1; j<=2*i-1; j++)
                {
                    if (j==1 || j == 2 * i - 1)
                    {Console.Write("*"); }
                    else
                    Console.Write(" ");



                }
                Console.WriteLine("\n");
            }
            for (int i = 1; i <=5 ; i++)
            {
                for (int k = 1; k <=i ; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * (5-i) - 1; j++)
                {
                    if (j == 1 || j == 2 * (5 - i) - 1)
                    { Console.Write("*"); }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
