/*Задача 49: Задайте двумерный массив. Найдите элементы, 
у которых оба индекса нечётные, и замените эти элементы на их квадраты. */
//---------------------------------------------------------------------

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

ArrayOddIndexesToPower(myArray);
PrintArray2D(myArray);
Console.WriteLine();

Console.WriteLine($"Сумма элементов главной диагонали = {SummElementsMainDiagonal(myArray)}");

/*Задайте двумерный массив. Найдите сумму элементов, находящихся на 
главной диагонали (с индексами (0,0); (1;1) и т.д.*/

int SummElementsMainDiagonal(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = i;
        count += array[i,j];
    }
    return count;
}

void ArrayOddIndexesToPower(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i += 2)
    {
        for (int j = 1; j < array.GetLength(1); j += 2)
        {
            array[i, j] = (int) Math.Pow(array[i, j], 2); //Приведение типа перед Math
        }
    }
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

void PrintArray2D(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            //System.Console.Write($" {matr[i, j]} ");
            System.Console.Write(String.Format("{0,4}", matr[i, j]));
        }
        System.Console.WriteLine();
    }
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
