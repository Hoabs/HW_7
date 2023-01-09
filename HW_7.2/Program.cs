double[,] CreateFilledMatrix(int a, int b)
{
    double[,] matrix = new double[a, b];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

void CheckMatrix(double[,] matrix, int a, int b)
{
    if (a < matrix.GetLength(0) && a >=0 && b < matrix.GetLength(1) && b >=0)
    {
        Console.WriteLine(matrix[a, b]);
    }
    else
    {
        Console.WriteLine("Index is out of array bonds");
    }
}

double[,] mat = CreateFilledMatrix(5, 5);
PrintMatrix(mat);

Console.WriteLine("Enter a position of line");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a position of column");
int n = Convert.ToInt32(Console.ReadLine());

CheckMatrix(mat, m, n);