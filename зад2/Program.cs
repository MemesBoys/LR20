namespace Examole
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значения\nВершины А - x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            // считываем значения
            Console.Write("Вершины B - x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            // считываем значения
            Console.Write("Вершины C - x3 = ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            double y3 = double.Parse(Console.ReadLine());

            var a = Math.Sqrt((Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2))));
            var b = Math.Sqrt((Math.Pow((x3 - x2), 2) + (Math.Pow((y3 - y2), 2))));
            var c = Math.Sqrt((Math.Pow((x3 - x1), 2) + (Math.Pow((y3 - y1), 2))));
            // Находим стороны
            var p = (a + b + c)/2;
            // находим полупериметр
            double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine("Площадь треугольника равна: {0:f2} ",S);
            // высчитываем и выводим площадь
            Console.ReadKey();
        }
    }
}