using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Caculater
    {
        public void test2()
        {
            Console.WriteLine("double: " + sizeof(double));
            //삼항 연산자 (조건) ? 참 : 거짓 

            string input = "hello";
            //string readLine  = Console.ReadLine();
            //int num = int.Parse(readLine);
            //Console.WriteLine(num >0 ? "자연수" : "이외의 수 ");

            int[] arr = { 1, 2, 3, 4, 5 };
            // int arr [] = {1, 2, 3, 4} 안됨 ㅜㅜ 
            float[] arf = { 1.1f, 1.2f, 1.3f, 1.4f };//f를 다 붙여야함 

            Console.WriteLine(arr.Length);//갯수 

            if(DateTime.Now.Hour<12)
            {
                Console.WriteLine("오전 공부");
            }
            else if (DateTime.Now.Hour<14)
            {
                Console.WriteLine("점심시간");
            }
            else if(DateTime.Now.Hour<18)
            {
                Console.WriteLine("오후공부");
            }
            string day = Console.ReadLine();
            int iDay = int.Parse(day);
            if (iDay > 31)
            {
                Console.WriteLine("잘못입력");
            }
            else
            {

                switch (iDay%7)
                {
                    case 1:
                        Console.WriteLine("월요일");
                        break;
                    case 2:
                        Console.WriteLine("화요일");
                        break;
                    case 3:
                        Console.WriteLine("수요일");
                        break;
                    case 4:
                        Console.WriteLine("월요일");
                        break;
                    case 5:
                        Console.WriteLine("화요일");
                        break;
                    case 6:
                        Console.WriteLine("수요일");
                        break;



                    default:
                        Console.WriteLine("일요일");
                        break;

                       
                }
            }
          
          
        }
    }
}
