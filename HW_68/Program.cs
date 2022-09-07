Console.Clear();
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

// m = 0 => n + 1
// m > 0, n = 0 => A(m - 1, 1)
// m > 0, n > 0 => A(m - 1, A(m, n - 1))
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());
int Ackerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (N == 0) return (Ackerman(M-1, 1));
    return (Ackerman(M-1, Ackerman(M, N-1)));
}
Console.WriteLine(Ackerman(firstNum, secondNum));