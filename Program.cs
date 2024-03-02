using System;

public class MainBlockHomeWork {
    static void PrintArray(string[] array)
    {
        foreach (var item in array)
        {
            if (item.Length<4) Console.WriteLine(item);
        }
    }

    static public void Main(string[] args) {
        string[] inputArray = ["1234", "1567", "-2", "computer science"];
        
        PrintArray(inputArray);
    }
}