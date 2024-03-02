//8 вариант
using System;

class SeriesSum
{
    static void Main()
    {
        double sum = 0;
        double x;
        int n;
        Console.Write("Введите значение x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите количество членов ряда n: ");
        n = Convert.ToInt32(Console.ReadLine());


        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);
        }

        Console.WriteLine("Сумма ряда равна: " + sum);
    }
}
