//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

string[] Words(string[] arr)
{
    string[] words =new string[1];
    string three_leters = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) three_leters += arr[i] + " ";
    }
    words[0] = three_leters;
    return words;
}
string[] array = { "Hello", "2", "World", ":-)" };
PrintArray(array);
string [] final_array = Words(array);
Console.Write("---->");
PrintArray(final_array);
