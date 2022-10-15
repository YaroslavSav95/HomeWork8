// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк ");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n=int.Parse(Console.ReadLine());
int[,]array=new int[m,n];
RandomArray(array);
PrintArray(array);
Console.WriteLine();
TempArray(array);
PrintArray(array);
void RandomArray(int [,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(10);
        }
    }
}
void TempArray(int [,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            for (int k=0;k<array.GetLength(1)-1;k++)
            {
                if(array[i,k]<array[i,k+1])
                {
                    int Temp=array[i,k+1];
                    array[i,k+1]=array[i,k];
                    array[i,k]=Temp;
                }
            }
        }
    }
}
void PrintArray(int [,] array)
{
    Console.Write("[");
    for(int i=0;i<array.GetLength(0);i++)
    {
        Console.WriteLine();
        for(int j=0;j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]}"+" ");
        }
    }
    Console.Write("]");
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество строк ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов ");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[m, n];
        int count = 0;
        int min = 0;
        int sum = 0;
        RandomArray(array);
        PrintArray(array);
        MinSumLine(array);
        void RandomArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10);
                }
            }
        }
        void MinSumLine(int[,]array)
        {
            for(int i=0;i<array.GetLength(1);i++)
            {
                count+=array[0,i];
                // count принудительно сделал строкой с минимальной суммой чисел
            }
            for(int i=0;i<array.GetLength(0);i++)
            {
                for(int j=0;j<array.GetLength(1);j++)
                sum+=array[i,j];
                // в переменной sum храню сумму чисел строки
                {
                    if(sum<count)
                    // сравниваю минимальную строку с другими и, если, sum меньше минмальной, то она становиться минимальной(чёртова тавтология)
                    // , а номер строки сохраняю в min
                    {
                        count=sum;
                        min=i;
                    }
                    sum=0;
                }
            }
            Console.WriteLine($"Строка {min+1} имеет наименьшую сумму значений");
            // Вывожу значение минмальной строки +1, т.к. нумерация начинается с 0
        }
        void PrintArray(int[,] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}" + " ");
                }
            }
            Console.Write("]");
        }
    }
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк ");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n=int.Parse(Console.ReadLine());
int[,]arrayFirst=new int[m,n];
int[,]arraySecond=new int[m,n];
int[,]arraySum=new int[m,n];
FirstRandomArray(arrayFirst);
SecondRandomArray(arraySecond);
PrintArrayFirst(arrayFirst);
PrintArraySecond(arraySecond);
SumArray(arraySum);
void FirstRandomArray(int [,] arrayFirst)
{
    for (int i=0;i<arrayFirst.GetLength(0);i++)
    {
        for (int j=0;j<arrayFirst.GetLength(1);j++)
        {
            arrayFirst[i,j] = new Random().Next(10);
        }
    }
}
void SecondRandomArray(int [,] arraySecond)
{
    for (int i=0;i<arraySecond.GetLength(0);i++)
    {
        for (int j=0;j<arraySecond.GetLength(1);j++)
        {
            arraySecond[i,j] = new Random().Next(10);
        }
    }
}
void SumArray(int [,] arraySum)
{
    for (int i=0;i<m;i++)
    {
        Console.WriteLine();
        for (int j=0;j<n;j++)
        {
            arraySum[i,j] = arrayFirst[i,j]+arraySecond[i,j];
            Console.Write($"{arraySum[i,j]}"+" ");
        }
    }
}
void PrintArrayFirst(int [,] arrayFirst)
{
    Console.Write("[");
    for(int i=0;i<arrayFirst.GetLength(0);i++)
    {
        Console.WriteLine();
        for(int j=0;j<arrayFirst.GetLength(1);j++)
        {
            Console.Write($"{arrayFirst[i,j]}"+" ");
        }
    }
    Console.Write("]");
}
void PrintArraySecond(int [,] arraySecond)
{
    Console.Write("[");
    for(int i=0;i<arraySecond.GetLength(0);i++)
    {
        Console.WriteLine();
        for(int j=0;j<arraySecond.GetLength(1);j++)
        {
            Console.Write($"{arraySecond[i,j]}"+" ");
        }
    }
    Console.Write("]");
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Write("Введите высоту массива ");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите ширину массива ");
int n=int.Parse(Console.ReadLine());
Console.Write("Введите глубину массива ");
int z=int.Parse(Console.ReadLine());
int[,,]array=new int[m,n,z];
RandomArray(array);
ChangeArray(array);
PrintArray(array);
void RandomArray(int [,,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            for(int k=0;k<array.GetLength(2);k++)
            {
                array[i,j,k] = new Random().Next(10,99);
            }
        }
    }
}
void ChangeArray(int [,,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            for(int k=0;k<array.GetLength(2);k++)
            {
                for(int a=0;a<i;a++)
                {
                    if(array[a,j,k]==array[i,j,k])
                    i--;
                }
                for(int b=0;b<j;b++)
                {
                    if(array[i,b,k]==array[i,j,k])
                    j--;
                }
                for(int c=0;c<k;c++)
                {
                    if(array[i,j,c]==array[i,j,k])
                    k--;
                }
            }
        }
    }
}
void PrintArray(int [,,] array)
{
    Console.Write("[");
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            for(int k=0;k<array.GetLength(2);k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})|");
            }
        }
    }
    Console.Write("]");
}