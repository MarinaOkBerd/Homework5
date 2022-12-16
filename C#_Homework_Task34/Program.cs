// 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива:");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int counter = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        counter ++;
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве {counter}.");