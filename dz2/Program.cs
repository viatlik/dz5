// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[5];
int summ = 0;

for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(1, 10); 
    Console.Write(array[i] + ", ");
} 
for (int i=0; i<array.Length; i++)
{
   if (i % 2 == 1)
    summ = summ + array[i];
}
Console.Write($"Сумма элементов, стоящих на нечётных позициях -> {summ}");
