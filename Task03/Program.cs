// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
void Main()
{
    int[] tempMatrix = {2, 4};
    CrossPrintArray(tempMatrix, 0);
}

Main();

void CrossPrintArray(int[] array, int i)
{
    if (i >= array.Length) return;
    CrossPrintArray(array, i++);
    System.Console.WriteLine(array[i] + "");
}
