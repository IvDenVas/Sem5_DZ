// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

double[] array = GetArray(num, 0, 0);

Console.Write($"[" + String.Join(" ", array) + $"]");

double max = Max(array);
double min = Min(array);
double result = Math.Round(max - min, 2);

// Console.WriteLine(max);
// Console.WriteLine(min);
Console.WriteLine($" -> {result}");

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return res;
}

double Max(double[] array)
{
    double res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (res < array[i]) res = array[i];
    }
    return res;
}

double Min(double[] array)
{
    double res = 100;
    for (int i = 0; i < array.Length; i++)
    {
        if (res > array[i]) res = array[i];
    }
    return res;
}
