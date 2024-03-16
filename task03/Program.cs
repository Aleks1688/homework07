// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void ReversArray(int[] array, int firstDigit, int lastDigit)
{
    if (firstDigit >= lastDigit) return;

    int temp = array[firstDigit];
    array[firstDigit] = array[lastDigit];
    array[lastDigit] = temp;
    
    ReversArray(array, (firstDigit+1), (lastDigit-1));
}

int[] array = CreateArrayRndInt(10, 0, 10);
PrintArray(array);
Console.WriteLine();
ReversArray(array, 0, (array.Length-1));
PrintArray(array);