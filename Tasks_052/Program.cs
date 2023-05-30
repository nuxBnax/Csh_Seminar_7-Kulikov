// Задача 52. 

// Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Main()
{
    int row = ReadInt("Enter number of rows in genarating array: ");
    int column = ReadInt("Enter number of columns in genarating array: ");
    int[,] matrix = FillMatrix(row, column, 0, 10);
    PrintMatrix(matrix);
    double[] averArray = AverageArrayColumn(matrix, column);
    PrintAverageMatrix(FillAverageArray(averArray));
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] AverageArrayColumn(int[,] array, int column)
{
    double[] average = new double[column];
    
    for (int j = 0; j < column; j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        average[j] = sum / array.GetLength(0);
    }
    return average;
}

double[] FillAverageArray(double[] Aver)
{
    {
        double[] matrix = new double[Aver.Length];

        for (int i = 0; i < Aver.Length; i++)
        {
            matrix[i] = Math.Round(Aver[i], 1);
        }
        return matrix;
    }
}

void PrintAverageMatrix(double[] matrix)
{
    System.Console.WriteLine("Average of each column: " + string.Join("; ", matrix));
} 

Main();
