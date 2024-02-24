using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneList_Slot2
{
    public abstract class Phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string newphone);
        public abstract void SearchPhone(string name);
        public abstract void DisplayPhoneList();
        public abstract void Sort();
    }
}
