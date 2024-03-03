using System;

public class MainBlockHomeWork {
    static int Filled(string[] array) {
    //заменитель метода Length с учётом заполнения
        int counter = 0;
        foreach (var item in array)
        {
            if (item!=null) {
                counter++;
            } else break;
        }
        return counter;
    }

    static void PrintArray(string[] array)
    {
        for (int i = 0; i < Filled(array); i++)
                Console.Write(array[i]+" ");
        Console.WriteLine();
    }

    static public void Main(string[] args) {
        //Поскольку цитата: "не рекомендуется использовать коллекции",
        //а массивы статические, и мы не знаем, сколько значений введёт
        //пользователь, приходится возиться с null
        const bool _FromKeyboard = true;
        const int _ArrayLength = 1000;

        string[] inputArray = new string[_ArrayLength];
        string[] outputArray = new string[_ArrayLength];

        if (_FromKeyboard) {
            int arrayCounter = 0;
            string? value = "begin";
            Console.WriteLine("Введите значения через ENTER или пустое значение (просто ENTER) для окончания ввода:");
            while ((value!="")||(arrayCounter==_ArrayLength)) {
                value = Console.ReadLine();
                if ((value!="")&&(value!=null)) {
                    inputArray[arrayCounter]=value;
                    arrayCounter++;
                }
            }
        } else {
            //inputArray = ["1234", "1567", "-2", "computer science"];
            inputArray = ["Hello", "2", "world", ":-)"];
            //inputArray = ["Russia", "Denmark", "Kazan"];
        }

        int outputArrayIndex = 0;
        int inputArrayLength = Filled(inputArray); //чтобы не вызывать метод в каждоый итерации
        for (int i = 0; i < inputArrayLength; i++)
        {
            if (inputArray[i].Length<4) {
                outputArray[outputArrayIndex] = inputArray[i];
                outputArrayIndex++;
            }
        }

         Console.Write("Исходный массив: ");
         PrintArray(inputArray);
         Console.Write("Результирующий массив: ");
         PrintArray(outputArray);
  }
}