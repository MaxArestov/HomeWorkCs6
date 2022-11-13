//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Введите целое число, обозначающее количество чисел в массиве:");
int m = GetNumber();
int[] arrayDigits = new int[m];
FillArray(arrayDigits);
PrintArray(arrayDigits);
int posNum = CountPositiveNumbers(arrayDigits);
Console.WriteLine($"Количество чисел больше нуля в массиве - {posNum}.");





int GetNumber()
{
    bool checkForDigit = true;
    int digit = 0;
    while (checkForDigit)
    {
        if (!int.TryParse(Console.ReadLine(), out digit))
        {
            Console.WriteLine("Введены некорректные данные. Введите целое число:");
        }
        else checkForDigit = false;
    }
    return digit;
}
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число на позиции {i}: ");
        array[i] = GetNumber();
        Console.WriteLine();
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int CountPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}