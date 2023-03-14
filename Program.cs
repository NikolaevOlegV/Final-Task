// Написать программу, которая из имеющегося массива строкформирует массив из строк,
// длинна которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// Использовать исключительно массивы.

string[] InputArray(string userText)
{
    Console.WriteLine(userText);
    string[] arrayString = Console.ReadLine().Split(' ', ',');
    return arrayString;
}

string[] ArraySort(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    string[] newArray = new string[count];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }

    }
    return newArray;
}

void PrintArray(string[] array, string preOutputText, string postOutputText)
{
    Console.Write($"{preOutputText}");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}] ");
    }
    Console.WriteLine(postOutputText);
}


Console.Clear();
string[] array = InputArray("Введите количество слов через пробел или запятой: ");
PrintArray(array, "Исходный массив: ", "Выполняется сортировка...");
string[] newArray = ArraySort(array);
PrintArray(newArray, "Массив после обработки: ", "Задача выполнена.");


