using System;
namespace Examole
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите сумму вклада = ");
            float a = float.Parse(Console.ReadLine());
            // Преобразуем строку в число
            Console.Write("Введите процент по вкладу = ");
            float b = float.Parse(Console.ReadLine());
            // Преобразуем строку в число
            Console.Write("Через год сумма на вкладе = {0:C2}", a + (a * (b / 100)));
            // Считаем и выводим на экран
            Console.ReadKey();
        }
    }
}