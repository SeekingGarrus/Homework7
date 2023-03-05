// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Подзадачи:

// 1. Ввод размера массива
int Prompt(string message) // функция чтобы ввести число
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

// 2. Заполнение массива рандомно:
int[,] FillMassiv2D(int size1, int size2) // заполняет матрицу рандомными числами double
{
    int[,] array = new int[size1, size2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 101);
        }
    }
    return array;
}

// 3. Вывод на печать созданного массива или вывод результата.
void PrintTwoArray(int[,] matr) // метод для вывода двумерного массива
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


// 4. Действие с массивом
void PositionInArray(int[,] array, int line, int column) // метод возвращает значение элемента после введенных позиций 
{
    if (line < 0 | line > array.GetLength(0) - 1 | column < 0 | column > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемента не существует!");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[line, column] == array[i, j]) Console.WriteLine("Значение элемента массива = {0}", array[line, column]);
            }
        }
    }
}

int size0 = Prompt("Введите количество строк: ");
int size1 = Prompt("Введите количество столбцов: ");
int[,] array = FillMassiv2D(size0, size1);
PrintTwoArray(array);
int line = Prompt("Введите позицию строки в массиве: ");
int column = Prompt("Введите позицию столбца в массиве: ");
PositionInArray(array, line, column);