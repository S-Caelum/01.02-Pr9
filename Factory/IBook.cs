using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IBook
    {
        // Сюда загружам консольный вывод информации с сообщением о звонке
        public void Call();
        // Сюда прописываем функцию набора сообщения: записываем в переменную сообщение и выводим содержимое в оформленном виде
        public void Message();
        // Сюда передаём строку с информацией, которую потом выводим через консоль в методе Main()
        public string Info();
    }
}
