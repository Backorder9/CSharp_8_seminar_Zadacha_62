/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] Spiral()
{
    int x = 4;
    int y = 4;
    int[,] spiral = new int[x, y];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= x * y)
    {
        spiral[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < y - 1)
            j++;
        else if (i < j && i + j >= x - 1)
            i++;
        else if (i >= j && i + j > y - 1)
            j--;
        else
            i--;
    }
    return spiral;
}

void PrintArray(int[,] array)
{
    System.Console.WriteLine();
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    System.Console.WriteLine();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
            System.Console.Write("{0}\t", array[i, j]);
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] massiv = Spiral();
PrintArray(massiv);