using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List_Col
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
            phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));

            // проверяем, что добавилось в список
            foreach (var contact in phoneBook)
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
        }
    }

    public class Contact // модель класса
    {
        public Contact(string name, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}
    

