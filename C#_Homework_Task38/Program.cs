// 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

Console.WriteLine("Введите размер массива ");
int number = Convert.ToInt32(Console.ReadLine());
double[] array = new double[number];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(new Random().Next(100, 1000) / 100);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

double min = array[0];                                 
double max = array[1];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
}

Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {max - min}");
