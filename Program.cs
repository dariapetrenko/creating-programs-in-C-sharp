/*Розробити код програми, яка виводить наступну інформацію: прізвище та ініціали студента, факультет, 
  спеціальність, форма навчання, група. Ввести код програми у середовищі програми Блокнот, зберегти дані.*/

using System; 

namespace LR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Петренко Д.Р."); 
            Console.WriteLine("ФІТ");
            Console.WriteLine("Інженерія програмного забезпечення");
            Console.WriteLine("Денна форма навчання");
            Console.WriteLine("Група 1-2");
            Console.ReadLine();

        }

    }

}