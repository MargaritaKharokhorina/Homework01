// Задача 38. Задайте массив случайных вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

double[] CreateArrayRndDouble (int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
         else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
Console.Write("Массив: ");
double[] arr = CreateArrayRndDouble(8, 10, 999);
PrintArray(arr);

double MaxElement(double[] array)
{
    double maxNumber = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxNumber) maxNumber = arr[i];
}
return maxNumber;
}

double MinElement(double[] array)
{
    double minNumber = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minNumber) minNumber = arr[i];
}
return minNumber;
}

double maxElement = MaxElement(arr);
double minElement = MinElement(arr);
Console.WriteLine($"Максимальный элемент массива --> {maxElement}");
Console.WriteLine($"Минимальный элемент массива --> {minElement}");

double DifferenceBetweenElements()
{
    double result = 0;
    result = maxElement - minElement;
    return result;
}
double difference = DifferenceBetweenElements();
Console.WriteLine($"Разница между ними равна {difference}");
