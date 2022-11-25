Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string room = Convert.ToString(number);
if (room.Length > 2){
  Console.WriteLine("третья цифра -> " + room[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
