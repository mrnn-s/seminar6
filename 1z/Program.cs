// Показать двумерный массив размером m×n 
//заполненный целыми числами
void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillMass(int[,] massiv, int max, int min)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(min, max);
        }
    }
}


Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите максимальное число для чисел массива: ");
int max = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите минимальное число для чисел массива: ");
int min = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m, n];
FillMass(massiv: array, max: max + 1, min: min);
PrintMass(array);