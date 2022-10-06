/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
    m = 3, n = 4.
    1 7 -2 -85
    1 -3 8 -9
    8 7 -7 9
*/
/*
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
*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    i = 4, j = 2 -> такого числа в массиве нет
    i = 1, j = 2 -> 2
*/
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

int FindElement(int [,]mas, int x, int y)
{
    int n= mas.GetLength(0);
    int m = mas.GetLength(1);
    if (!(x >= 0 && x <n  &&  y >= 0 && y<m))
        return -1;
    else 
        return mas[x,y];  
}

Console.WriteLine("Введите размерность матрицы");
Console.Write(" кол-во строк ");
int n = int.Parse(Console.ReadLine());
Console.Write(" кол-во столбцов ");
int m = int.Parse(Console.ReadLine());
int [,]matrix = New2DMas(n,m);
Out2DMas(matrix);
Console.Write("Введите позицию элемента: строка и столбец, через пробел ");
string []s = Console.ReadLine().Split();
int a = FindElement(matrix, int.Parse(s[0]), int.Parse(s[1]));
if(a == -1)
    Console.WriteLine("такого числа в массиве нет");
else
     Console.WriteLine(a); 

