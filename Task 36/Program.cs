// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] array = GetArray(num, 0, 100);
int num2 = sumOddElements(array);

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

int sumOddElements(int[] array)
{
    int i = 1;
    int sum = 0;
    while (i < array.Length)
    {
        sum = sum + array[i];
        i += 2; 
    }
    return sum;
}