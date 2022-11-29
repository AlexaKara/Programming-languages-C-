﻿int[] Array(int count)
    {
     return new int[count];
    }

void Fill(int[] array, int min, int max)
{ 
    int size = array.Length; 
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
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

int SumNegativ(int[] array)
{
    int result = 0;
    int size = array.Length;
    for (int i = 1; i <= size; i = i + 2)
    {
        result = result + array[i];
    }
    return result;
}

int[] array = Array(10);
Fill(array, -5, 5);
int result = SumNegativ(array);
Console.WriteLine($"{PrintGood(array)} -> {result}");