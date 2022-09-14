// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 5;
double[] arrey = GetArray(size);
double[] GetArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * 10, 1);
    }
    return arr;
}

Console.WriteLine($"[ {String.Join("\t", arrey)} ]");

Console.WriteLine(maxMin(arrey,size));

double maxMin(double[] arrey, int size)
{
    double min = arrey[0];
    double max = arrey[0];
        for (int i = 1; i < size; i++)
    {
        if (max < arrey[i]) max = arrey[i];
        if (min > arrey[i]) min = arrey[i];      
    }
    Console.WriteLine(max);
    Console.WriteLine(min);
    return (max-min);
}


