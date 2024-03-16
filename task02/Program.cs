// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

/***********************************************************/

// В псевдокоде функция Аккермана реализуется по определению:

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

/***********************************************************/

int AkkermanFunc(int n, int m)
{
    int result;
    if (n == 0)
    {
        result = m + 1;
    }
    else if (m == 0)
    {
       result=AkkermanFunc((n -1), 1);
    }
    else
    {
        result=AkkermanFunc((n - 1), (AkkermanFunc(n, (m - 1))));
    }
    return result;
}

Console.WriteLine("Enter n digit: ");
int nDigit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter m digit: ");
int mDigit = Convert.ToInt32(Console.ReadLine());

int akkerman = AkkermanFunc(nDigit, mDigit);

Console.WriteLine(akkerman);