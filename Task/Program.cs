//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Более лёгкий вариант решения задачи ) 
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void Leters (string[] arr)
{
    int k = 0 ;
    for(int i = 0 ;i < arr.Length;i++)
    {
        k = 0;
        foreach (char c in arr[i])
        {
            k++;
        }
        if(k < 4 ) Console.Write(arr[i] + " ");
    }
}

string[] array = { "Hello", "2", "World", ":-)" };
PrintArray(array);
Console.Write("---->");
Leters(array);