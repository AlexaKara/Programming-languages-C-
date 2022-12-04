int AckermanFunction (int m, int n)
{
if (m == 0) return n + 1;
if (m != 0 && n == 0) return AckermanFunction(m - 1, 1);
if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
return AckermanFunction(m, n);
}


int m = 3;
int n = 2;
Console.WriteLine($"Функция Аккермана для чисел m,n: A({m},{n}) = {AckermanFunction(m, n)}");