// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 5;
int[] Num = new int[size];
arrRand(Num);
arrPrint(Num);

int max = Num[0];
int min = Num[0];

for (int i = 0; i < Num.Length; i++)
{
    if(Num[i] > max)
    {
        max = Num[i];
    }
    else if(Num[i] < min)
    {
        min = Num[i];
    }
}

void arrRand(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}

void arrPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Разница максимального и минимального: {max - min}");