using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Entities
{
    public class Individual : IBook
    {
        // Поля класса
        public string Name { get; set; }
        public string Number { get; set; }
        // Конструктор класса
        public Individual(string n, string num)
        {
            Name = n;
            Number = num;
        }
        // Реализация метода интерфейса IBook Call()
        public void Call()
        {
            Console.WriteLine("Calling {0} on number {1}", Name, Number);
        }
        // Реализация метода интерфейса IBook Message()
        public void Message()
        {
            Console.Write("Enter your message: ");
            string Message = Console.ReadLine();
            Console.WriteLine("Message with content: \n" +
                "\"{0}\" \n" +
                "was sent to {1}", Message, Name);
        }
        // Реализация метода интерфейса IBook Info()
        public string Info()
        {
            return "Current subscriber info is: \n" +
                "Number: " + Number + "\n" +
                "Name: " + Name + "\n";
        }
    }
}
