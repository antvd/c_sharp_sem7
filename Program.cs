//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

// double[,] FillArrayRandomNumbers(int m, int n, int left, int right)
// {
//     double[,] arr = new double[m,n];
//     Random rand = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i,j] = Math.Round(rand.Next(left,right+1) + rand.NextDouble(),1);
//         }
//     }
//     return arr;
// }
// void Print(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+"\t");
//         }
//     Console.WriteLine();
//     }
// }
// Console.WriteLine("Введите m и n");
// int m =  Convert.ToInt32(Console.ReadLine());
// int n =  Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите левую границу случайного числа массива");
// int left = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите правую границу случайного числа массива");
// int right = Convert.ToInt32(Console.ReadLine());
// double[,] array = FillArrayRandomNumbers(m, n, left, right);
// Print(array);


//Задача 50. Напишите программу, которая на вход принимает число, возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

// int[,] FillArrayRandomNumbers(int m, int n, int left, int right)
// {
//     int[,] arr = new int[m,n];
//     Random rand = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i,j] = rand.Next(left,right+1);
//         }
//     }
//     return arr;
// }
// void search(int[,] arr, int x)
// {
//     int count = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (x == arr[i,j])
//             {
//                 Console.WriteLine($"Индекс числа в двумерном массиве:{i},{j}");
//                 count++;
//             }
//         }
//     }
//     if (count == 0)
//     {
//         Console.WriteLine("Этого числа нету в массиве");
//     }
// }
// // void Print(int[,] array)
// // {
// //     for (int i = 0; i < array.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array.GetLength(1); j++)
// //         {
// //             Console.Write(array[i,j]+"\t");
// //         }
// //     Console.WriteLine();
// //     }
// // }

// Console.WriteLine("Введите m и n");
// int m =  Convert.ToInt32(Console.ReadLine());
// int n =  Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите левую границу случайного числа массива");
// int left = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите правую границу случайного числа массива");
// int right = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int[,] array = FillArrayRandomNumbers(m,n,left,right);
// search(array,x);
// //Console.WriteLine();
// //Print(array);


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArrayRandomNumbers(int m, int n, int left, int right)
{
    int[,] arr = new int[m,n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = rand.Next(left,right+1);
        }
    }
    return arr;
}
double Sum(int[,] arr, int h)
{
    double count = 0;
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i,h];
            count++;
        }
    }
    return sum/count;
}

void Test(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+"\t");
        }
    Console.WriteLine();
    }
}


Console.WriteLine("Введите m и n");
int m =  Convert.ToInt32(Console.ReadLine());
int n =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите левую границу случайного числа массива");
int left = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите правую границу случайного числа массива");
int right = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArrayRandomNumbers(m, n, left, right);
Console.Write("Среднее арифметическое каждого столбца:");
for (int i = 0; i < array.GetLength(1); i++)
{
    if (i != array.GetLongLength(1)-1)
    {
        Console.Write(Sum(array,i)+";");
    }
    else
    {
        Console.Write(Sum(array,i));
    }
}
Console.WriteLine();
Test(array);