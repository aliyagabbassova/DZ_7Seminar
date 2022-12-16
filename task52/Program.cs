// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4                  
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введие количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введие количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)

            array[i, j] = new Random().Next(1, 51);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        System.Console.WriteLine();
    }
}

void Average(int[,] array)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
            double summ = 0; ;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i, j];
        }
        Console.WriteLine($"Среднеарифметическое Столбца - {Math.Round(summ / array.GetLength(0),2)} ");
    }

}
FillArray(array);
PrintArray(array);
Console.WriteLine();
Average(array);