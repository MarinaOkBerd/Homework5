// 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях

Console.WriteLine("Введите размер массива ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);

}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int summ = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
        summ = summ + array[i];
}

Console.WriteLine();
Console.WriteLine($"Сумму элементов, стоящих на нечётных позициях равна {summ}");