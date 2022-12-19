// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое натуральное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void SumNuber(int M)
{
    sum += M;
    M++;
    if(M > N)
    {
        Console.Write($"Сумма натуральных чисел: {sum}");
        return;
    }
    SumNuber(M);
}
SumNuber(M);