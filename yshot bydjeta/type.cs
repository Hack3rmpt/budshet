using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yshot_bydjeta
{
    internal class type
    {
        public string name { get; set; }
        public string tipe { get; set; }

        public int money { get; set; }
        public bool money_income { get; set; }

        public string date;

        public type(string name_, string type_, int money_, bool money_zp_, string date_)
        {
            name = name_;
            tipe = type_;
            money = money_;
            money_income = money_zp_;
            date = date_;
        }

        
    }
}
