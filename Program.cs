using System;

public class MainBlockHomeWork {
    static void PrintArray(string[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }

    static public void Main(string[] args) {
        string[] inputArray = ["1234", "1567", "-2", "computer science"];
        //Поскольку цитата "не рекомендуется использовать коллекции",
        //а массивы статические, поэтому создаём выходной массив таким
        //же размером как и входной
        string[] outputArray = new string[inputArray.Length];
        int outputArrayIndex=0;
        foreach (var item in inputArray)
        {
            if (item.Length<4) {
                outputArray[outputArrayIndex]=item;
                outputArrayIndex++;
            }
        }
        Console.Write("Исходный массив: ");
        PrintArray(inputArray);
        Console.Write("Результирующий массив: ");
        PrintArray(outputArray);
    }
}