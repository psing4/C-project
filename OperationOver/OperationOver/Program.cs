using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOver
{
    class Point
    {
        private int x, y;
        public Point()
        {
            Console.WriteLine("파라미터가 0인 생성자");
        }
        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
        public void Show()
        {
            Console.WriteLine(
                "x={0}, y={1}", x, y);
        }
        public static Point operator +(Point pf, Point ps) //연산자 함수를 만듬 
        {
            Point temp =
              new Point(pf.x + ps.x, pf.y + ps.y);
            return temp;
        }
        public static string operator +(string pf, Point ps) //연산자 매개변수를 바꿔서 중복을 만들수 있다.
        {
            string a = pf + ps.x.ToString();
            return a;
        }
        // object 파일에서 상속받아서 변경하여 쓴다. 
        public static Point operator -(Point a, Point b) // 연산자 중복함수 -> c#은 static 
        {
            Point point = new Point(a.x - b.x, a.y - b.y);
            return point;
        }
        public double distance()
        {
            double dist = (this.x * this.x) + (this.y + this.y);

            return dist;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);
            Point p3 = p1 + p2;
            Point p4 = p1 - p2;
            p4.Show();
            p3.Show();
            Console.WriteLine("ps x는 "+p3);
        }
    }
}


