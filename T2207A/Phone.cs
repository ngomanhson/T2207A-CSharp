using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public abstract class Phone
    {
        public Phone() { }

        public abstract void insertPhone(string name, string phone);
        public abstract void RemovePhone(string name);

        public abstract void UpdatePhone(string name, string newphone);
        public abstract void SearchPhone(string name);
        public abstract void Sort();

       
    }
}
