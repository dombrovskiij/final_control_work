/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 сиимвола. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */

void GetArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array1, string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]}\t ");
    }
}

string[] arrayOne = new string[] { "hello", "2", "world", ":-)" };
string[] resultOne = new string[arrayOne.Length];

GetArray(arrayOne, resultOne);
PrintArray(arrayOne, resultOne);

// проверяю сразу все примеры, чтобы не перебивать их по очереди

Console.WriteLine();

string[] arrayTwo = new string[] { "1234", "1567", "-2", "computer science" };
string[] resultTwo = new string[arrayTwo.Length];

GetArray(arrayTwo, resultTwo);
PrintArray(arrayTwo, resultTwo);

Console.WriteLine();

string[] arrayThree = new string[] { "Russia", "Denmark", "Kazan" };
string[] resultThree = new string[arrayThree.Length];

GetArray(arrayThree, resultThree);
PrintArray(arrayThree, resultThree);