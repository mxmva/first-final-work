Console.WriteLine("Введите массив. Сколько элементов в массиве Вам необходимо?");
int countElements = int.Parse(Console.ReadLine() ?? "0");
string[] fristArray = new string[countElements];

string[] FillArray(string[] array)
{
    for (int i = 0; i < countElements; i++)
    {
        Console.WriteLine($"Введите {i} элемент:");
        array[i] = Console.ReadLine() ?? "0";
    }
    return array;
}

string[] SortArray(string[] array)
{
    int necessaryValue = 0;
    string arrayValue = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= 3) necessaryValue++;
    }

    string[] secondArray = new string[necessaryValue];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        arrayValue = array[i];
        if (arrayValue.Length <= 3)
        {
            secondArray[index] = array[i];
            index++;
        }
    }
    return secondArray;
}

void PrintArray(string[] array)
{
    if (array.Length == 0) Console.WriteLine("Введите количество элементов массиво отличное от нуля!");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" [{array[i]}]");
    }
}



FillArray(fristArray);
string[] secondArray = SortArray(fristArray);
Console.WriteLine("Первоначальный массив: ");
PrintArray(fristArray);
Console.WriteLine();
Console.WriteLine("Новый массив: ");
PrintArray(secondArray);
