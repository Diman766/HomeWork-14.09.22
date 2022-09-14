// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 5;
int[] arrey = GetArray(size);
int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-10,11);
    }
    return arr;
}

Console.WriteLine($"[ {String.Join("\t", arrey)} ]");
Console.WriteLine($"\n"+sumOddNumbers(arrey,size));

int sumOddNumbers(int[] arrey, int size)
{
    int sum = 0;
    for (int i = 1; i < size; i += 2)
    {
        sum += arrey[i];
    }
    return sum;
}





