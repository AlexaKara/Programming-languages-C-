Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int n = number;
int sum = 0;
while(n > 0)
{
    sum = sum + n % 10;
    n = n / 10;        
}
Console.WriteLine(sum);