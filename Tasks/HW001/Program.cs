// Показать натуральные числа от N до 1, N задано
Console.Clear();

void PrintNumber(int n)
{
    if (n < 1) return;
    PrintNumber(n - 1);
    Console.Write(n + " ");
}
PrintNumber(20);