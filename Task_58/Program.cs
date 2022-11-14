//                             Задача 58

//   Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

CreateMatrixRndInt(array);
PrintMatrix(array);
Console.WriteLine();

CreateMatrixRndInt(secondArray);
PrintMatrix(secondArray);
Console.WriteLine();

// Проверка строк и столбцов на одинаковый ввод

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Матрицы перемножить нельзя!");
    Console.WriteLine("Введите одинаковое количество строк и столбцов!");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}
PrintMatrix(resultArray);

// Заполнение массива рандомными числами от 1 до 9

void CreateMatrixRndInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Вывод двумерного массива

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
