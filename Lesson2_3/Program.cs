Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());


if(1 <= dayNumber & dayNumber <= 5)
{
  Console.WriteLine("Будний день");
}
if(6 <= dayNumber & dayNumber <= 7)
{
  Console.WriteLine("Выходной день");
}
if(dayNumber > 7)
{
  Console.WriteLine("Введи корректные данные");
}