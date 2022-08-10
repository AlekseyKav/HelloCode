// по умолчанию "string" пустая ячейка, т.е. empty
// отсчет и строк (rows) и столбцов (columns) насчинается с НОЛЯ!!!


// ДВУМЕРНЫЙ МАССИВ ИЗ 2 строк и 5 столбцов.
// string[,] table = new string[2, 5];
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

int[,] matrix = new int[3,4];
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - в нашем случае это "3", т.е. количество строк (индекс - 0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) - в нашем случае это "4", т.е. количество строк (индекс - 1)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
