// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.WriteLine("Введите точку b1:");
double k1 = GetNumber();
Console.WriteLine("Введите точку k1:");
double k2 = GetNumber();
Console.WriteLine("Введите точку b2:");
double b1 = GetNumber();
Console.WriteLine("Введите точку k2:");
double b2 = GetNumber();
double[] crossPoint = FindInterseptionPoint(k1, b1, k2, b2);
Console.WriteLine($"x = {crossPoint[0]}, y = {crossPoint[1]}");




double GetNumber()
{
    bool checkForDigit = true;
    double digit = 0.0;
    while (checkForDigit)
    {
        if (!double.TryParse(Console.ReadLine(), out digit))
        {
            Console.WriteLine("Введены некорректные данные. Введите целое число:");
        }
        else checkForDigit = false;
    }
    return digit;
}

double[] FindInterseptionPoint(double kx1, double bx1, double kx2, double bx2)
{
    double[] result = new double[2] {-999, -999};
    if ((kx1 * bx2) - (kx2 * bx1) == 0)
    {
        Console.WriteLine("Прямые параллельны и не имеют точек пересечения.");
    }
    else
    {
        result[0] = (bx2 - bx1) / (kx1 - kx2);
        result[1] = ((kx1 * (bx2 - bx1)) / (kx1 * (kx1 - kx2) + bx1));
        Console.Write("Прямые пересекаются в координатах ");
    }
    return result;
}