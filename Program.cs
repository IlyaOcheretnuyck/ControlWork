// Задача: Написать программу, 
// которая из имеющегося массива строк 
// формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Console.Clear();
// Console.WriteLine("Введите текст:\t");
// string userText = Console.ReadLine();
string[] textArray = new string[4]{"1234", "156", "-2", "computer science"};
string[] overText = SearchTreeSymbol(textArray);
OutputArray(overText);

string[] SearchTreeSymbol(string[] array)
{
    int count = 0;
    foreach(string word in array)
    {
        if(word.Length <= 3)
        {
            count++;
        }
    }

    int j = 0;
    string[] newTextArray = new string[count];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newTextArray[j] = array[i];
            j++;
        }
    }
    return newTextArray;

}

void OutputArray(string[] over)
{
    Console.Write("[");
    for(int i = 0; i < over.Length-1; i++)
    {
        Console.Write($"{over[i]}, ");
    }
    Console.Write($"{over[^1]}");
    Console.Write("]");
}