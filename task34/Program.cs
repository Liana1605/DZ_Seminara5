// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arrRand(int len)
{
    int[] a = new int [len];
    for (int i=0; i < a.Length; i++)
    {
        a[i] = new Random().Next(100, 1000);
    }
    return a;
}

void arrPrint(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();
}

int [] arr = arrRand(4);
arrPrint(arr);
int evenNum = 0;

foreach (var n in arr)
{
    if (n % 2 == 0 )
    evenNum ++;
}
Console.WriteLine($"Количество четных чисел: {evenNum} ");