using System;
// Создайте метод с именем Calculate, который принимает в качестве параметров
// три целочисленных значения и возвращает значение каждого аргумента деленного на 5. 

namespace Additional_task
{
    class Program
    {

        /// <summary>
        /// Деление каждого введенного числа на 5.
        /// </summary>
        /// <param name="argument1">Первое введенное число</param>
        /// <param name="argument2">Второе введенное число</param>
        /// <param name="argument3">Третье введенное число</param>
        static void Calculate(ref double argument1, ref double argument2, ref double argument3)
        {
            argument1 /= 5;
            argument2 /= 5;
            argument3 /= 5;
        }

        static void Main(string[] args)
        {
            // Инициализация переменных и ввод данных пользователем.
            Console.WriteLine("Введите три целочисленных числа");

            double argument1 = Convert.ToInt64(Console.ReadLine());

            double argument2 = Convert.ToInt64(Console.ReadLine());

            double argument3 = Convert.ToInt64(Console.ReadLine());

            // В теле метода Main на 36 строке, вызываем метод Calculate,
            // который принимает по ссылке значения трех аргументов с помощью ключевого слова ref.
            Calculate(ref argument1, ref argument2, ref argument3);

            Console.WriteLine($"Введенные числа после деления на 5 = {argument1}; {argument2}; {argument3}");

            Console.ReadKey();

        }
    }
}
