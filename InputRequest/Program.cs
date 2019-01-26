using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, patronymic;
            Console.WriteLine("Введите свои фамилию, имя и отчество.");
            Console.Write("Введите фамилию:");
            surname = Console.ReadLine();
            Console.Write("Введите имя:");
            name = Console.ReadLine();
            Console.Write("Введите отчество:");
            patronymic = Console.ReadLine();
            Console.WriteLine(surname + " " + name + " " + patronymic);
        }
    }
}
