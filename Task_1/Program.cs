using System;
// Реализовать программу, которая помогает определить, погасил ли клиент кредит или нет.
// Ежемесячная сумма платежа должна составлять 100 грн. Клиент должен 
// выполнить 7 платежей, но может платить реже большими суммами.
// Т.е., может двумя платежами по 300 и 400 грн. закрыть весь долг. 
// Создайте метод, который будет в качестве аргумента принимать введенную сумму платежа, 
// Метод выводит на экран информацию о состоянии кредита (сумма задолженности,
// сумма переплаты, сообщение об отсутствии долга).

namespace Task_1
{
    class Program
    {
        /// <summary>
        /// Расчет состояния кредита.
        /// </summary>
        /// <param name="amountСredit">Сумма кредита</param>
        /// <param name="amountPayment">Сумма платежа </param>
        /// <returns> </returns>
        static void Сredit(decimal amountСredit, decimal amountPayment)
        {
            decimal creditStatus = amountСredit - amountPayment;

            if (creditStatus == 0)
            {
                Console.WriteLine($"Кредит погашен, задолженость отсутствует");
            }
            else if (creditStatus > 0)
            {
                Console.WriteLine($"Сумма задолжености составляет: {creditStatus}");
            }
            else
            {
                creditStatus *= -1;
                Console.WriteLine($"Сумма переплаты составляет:  {creditStatus}");
            }

        }
        static void Main(string[] args)
        {
            // Инициализация переменных и ввод данных пользователем.
            Console.Write("Введите суму кредита: ");
            decimal amountСredit = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите суму платежа: ");
            decimal amountPayment = Convert.ToDecimal(Console.ReadLine());

            // Инициализация константы minPayment(минимальный платеж) типа decimal.
            const decimal minPayment = 100;
            // Проверка суммы допустимого ежемесячного платежа.
            if (amountPayment < minPayment)
            {
                Console.WriteLine($"Введеная сума платежа меньше минимальной");
            }
            else
            {
                Сredit(amountСredit, amountPayment);
            }

            Console.ReadKey();
        }
    }
}
