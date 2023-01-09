double[,] CreateFilledMatrix(int a, int b)
{
    double[,] matrix = new double[a, b];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (100 + 100) - 100, 1);
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

Console.WriteLine("Enter a number of lines");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number of columns");
int n = Convert.ToInt32(Console.ReadLine());

double[,] mat = CreateFilledMatrix(m, n);
PrintMatrix(mat);


