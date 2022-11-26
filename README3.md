# Описать блок -схему метода 4 из задачи #
## Условие 

4. метод, формирующий новый массив на основе имеющегося.

int[] Solution(int[] collectionElements, int evenCounts)

{

  //       v

  // 1 2 3 4 5 6 7 8 9 0 collectionElements

  // 2 0 0 0 0 items

  //   ^ 

  int[] items = new int[evenCounts];


  int length = collectionElements.Length;

  int position = 0;

  int indexInItems = 0;

  
  while (position < length)


  {
    
    if (collectionElements[position] % 2 == 0)

    {
      items[indexInItems] = collectionElements
      [position];

      indexInItems++;
     }

     position++;

  }

  return items;

}

# Задание 2

## Условие
Почему метод печатающий массив PrintBad хуже метода PrintGood

void PrintBad(int[] numbers)

{
  int size = numbers.Length;

  int i = 0;

  while (i < size)
  {
    Console.Write($"{numbers
    [i]} ");

    i++;
  }

  Console.WriteLine();

}
Метод выводит результат в консоль.

string PrintGood(int[] numbers)

{
  int size = numbers.Length;

  int i = 0;

  string result = "[ ";


  while (i < size)

  {
    result += ($"{numbers[i]} 
    ");

    i++;

  }

  return result + "]";

}

Используется string- т.е. результат выводится в виде строки.