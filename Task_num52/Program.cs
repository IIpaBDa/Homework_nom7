//Семинар 7.
//Домашнее задание.
//Задача 50: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//Выполнил: Кельт Дмитрий Владимирович (kelt_1981@mail.ru)
//Решение:

int[,] FillFrrayMatrix(int[,] matr)
{
    Random rnd =new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(1, 10);
        }
    }
    return matr;
}
void PrintArrayMatrix(int[,] matr)
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
void SrAr(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i,j];
        }
        double srar = sum / (double)matr.GetLength(0);
        System.Console.Write($"({Math.Round(srar, 1)}) ");
    }
}

int[,] matrix = new int[3, 4];
matrix = FillFrrayMatrix(matrix);
PrintArrayMatrix(matrix);
System.Console.WriteLine();
SrAr(matrix);
