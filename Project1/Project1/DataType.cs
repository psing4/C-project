using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class DataType
    {
        /*
         *  데이터 타입 
         *  .net    c++
         *  int32   int 
         *  int64   long
         *  double  double
         *  single  float  
         *  char    char
         *  string  string
         *  boolean boool
         */

        string year = "2019";
        string month = "07";
        string day = "01";
        public void test()
        {
            int iYear = System.Convert.ToInt32(year); // 형변환 !!!!! 
            Console.WriteLine("============================== date type=========================");
            Console.WriteLine(iYear+20);
            object myDT = System.DateTime.Now;
            Console.WriteLine(System.Convert.ToString(myDT));

            //var : 데이터 타입은 데이터의 자동 형변환이 일어남
        }
        
        
    }
}
