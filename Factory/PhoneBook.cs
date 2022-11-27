using Factory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    // Абстрактный создатель который потом будет делать нам экземрляры классов, в нём 2 параметра: Имя контакта и номер телефона
    public abstract class Creator
    {
        public abstract IBook GenerateSubscriber(string n, string num);
    }
    // Создатель Физ лица, который наследуется от абстрактного создателя
    public class IndividualCreator : Creator
    {
        // Перегружаем метод генерации так, что в последствии он будет возвращать новый экземпляр класса с передаваемыми параметрами
        public override IBook GenerateSubscriber(string n, string num)
        {
            Individual individual = new(n, num);
            return individual;
        }
    }
    // В точности всё то же самое что и выше, возвоащаемый объект - ИП
    public class BuisnessManCreator : Creator
    {
        public override IBook GenerateSubscriber(string n, string num)
        {
            IndividualEntrepreneur individualEntrepreneur = new(n, num);
            return individualEntrepreneur;
        }
    }
}
