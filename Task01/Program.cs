// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int SizeMassiv2D(string message) // задает размер матрицы
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillMassiv2D(int lines, int columns) // заполняет матрицу рандомными числами
{
    double[,] newArray = new double[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = Math.Round(rand.Next(-100, 101)*0.1, 1);
        }
    }
    return newArray;
}


void Print2Array(double[,] matrix) // метод для вывода двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int lines = SizeMassiv2D("Введите кол-во строчек массива: ");
int columns = SizeMassiv2D("Введите кол-во столбцов массива: ");
double[,] Massiv2D = FillMassiv2D(lines, columns);
Print2Array(Massiv2D);