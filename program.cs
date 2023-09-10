// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 

// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] ChooseExampleArray(string [] Array1, string [] Array2, string [] Array3)
{
    
    Console.WriteLine("Chose example");
    Console.WriteLine("1: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine($"2: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine($"3: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine($"4: your own example");
    Console.WriteLine($"Input the number of your choice:");
    
    string [] chosenArray = {};
    int userChoice = Convert.ToInt32(Console.ReadLine());
    if (userChoice == 1)
        chosenArray = Array1;
    else if (userChoice == 2)
        chosenArray = Array2;
    else if (userChoice == 3)
        chosenArray = Array3;
    else if (userChoice == 4)
        chosenArray = InputYourExample ();
    else
    {
        while (userChoice > 4 || userChoice <= 0)
            {
                Console.WriteLine($"Choose between 1, 2, 3, and 4:");
                userChoice = Convert.ToInt32(Console.ReadLine());
            }
    }
    return chosenArray;
}

string [] InputYourExample()
{
    Console.Write("Input the number of elements in your array: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    while (arraySize <= 0)
    {
        Console.Write("Numner must be more than 0: ");
        arraySize = Convert.ToInt32(Console.ReadLine());
    }

    string [] userArray = new string[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.WriteLine($"Input your word №{i+1}:");
        userArray[i] = Console.ReadLine()!;
        while (userArray[i] == "")
        {
            Console.WriteLine("Try again:");
            userArray[i] = Console.ReadLine()!;
        }
    }
    return userArray;
}

void PrintArray(string [] arrayToPrint)
{
    int i = 0;
    if (arrayToPrint.Length == 1)
            Console.Write("[" + '"' + arrayToPrint[i] + '"' + "]");
    else if (arrayToPrint.Length == 0)
            Console.Write("[]");
    else
    {
        for (i = 0; i < arrayToPrint.Length; i++)
        {
            {
                if (i == arrayToPrint.Length - 1)
                    Console.Write('"' + arrayToPrint[i] + '"' + "]");
                else if (i == 0)
                    Console.Write("[" + '"' + arrayToPrint[i] + '"' + ", ");
                else
                    Console.Write('"' + arrayToPrint[i] + '"' + ", ");
            }
        }
    }
}

string [] ArrayCheck(string [] arrayToCheck)
{
    
    int count = 0;
    for (int i = 0; i < arrayToCheck.Length; i++)
    {
        if (arrayToCheck[i].Length <= 3)
                count ++;
    }
 
    string [] arrayAfterChecking = new string [count];
    int j = 0;
    for (int i = 0; i < arrayToCheck.Length; i++)
    {
        if (arrayToCheck[i].Length <= 3)
        {
            arrayAfterChecking[j] = arrayToCheck[i];
            j++;
        }
    }
    return arrayAfterChecking; 
}


string [] arrayToChoose1 = {"Hello", "2", "world", ":-)"};
string [] arrayToChoose2 = {"1234", "1567", "-2", "computer science"};
string [] arrayToChoose3 = {"Russia", "Denmark", "Kazan"};
string [] arrayFromUser = ChooseExampleArray(arrayToChoose1, arrayToChoose2, arrayToChoose3);
Console.Write("Your array is: ");
PrintArray(arrayFromUser);
string [] arrayFinal = ArrayCheck(arrayFromUser);
Console.WriteLine();
Console.Write("Your result is: ");
PrintArray(arrayFinal);
