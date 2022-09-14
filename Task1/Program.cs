
int size = 5;
int[] arrey = GetArray(size);
int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

Console.WriteLine($"[ {String.Join("\t", arrey)} ]");
Console.WriteLine(sortArrey(arrey, size));

int sortArrey(int[] arrey, int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (arrey[i] % 2 == 0)
            count++;
    }
    return count;
}