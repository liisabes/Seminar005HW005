// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.Write("Введите длинну массива: ");
int lengthArr = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int[] arr = new int[lengthArr];
int summ = 0;

GeneraiteArr(arr);
PrintArr(arr);
Summ(arr, summ);

//заполнение случайними числами массива
void GeneraiteArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-11, 11);
    }
}

//печать массива
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void Summ(int[] arr, int summ)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            summ += arr[i];
        }
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {summ}");
}