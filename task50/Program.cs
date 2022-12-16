// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m,n];
Random rnd = new Random();
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(0,10);
        Console.Write($"{array[i,j]}, ");
    }
Console.WriteLine(" ");  
}
Console.WriteLine("Введите координаты элемента"); 
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if(a==i || b==j)
        {
           object c = array.GetValue(a,b);
           Console.WriteLine($"Элемент в массиве есть : {c}");
           break;
        }
        else 
        {
            Console.WriteLine("Элемента с такими индексами не существует");
        break;
        }
    }
}








