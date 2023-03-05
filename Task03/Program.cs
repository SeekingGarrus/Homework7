// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 1. Ввод размера массива
int Prompt(string message) 
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// 2. Заполнение массива вручную
void WriteMassiv2D(int [,] matr)  
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
                matr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

// 3. Вывод на печать созданного массива
void PrintTwoArray(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// 4. Найти среднее арифметическое в каждом столбце

void ArithmeticMean(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        Console.WriteLine($"Среднее арифметическое в {j+1} столбце: {Math.Round(sum / arr.GetLength(0),2)} ");
    }
}

int lines = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int[,] array = new int [lines, columns];
WriteMassiv2D(array);
PrintTwoArray(array);
Console.WriteLine();
ArithmeticMean(array);