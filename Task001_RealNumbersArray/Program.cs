// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

int[] size = GetArraySize();
double[,] array = FillArray(size[0], size[1]);

static int[] GetArraySize()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Enter the dimensions of the two-dimensional array separated by spaces: ");
    Console.ResetColor();
    string[] input = Console.ReadLine().Split(' ');

    int[] size = new int[2];
    size[0] = int.Parse(input[0]);
    size[1] = int.Parse(input[1]);

    return size;
}

static double[,] FillArray(int rows, int cols)
{
    Random rand = new Random();
    double[,] array = new double[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 1);
        }
    }
    return array;
}
    
static void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0,10}", array[i, j]);
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

    PrintArray(array);
