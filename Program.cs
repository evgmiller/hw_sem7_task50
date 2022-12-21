// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

int [,] GetArray( int m, int n, int minValue, int maxValue)
{
    int[,] result=new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]= new Random().Next(minValue,maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}  ");
            
        }
        Console.WriteLine();
    }
}

int[,] array= GetArray(4,4,-10,10);
Console.WriteLine();
PrintArray(array);

void SearchNum (int [,] inArraySearch)
{
    Console.Write("Введите номер строки: ");
    int numRow= int.Parse(Console.ReadLine()!);

    Console.Write("Введите номер столбца: ");
    int numColumn= int.Parse(Console.ReadLine()!);
    
    string Name= "Такого числа в массиве нет";
    for(int i=0; i<inArraySearch.GetLength(0); i++)
    {
        for(int j=0; j<inArraySearch.GetLength(1); j++)
        {
            if (i==numRow && j==numColumn)
            {
                Name= string.Join(" ", inArraySearch[i,j]);
            }
        }
    }
    Console.WriteLine (Name);
}
SearchNum(array);