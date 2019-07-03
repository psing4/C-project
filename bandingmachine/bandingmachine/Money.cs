using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandingmachine
{
    class Money
    {
        private int money;
        private int t_money=0;

        public int getMoney()
        {
            return money;
        }
        public void setMoney(int money)
        {
            this.money = money;
        }
        public int getTMoney()
        {
            return t_money;
        }
        public void setTMoney(int t_money)
        {
            this.t_money = t_money;
        }

    }
}
