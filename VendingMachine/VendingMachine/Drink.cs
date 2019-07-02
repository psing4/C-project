using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Drink
    {
        int[]drink_money;
        string []drink_name;
        int index; 

        public Drink(int drink_num)
        {
            this.index = drink_num;
        }
        public void menu()
        {
            Dictionary<string, int> drink_menu = new Dictionary<string, int>();
            drink_menu.Add("콜라", 1000);
        }
    }
}
