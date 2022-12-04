void Number (int N)
{
    if(N < 0) Console.Write($"{N} не натуральное число");
    else 
    {
        int i = 1;
        Console.Write($"{N} ");
        if(i != N) Number(N - 1);
    }
}
int N = 8;
Number(N);
