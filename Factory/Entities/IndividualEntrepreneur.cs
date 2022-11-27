using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Factory.Entities
{
    public class IndividualEntrepreneur : IBook
    {
        // Поля класса
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        // Конструктор класса
        public IndividualEntrepreneur(string n, string num)
        {
            CompanyName = n;
            PhoneNumber = num;
        }
        // Реализация метода интерфейса IBook Message()
        public void Message()
        {
            Console.Write("Enter your message: ");
            string Message = Console.ReadLine();
            Console.WriteLine("Message with content: \n" +
            "\"{0}\" \n" +
                "was sent to {1} administator", Message, CompanyName);
        }
        // Реализация метода интерфейса IBook Call()
        public void Call()
        {
            Console.WriteLine("Calling {0} administation by number {1}", CompanyName, PhoneNumber);
        }
        // Реализация метода интерфейса IBook Info()
        public string Info()
        {
            return "Current subscriber info is: \n" +
                    "Number: " + PhoneNumber + "\n" +
                    "Name: " + CompanyName + "\n";
        }
    }
}
