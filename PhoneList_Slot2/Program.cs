using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneList_Slot2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
                PhoneBook phoneBook = new PhoneBook();

                phoneBook.InsertPhone("John Doe", "123456789");
                phoneBook.InsertPhone("Jane Smith", "987654321");
                phoneBook.InsertPhone("John Doe", "987654321");

                phoneBook.SearchPhone("John Doe");
                phoneBook.SearchPhone("Jane Smith");

                phoneBook.RemovePhone("John Doe");

                phoneBook.Sort();
            PhoneBook PhoneBook = new PhoneBook();

            // Nhập thông tin và lưu vào danh sách điện thoại
            Console.WriteLine("Enter contact information:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Phone number: ");
            string phone = Console.ReadLine();

            phoneBook.InsertPhone(name, phone);

            // Hiển thị danh sách điện thoại sau khi thêm
            phoneBook.DisplayPhoneList();

            Console.ReadLine();
            }
        
    }
}
