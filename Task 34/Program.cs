// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int num;

while (true)
{
    Console.Write("Введите размер массива: ");
    if (int.TryParse(Console.ReadLine(), out num))
        if (num > 0)
            break;
    Console.WriteLine("Ошибка ввода!");
}

int[] array = GetArray(num, 100, 999);
int num2 = countEventNumbers(array);

Console.Write($"[" + String.Join(", ", array) + $"]");
Console.Write($" -> {num2}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int countEventNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
    { 
        if( (el % 2) == 0) count++;
    }
    return count;
}