// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillMatrix (int[,] matrix)
{   
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
          matrix[i,j] = new Random().Next(1, 10);   
}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();        
    }
}
void NewMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
           if (i%2==0 && j%2==0)
           {
            matrix[i,j]=matrix[i,j]*matrix[i,j];
           }   
}
Console.Write("Введите число строк m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] matrix = new int[m, n];
FillMatrix(matrix);
Console.WriteLine("Исходный массив: ");
Console.WriteLine("===============");
PrintMatrix(matrix);
Console.WriteLine();
NewMatrix(matrix);
Console.WriteLine("Массив с изменениями: ");
Console.WriteLine("====================");
PrintMatrix(matrix);