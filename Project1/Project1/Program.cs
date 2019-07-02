using System; // using == c에서 #include stdio와 동일 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(String[] args)//svm 텝텝 
        {
            Console.WriteLine("Hello"); // System.생략됨 
            //System : 시스템 기본 네임 스페이스 (클래스의 묶음)
            //Console : 클래스
            //WriteLine : 메소드 
            // namespace -> class -> 메소드 
            // namespace -> 어디에 속해 있는지 알려주는 것 
            // 메모리 걱정 안해도 됨 
            //cw 탭탭 Console.WriteLine
            string str = "123";
            Console.WriteLine(str);
            str = str + 456;
            Console.WriteLine(str);
            Console.WriteLine("결과값:"+ 1+2+1); //문자 + 숫자 -> 문자 
            Console.WriteLine(1+1+"1");//숫자 + 문자 => 숫자 + 문자
            Console.WriteLine(1 + "1" +1);//숫자 + 문자 + 숫자  => 문자 
            Console.WriteLine('1' + '1' + '1');//' ' 아스키 코드 
            Console.WriteLine( '1'); // 문자 1개 -> 문자 


            Console.WriteLine("abc\bads"); //\b는 백스페이스
            /*
             statement 구조 
             토큰 : 의미를 가진 최소한의 단위
             토큰 -> 스테이트먼트
             */
            Console.WriteLine("금액1:{0:C}\t금액2 {1:C}",1111000000,2020);//단위표쉬 
            Console.WriteLine("{0:G}",123);

            //시간에 관련된 것 
            Console.WriteLine("{0:D}",System.DateTime.Now);//d는 짧게 D는 길게 년일월 
            Console.WriteLine("{0:d}", System.DateTime.Now);//d는 짧게 D는 길게 

            Console.WriteLine("{0:T}", System.DateTime.Now);//t는 짧게 T는 길게 시간 

            Console.WriteLine("{0:f}", System.DateTime.Now);//f는 짧게 F는 길게 년월일 시간 

            Console.WriteLine("{0:R}", System.DateTime.Now);//r은 영어로 24시간 형태

            Console.WriteLine("{0:s}", System.DateTime.Now);//

            Console.WriteLine("{0:u}", System.DateTime.Now);//

            Console.WriteLine("{0:U}", System.DateTime.Now);//

            Console.WriteLine(System.DateTime.Now.AddMonths(6));
            //{0:E}지수 {1:C}단위 {2:D} {0,20:N}//0 ~ 20칸 \를 제외한 금액


            ArrrayExample arr2 = new ArrrayExample();




        }
    }
}
