using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneList_Slot2
{
    public class PhoneBook : Phone
    {
        private List<(string name, string phone)> PhoneList = new List<(string, string)>();

        public override void InsertPhone(string name, string phone)
        {
            // Kiểm tra xem tên đã tồn tại trong danh sách chưa
            bool exists = false;
            for (int i = 0; i < PhoneList.Count; i++)
            {
                if (PhoneList[i].name == name)
                {
                    exists = true;
                    if (PhoneList[i].phone != phone)
                    {
                        PhoneList[i] = (name, phone);
                        Console.WriteLine($"Updated phone number for {name}.");
                    }
                    break;
                }
            }

            // Nếu tên chưa tồn tại, thêm mới vào danh sách
            if (!exists)
            {
                PhoneList.Add((name, phone));
                Console.WriteLine($"Inserted new contact: {name} - {phone}.");
            }
        }

        public override void RemovePhone(string name)
        {
            PhoneList.RemoveAll(x => x.name == name);
            Console.WriteLine($"Removed contact: {name}.");
        }

        public override void UpdatePhone(string name, string newphone)
        {
            for (int i = 0; i < PhoneList.Count; i++)
            {
                if (PhoneList[i].name == name)
                {
                    PhoneList[i] = (name, newphone);
                    Console.WriteLine($"Updated phone number for {name}.");
                    break;
                }
            }
        }

        public override void SearchPhone(string name)
        {
            var result = PhoneList.Find(x => x.name == name);
            if (result.name != null)
            {
                Console.WriteLine($"Found {result.name}: {result.phone}");
            }
            else
            {
                Console.WriteLine($"Contact {name} not found.");
            }
        }

        public override void Sort()
        {
            PhoneList.Sort((x, y) => x.name.CompareTo(y.name));
            Console.WriteLine("Phone book sorted by name.");
        }
        public override void DisplayPhoneList()
        {
            Console.WriteLine("Phone List:");
            foreach (var contact in PhoneList)
            {
                Console.WriteLine($"{contact.name}: {contact.phone}");
            }
        }
    }
}
