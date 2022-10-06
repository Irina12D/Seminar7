/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
    m = 3, n = 4.
    1 7 -2 -85
    1 -3 8 -9
    8 7 -7 9
*/

// искоючительно для визуальной красоты восприятия все элементы будут двузначными числами
int[,] New2DMas(int m, int n)
{
    int[,]mas = new int[n,m];
    for(int i=0; i<n; i++)
        for(int j=0; j<m; j++)
            mas[i,j] = new Random().Next(10,100);
    return mas;        
}

void Out2DMas(int[,]mas)
{
    int n = mas.GetLength(0);
    int m = mas.GetLength(1);
    for(int i=0; i<n; i++)
    {
        for(int j=0; j<m; j++)
            Console.Write(mas[i,j] + "  ");
        Console.WriteLine();    
    }
}

Console.WriteLine("Введите размерность матрицы");
Console.Write(" кол-во строк ");
int n = int.Parse(Console.ReadLine());
Console.Write(" кол-во столбцов ");
int m = int.Parse(Console.ReadLine());
int [,]matrix = New2DMas(n,m);
Out2DMas(matrix);

