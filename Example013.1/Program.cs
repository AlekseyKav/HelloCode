//рандомный двуерный массив

void PrintArray(int[,] matr)
{
        for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) - в нашем случае это "3", т.е. количество строк (индекс - 0)
        {
            for (int j = 0; j < matr.GetLength(1); j++) // matrix.GetLength(1) - в нашем случае это "4", т.е. количество строк (индекс - 1)
            {
                Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
        }
}
void FillArray(int[,] matr)
{
        for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) - в нашем случае это "3", т.е. количество строк (индекс - 0)
        {
            for (int j = 0; j < matr.GetLength(1); j++) // matrix.GetLength(1) - в нашем случае это "4", т.е. количество строк (индекс - 1)
            {
                matr[i,j] = new Random().Next(1,10);
            }
        }
}
int[,] matrix = new int[5,6];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
