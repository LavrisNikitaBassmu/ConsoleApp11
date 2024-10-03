using System;

class CalculateFormulas
{
    static void Main(string[] args)
    {
        // Определение формул и их параметров
        double R, s, x, a, b;

        // Определение областей допустимых значений параметров
        // x, a, b - действительные числа в диапазоне [-10, 10]
        x = 2.0; // произвольное значение из диапазона [-10, 10]
        a = 3.0; // произвольное значение из диапазона [-10, 10]
        b = 4.0; // произвольное значение из диапазона [-10, 10]

        // Вычисление формул
        R = Math.Pow(x, 2) * (x + 1) / b - Math.Pow(Math.Sin(x + a), 2);
        s = Math.Sqrt(x * b / a) + Math.Pow(Math.Cos(Math.Pow(x + b, 3)), 2);

        // Вывод результатов на экран
        Console.WriteLine("R = " + R);
        Console.WriteLine("s = " + s);
    }
}