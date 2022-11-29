
Random rnd = new Random();
int[] d = new int[20];
int max=0, min=50;
for (int i = 0; i<d.Length; i++ )  d[i] = rnd.Next(50);
for (int i = 0; i < d.Length; i++)
    {
        if (d[i] > max) max = d[i];
        if (d[i] < min) min = d[i];
    }
           
for (int i = 0; i < d.Length; i++) Console.Write(" "+d[i]);
Console.WriteLine();
Console.WriteLine("max:  " + max);
Console.WriteLine("min  " +min);
Console.WriteLine("Разница максимального и минимального элемента:  "+(max - min));
Console.ReadKey();