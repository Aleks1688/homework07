//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

void PrintNumbersFromMtoN(int m, int n)
{

    if (m < n)
    {
        if (m > n) return;
        Console.Write($"{m} ");
        PrintNumbersFromMtoN(m + 1, n);
    }
    else if (m > n)
    {
        if (m < n) return;
        Console.Write($"{m} ");
        PrintNumbersFromMtoN(m - 1, n);
    }
    else
    {
        Console.WriteLine($"{n}");
    }

}

Console.WriteLine("Enter first digit: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second digit: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

PrintNumbersFromMtoN(firstDigit, secondDigit);
