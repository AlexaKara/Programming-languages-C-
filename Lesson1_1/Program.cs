// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
int a = 5;
int b = 7;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.WriteLine ("max = ");
Console.WriteLine (max);