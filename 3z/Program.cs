// В двумерном массиве показать позиции числа, 
//заданного пользователем или указать,
// что такого элемента нет

// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
/*
string PoiskPoMass(int[,] massiv, int chislo)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
           if(massiv[i,j]==chislo) return $"{chislo} в массиве находиться на позиции {i+1} {j+1}";
        }
    }
    return "Числа нет";
} 
Console.WriteLine(PoiskPoMass(array,x));
*/

/*
int PoiskIPoMass(int[,] massiv, int chislo)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
           if(massiv[i,j] == chislo) return i;
           
        }
    }
return -1;
}

int PoiskjPoMass(int[,] massiv, int chislo)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
           if(massiv[i,j]==chislo) return j;
           
        }
    }
return -1;
}
int i = PoiskIPoMass(array, x);
int j = PoiskjPoMass(array, x);
if (i>=0 && j>=0) 
{
    Console.Write($"Число {x} на позиции {i} {j}");
}
else Console.Write("Числа нет");
*/
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

void PrintMass2(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($" {array[j]} ");
    }
    Console.WriteLine();
}

void FillMass(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(-5, 10);
        }
    }
}

int[] PoiskPoMass(int[,] massiv, int chislo)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (massiv[i, j] == chislo)
            {
                return new int[]{i,j};
            }

        }
    }
    return new int[]{-1,-1};
}

Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];
FillMass(massiv: array);
PrintMass(array);
int[] val = PoiskPoMass(array, x);
PrintMass2(val);








