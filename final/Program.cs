string[] CreateArray(int n)
{
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

int SortingArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArray(int count, string[] array)
{
    string[] arr = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[j] = array[i];
            j++;
        }
    }
    return arr;
}

Console.Write("Введите количество элементов в массиве ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = CreateArray(n);
int number = SortingArray(array);
string[] newArr = NewArray(number, array);
for (int i = 0; i < newArr.Length; i++)
    Console.Write(newArr[i] + "");
