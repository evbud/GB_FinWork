string[] array = FillArray();

Console.Write($"[{String.Join(", ", array)}]");

Console.WriteLine("\nИз заданного массива строк программа формирует массив из строк, длина которых меньше либо равна 3 символа:");

Console.Write($"[{String.Join(", ", EditArray(array, 3))}]");

string[] FillArray()
{
    Console.WriteLine("Введите через пробел значения элементов массива: ");
    string arrVal = Console.ReadLine();

    string[] array = arrVal.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    return array;
}

int CountElLessN(string[] array, int n)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n) count++;
    }
    return count;
}

string[] EditArray(string[] array, int n)
{
    string[] arrayEdited = new string[CountElLessN(array, n)];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            arrayEdited[j] = array[i];
            j++;
        }
    }
    return arrayEdited;
}