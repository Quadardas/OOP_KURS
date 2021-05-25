using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS
{
    public class Services : TypeServices
    {
        int Price;
        string NameS;

        public Services(int Price, string NameS, string type) : base(type)
        {
            this.Price = Price;
            this.NameS = NameS;
        }

        public int thisPrice
        {
            get { return this.Price; }
            set { this.Price = value; }
        }
        public string thisNameS
        {
            get { return this.NameS; }
            set { this.NameS = value is string ? value : null; }
        }
    }
}
