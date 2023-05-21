//Семинар 7.
//Домашнее задание.
//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

int ReadInt(string argument) // проверка ввода пользователя
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Вы ввели не число!");
        Console.Write(argument);
    }
    return i;
}

double[,] FillFrrayMatrix(double[,] matr) // заполнение случайными числами нашей матрицы
{
    Random rnd =new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Math.Round(rnd.Next(0, 10) + rnd.NextDouble(), 2);
        }
    }
    return matr;
}

void PrintArrayMatrix(double[,] matr)  // вывод на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int m = ReadInt("Введите количество строк ");
int n = ReadInt("Введите количество столбцов ");
double[,] matrix = new double[m ,n];
FillFrrayMatrix(matrix);
PrintArrayMatrix(matrix);