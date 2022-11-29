int[] CreateArray(int array)
{
    return new int[array];
}

void Fill(int[] array, int min, int max)
{ 
    int size = array.Length; 
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
string PrintGood(int[] numbers)
    {
        int size = numbers.Length;
        int i = 0;
        string result = "[ ";

        while (i < size)
        {
            result += ($"{numbers[i],3} ");
            i++;
        }
        return result + "]";
    }




int[] array = CreateArray(8);
Console.WriteLine(PrintGood(array));
Fill(array, 1, 20); 
Console.WriteLine(PrintGood(array));