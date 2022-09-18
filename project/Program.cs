/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
Примеры: ["hello", "2", "world", ":-)"] -> ["2", ":-)"] 
["1234", "1567", "-2", "computer science"] -> ["-2"] ["Russia", "Denmark", "Kazan"] -> []*/
const int LIMIT = 3;
string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };
string[] array2 = new string[array.Length];
string[] FillArray(string[] array)
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= LIMIT)
        {
        array2[count] = array[i];
        count++;
        }
    }
    return array2;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine("Имеющийся массив: " );
PrintArray(array);
FillArray(array);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(array2);