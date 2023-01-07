//Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же 
//указание, что такого элемента нет.
//--------------------------------------------------------------------
Console.Clear();
const int STR = 10;
const int COL = 15;
const int FROM = -25;
const int TO = 25;

int[,] myArray = CreateFill2DArrayRandom(STR, COL, FROM, TO);

Console.WriteLine();
PrintArray2D(myArray);
Console.WriteLine();
Console.WriteLine("Создан двумерный массив наполненный случайными целыми числами.");
mark:
Console.WriteLine("Введите координаты нужного элемента:");
int indexI = InputNumberControl("Номер строки: ");
int indexJ = InputNumberControl("Номер столбца: ");

if (indexI > myArray.GetLength(0) || indexJ > myArray.GetLength(1))
{
    Console.WriteLine("Такого элемента в массиве нет, \nпопробуйте ещё раз.");
    goto mark;
}
Console.WriteLine();
Console.WriteLine($"По адресу [{indexI}, {indexJ}] находится число {myArray[indexI,indexJ]}.");
Console.WriteLine();

//----------------------------------------------------------------------
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
