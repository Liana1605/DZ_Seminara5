// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 4;
int[] Num = new int[size];
arrRand(Num);
arrPrint(Num);

int sumEven = 0;

for (int i = 1; i < Num.Length; i +=2)
{
    sumEven += Num[i];
}
Console.WriteLine(sumEven);

void arrRand(int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}

void arrPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}
