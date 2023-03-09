//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int[] sizes = ReadSizes();
int m = sizes[0];
int n = sizes[1];

int[,] arr = FillArray(m, n);

PrintArray(arr);

int[] pos = ReadPosition(m, n);

int element = GetElement(arr, pos);
if (element == int.MinValue)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("There is no such element in the array.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Element value: " + element);
}

static int[] ReadSizes()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Enter the dimensions of the array (separated by a space): ");

    string[] input = Console.ReadLine().Split();
    int m = int.Parse(input[0]);
    int n = int.Parse(input[1]);
    return new int[] { m, n };
}

static int[,] FillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)    
        for (int j = 0; j < arr.GetLength(1); j++)        
            arr[i, j] = rnd.Next(-10, 10);
           
    return arr;
}

static int[] ReadPosition(int m, int n)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Enter the position of the element (separated by a space): ");
    string[] input = Console.ReadLine().Split();
    int i = int.Parse(input[0]) - 1;
    int j = int.Parse(input[1]) - 1;
    if (i < 0 || i >= m || j < 0 || j >= n)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect element position.");
        return null;
    }
    else   
        return new int[] { i, j };
    
}

static int GetElement(int[,] arr, int[] pos)
{
    if (pos == null)    
        return int.MinValue;    
    else
    {
        int i = pos[0];
        int j = pos[1];
        return arr[i, j];
    }
}

static void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("{0,8}", arr[i, j]);
        }
        Console.WriteLine();
    }
}


Console.ResetColor();

