using System;
// Имеется N клиентов, которым компания производитель должна доставить товар.
// Сколько существует возможных маршрутов доставки товара,
// с учетом того, что товар будет доставлять одна машина?
// Необходимо рассчитывать, и выводить на экран количество возможных вариантов доставки товара.
// Для решения задачи, используйте факториал N!, рассчитываемый с помощью рекурсии.

namespace Task_2
{
    class Program
    {
        /// <summary>
        /// Расчет количества возможных вариантов доставки.
        /// </summary>
        /// <param name="deliveryRoute">Колличество вариантов доставки</param>
        /// <returns></returns>
        static ulong Factorial(ulong deliveryRoute)
        {

            if (deliveryRoute == 0)
                return 1;
            else
                // Вызов метода из своего же тела.
                return deliveryRoute * Factorial(deliveryRoute - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите колличество точек доставки товара -  ");
            // Инициализация переменной deliveryPoint (точка доставки) типа ulong.
            ulong deliveryPoint = Convert.ToUInt32(Console.ReadLine());

            // В теле метода Main на 35 строке, вызываем метод Factorial,
            // который принимает значение колличества точек доставки.
            ulong deliveryRoute = Factorial(deliveryPoint);

            Console.WriteLine($"Количество возможных вариантов доставки товара составляет {deliveryRoute}");
            Console.ReadKey();
        }
    }
}
