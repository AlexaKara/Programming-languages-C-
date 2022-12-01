public static class Library
{
//Метод печати GOOD
public static string PrintGood(int[] numbers)
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
}



//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива
 class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] d = new int[30];
            int max=0, min=100;
            for (int i = 0; i<d.Length; i++ )  d[i] = rnd.Next(100);
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] > max) max = d[i];
                if (d[i] < min) min = d[i];
            }
           
               for (int i = 0; i < d.Length; i++) Console.Write(" "+d[i]);//выводим массив
               Console.WriteLine();
                 Console.WriteLine("max:  " + max);
                 Console.WriteLine("min  " +min);
                 Console.WriteLine("Разница максимального и минимального:  "+(max - min));
                Console.ReadKey();
        }
    }


// метод, который создаёт массив
int[] CreateArray(int count)
{
  return new int[count];
}/

// заполняет массив
void Fill(int[] array, int min, int max)
{
  int size = array.Length;
  for (int i = 0; i < size; i++)
  {
    array[i] = Random.Shared.Next(min, max + 1);
    //array[i] = new Random().Next(min, max);
  }
}
 //сумма положительных элементов массива
 int SumPositive(int[] numbers)
{
  int result = 0;
  int size = numbers.Length;
  for (int i = 0; i < size; i++)
  {
    if (numbers[i] > 0) result += numbers[i];
  }
  return result;
}


// сумма отрицательных элементов массива
int SumNegative(int[] numbers)
{
  int result = 0;
  int size = numbers.Length;
  for (int i = 0; i < size; i++)
  {
    if (numbers[i] < 0) result += numbers[i];
  }
  return result;
}



//сумма элементов, стоящих на нечётных позициях в рандомном массиве.
        var rnd = new Random();
            var arr = new int[11];
 
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0}\t", arr[i] = rnd.Next(-10, 10));
            Console.WriteLine(new Random());
 
        
            var odd = arr.Where((element, index) => index%2!=0);
            
            Console.WriteLine("Элементов нечетных позиций: Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());
 
            Console.ReadKey();


// Метод подсчета суммы многочленов
int[] Sum(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

  int[] result = new int[resultMax];

  for (int i = 0; i < resultMin; i++)
  {
    result[i] = f[i] + g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = g[i];
    else result[i] = f[i];
  }

  return result;
}

// Метод подсчета разницы многочленов
int[] Dif(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

  int[] result = new int[resultMax];

  for (int i = 0; i < resultMin; i++)
  {
    result[i] = f[i] - g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = -g[i];
    else result[i] = f[i];
  }

  return result;
}

// Метод вывода элементов многочлена на экран
string Print(int[] f)
{
  // string[] pows = { "", "", "²", "³", "⁴", "⁵", "⁶", "⁷", "⁸", "⁹" };
  string[] pows = { "^0", "^1", "^2", "^3", "^4", "^5", "^6", "^7", "^8", "^9" };
  string output = String.Empty;
  for (int i = 0; i < f.Length; i++)
  {
    int t = f[i];
    if (f[i] == 0) continue;
    if (f[i] < 0) { output += " - "; }
    else if (i != 0) { output += " + "; }

    if (t < 0) t = -t;
    if (i == 1) { output += $"{t}x"; }
    if (i == 0) { output += $"{t}"; }
    if (i != 1 && i != 0 && f[i] != 0) { output += $"{t}x{pows[i]}"; }
    //if (flag && f[i] != 0 && i < f.Length - 1) output += " + ";
  }

  return output;
}
           