//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//элементов в каждом столбце.
//--------------------------------------------------------------------
Console.Clear();
Console.WriteLine("Создаётся двумерный массив наполненный случайными целыми числами.");
int str = InputNumberControl("Введите количество строк: ");
int col = InputNumberControl("Введите количество столбцов: ");
Console.WriteLine("Введите границы диапазона случайных чисел.");
int from = InputNumberControl("От: ");
int to = InputNumberControl("До: ");
Console.WriteLine();

int[,] myArray = CreateFill2DArrayRandom(str, col, from, to);
PrintArray2D(myArray);
Console.WriteLine();
AverageEachColumn2DArray(myArray);
Console.WriteLine();

//----------------------------------------------------------------------

//Метод Вывод среднего арифметического для каждого столбца 2D массива.
void AverageEachColumn2DArray(int[,] array)
{
    double[] avvCol = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            count += array[i,j];
        }
        avvCol[j] = count / array.GetLength(0);
    }
    Console.WriteLine("Средние значения для каждого столбца:");
    Console.WriteLine();
    Console.Write("   Номер столбца:");
    for (int i = 0; i < avvCol.Length; i++)
    {
        Console.Write(String.Format("{0,6}", i));
    }
    Console.WriteLine();
    Console.Write("Среднее значение:  ");
    for (int i = 0; i < avvCol.Length; i++)
    {
        Console.Write(String.Format("{0,6:0.0}", avvCol[i]));
    }
    Console.WriteLine();
}

int[,] CreateFill2DArrayRandom(int strings, int columns, int fromNum, int toNum)
{
    int[,] array = new int[strings, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(fromNum, toNum);
        }
    }
    return array;
}

int InputNumberControl(string text) 
{
    System.Console.Write(text);
    int number;
    while (true)    
    {
        string? txt = (Console.ReadLine());
        if (int.TryParse(txt, out number))
        {
             break;
        }
        System.Console.Write("Введенное значение не является натуральным числом. Попробуйте ещё раз: ");
    }  
    return number;
}

void PrintArray2D(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,6}", matr[i, j]));
        }
        Console.WriteLine();
    }
}
