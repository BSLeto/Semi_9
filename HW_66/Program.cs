Console.Clear();
// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int NaturalsDigits(int start, int end)
{
    if (start == end) return start;

    return (start + NaturalsDigits(start + 1, end));
}
Console.WriteLine(NaturalsDigits(M, N));
