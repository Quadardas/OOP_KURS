using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS
{
    public class TypeServices
    {
        string Type;
        public TypeServices(string Type)
        {
            this.Type = Type;
        }
        public string thisType
        {
            get { return this.Type; }
            set { this.Type = value is string ? value : null; }
        }
    }
}
