// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] numbers = { 1.4, 2.2, 3.8, 4.1, 5.9 };
double numMax = numbers[0];
double numMin = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= numMax) numMax = numbers[i]; i++;
}
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] <= numMin) numMin = numbers[i]; i++;
}

Console.WriteLine($"разницa между максимальным и минимальным элементов массива -> {numMax - numMin}");
