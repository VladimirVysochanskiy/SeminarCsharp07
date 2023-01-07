//Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами.  m = 3, n = 4.

Console.Clear();
Console.WriteLine("Создаётся двумерный массив наполненный случайными числами.");
int str = InputNumberControl("Введите количество строк: ");
int col = InputNumberControl("Введите количество столбцов: ");
Console.WriteLine("Укажите диапазон чисел для наполнения массива.");
int from = InputNumberControl("От: ");
int to = InputNumberControl("До: ");

double[,] myArray = CreateFill2DArrayRandom(str, col, from, to);
PrintArray2D(myArray);
Console.WriteLine();

//Метод Создание и рандомное наполнение 2D double массива.
double[,] CreateFill2DArrayRandom(int strings, int columns, int fromNum, int toNum)
{
    double[,] array = new double[strings, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(fromNum, toNum) + new Random().NextDouble(), 2);
        }
    }
    return array;
}

void PrintArray2D(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            //System.Console.Write($" {matr[i, j]} ");
            System.Console.Write(String.Format("{0,8:0.00}", matr[i, j]));
        }
        System.Console.WriteLine();
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

