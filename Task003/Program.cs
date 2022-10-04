// Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Write("Введите длинну массива: ");
int lengthArr = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
double[] arr = new double[lengthArr];

GeneraiteArr(arr);
PrintArr(arr);

double max = Max(arr);
double min = Min(arr);

Diff(max, min);

//заполнение случайними числами массива
void GeneraiteArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 10);
    }
}

//печать массива
void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
//максимальный элемент массива
double Max(double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    Console.WriteLine($"Максимальное число массива: {max}");
    return max;
}
//минимальный элемент массива
double Min(double[] arr)
{
    double min = 9;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.WriteLine($"Минимальное число массива: {min}");
    return min;
}
//разница между максимальным и минимальным элементами массива
void Diff(double max, double min)
{
    double diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");
}