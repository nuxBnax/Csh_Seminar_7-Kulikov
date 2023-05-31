// Задача 50. 

// Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

void Main()
{
    int row = ReadInt("Enter number of rows: ");
    int column = ReadInt("Enter number of columns: ");
    int[,] matrix = FillMatrix(row, column, 0, 10);
    PrintMatrix(matrix);
    int findRow = ReadInt("To find a number please enter a number of row: ");
    int findColumn = ReadInt("To find a number please enter a number of column: ");
    if (0 < findRow && findRow <= row && 0 < findColumn && findColumn <= column)
        System.Console.WriteLine("Number on position " + findRow + " " + findColumn + ": "  + matrix[findRow - 1, findColumn - 1]);
    else System.Console.WriteLine("Number with chosen position not exist");
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

Main();