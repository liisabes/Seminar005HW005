// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите длинну массива: ");
int lengthArr = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int[] arr = new int[lengthArr];
int count = 0;

GeneraiteArr(arr);
PrintArr(arr);
EvenNumber(arr, count);

//заполнение случайними числами массива
void GeneraiteArr(int[] arr)
{
    for (int i = 0; i < lengthArr; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
}

//печать массива
void PrintArr(int[] arr)
{
    for (int i = 0; i < lengthArr; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

//количество чётных чисел в массиве
void EvenNumber(int[] arr, int count)
{
    for (int i = 0; i < lengthArr; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четых элементов массива равно {count}");
}