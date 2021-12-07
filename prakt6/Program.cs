using System;

namespace prakt6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vp = {"Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
            Console.Write("Введите номер месяца (0 - 12)");
            Console.Write("Голубое Сало");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}", vp[i]);
                if (i == 0) Console.WriteLine("31 день в месяце");
                if (i == 1) Console.WriteLine("28 дней в месяце");
                if (i == 2) Console.WriteLine("31 день в месяце");
                if (i == 3) Console.WriteLine("30 дней в месяце");
                if (i == 4) Console.WriteLine("31 день в месяце");
                if (i == 5) Console.WriteLine("30 дней в месяце");
                if (i == 6) Console.WriteLine("31 день в месяце");
                if (i == 7) Console.WriteLine("31 день в месяце");
                if (i == 8) Console.WriteLine("30 день в месяце");
                if (i == 9) Console.WriteLine("31 день в месяце");
                if (i == 10) Console.WriteLine("30 и 7 недель дней в месяце");
                if (i == 11) Console.WriteLine("31 день в месяце");

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: выход индекса за пределы диапазона");
            }
        }
    }
}
