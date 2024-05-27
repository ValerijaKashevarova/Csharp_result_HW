// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = ReadInt("Введите значение М: ");
    int N = ReadInt("Введите значение N, которо должно быть больше M: ");
    if (N > M)
        PrintNumbers(M, N);
    else
        System.Console.WriteLine("Введен некорректный диапазон, вычисления невозможны!");
    
}

Main();

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int M, int N)
{
    if(N < M) return;
    PrintNumbers(M, N - 1);
    System.Console.Write(N + " ");
}