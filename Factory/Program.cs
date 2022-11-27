using System.ComponentModel;

namespace Factory
{
    internal class Program
    {
        static void Main()
        {
            // Делаем список контактов через List<>
            List<IBook> PhoneBook = new();
            // Экземпляр создателя физ лиц
            IndividualCreator individualCreator = new();
            // Экземпляр создателя ИП
            BuisnessManCreator buisnessManCreator = new();
            // Добавляем в список новые контакты через вызов создателей с методом генерации
            PhoneBook.Add(individualCreator.GenerateSubscriber("Ivan", "892245331234"));
            PhoneBook.Add(buisnessManCreator.GenerateSubscriber("OOO Bank", "88008885422"));
            PhoneBook.Add(individualCreator.GenerateSubscriber("Nelsn", "89222423421"));

            // Выводим список на экран
            foreach (IBook book in PhoneBook)
            {
                // Информация о контакте
                Console.WriteLine(book.Info());
                // Выбор действия (сообщение или отзвон)
                Console.WriteLine("Select your action: \n" +
                    "1. Call \n" +
                    "2. Message");
                // Записываем действие в переменную
                string yourAction = Console.ReadLine();
                // Учимся не писать if else где попало
                switch (yourAction)
                {
                    // Звоним
                    case "1":
                        book.Call();
                        break;
                    // Пишем
                    case "2":
                        book.Message();
                        break;
                    // Не читаем информацию на экране
                    default:
                        Console.WriteLine("Selected action does not exist");
                        break;
                }
                // Пробел в строке чтоб не слипалось всё подряд
                Console.WriteLine("");
            }
        }
    }
}