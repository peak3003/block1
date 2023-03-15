//Подпрограмма создания массива
string[] CreateArray(int x)
{
    string[] array = new string[x];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    Console.Clear();
    return array;
}

//Подпрограмма вывода на экран массива
void PrintArray(string[] a)
{
    for (int i = 0; i < a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();
}

//Подпрограмма создания нового массива по заданным данным
string[] NewArray(string[] array)
{
    int arrLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int k = 0;
        foreach (char s in array[i])
            k++;
        if (k <= 3)
            arrLength++;
    }
    string[] newArray = new string[arrLength];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int k = 0;
        foreach (char c in array[i])
            k++;
        if (k <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

//Основная программа
Console.Write("Введите кол-во элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] stringArray = CreateArray(N);
System.Console.Write("Первоначальный массив: ");
PrintArray(stringArray);
System.Console.WriteLine();
string[] newStr = NewArray(stringArray);
System.Console.Write("Новый массив: ");
PrintArray(newStr);
Console.ReadKey();

