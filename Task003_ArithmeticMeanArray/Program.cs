 //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Enter the dimensions of the array (separated by a space): ");
string[] input = Console.ReadLine().Split();
int rows = int.Parse(input[0]);
int cols = int.Parse(input[1]);

int[,] array = FillArray(rows, cols);

PrintArray(array);

double[] averages = FindAverages(array);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Arithmetic averages in each column:");
for (int i = 0; i < cols; i++)
{
    Console.WriteLine($"Column {i + 1}: {averages[i]}");
}

Console.ReadLine();


static int[,] FillArray(int rows, int cols)
{
    Random random = new Random();
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10);
        }
    }
    return array;
}

static double[] FindAverages(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    
    double[] averages = new double[cols];
    for (int j = 0; j < array.GetLength(0); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[i, j];
        }
        averages[j] = sum / rows;
    }
    return averages;
}

static void PrintArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.ResetColor();