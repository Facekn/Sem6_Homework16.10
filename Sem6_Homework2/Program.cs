// Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = i + j;
}
void PrintMatrix(int[,] matrix)
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
Console.Write("Введите число строк m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);