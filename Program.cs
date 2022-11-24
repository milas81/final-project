/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

void PrintArray(string[] inArray)
{
    Console.Write("[");
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"\"{inArray[i]}\"");
        if(i != inArray.Length - 1) 
        {
            Console.Write(", ");        
        }
    }
    Console.WriteLine("]");
}

string[] FilterArray(string[] inArray)
{
    int newArrLen = 0;
    foreach (string s in inArray)
    {
        if (s.Length <= 3)
        {
            newArrLen ++;
        }
    }
    string[] result = new string[newArrLen];
    int i = 0;
    foreach (string s in inArray)
    {
        if (s.Length <= 3)
        {
            result[i] = s;
            ++i;
        }
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите массив строк с разделением пробелами:");
string str = Console.ReadLine();

string[] textArray = str.Split(" ").Where(item => !String.IsNullOrEmpty(item)).ToArray();
Console.Write("Исходный массив: ");
PrintArray(textArray);
Console.Write("Результат: ");
PrintArray(FilterArray(textArray));


