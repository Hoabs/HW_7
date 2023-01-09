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

void MatrixColumnAvarage(double[,] matrix)
{
   double sum = 0;
   for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
    Console.WriteLine(sum/matrix.GetLength(0));
    sum = 0;
    }
}

double[,] mat = CreateFilledMatrix(5, 5);
PrintMatrix(mat);
MatrixColumnAvarage(mat);