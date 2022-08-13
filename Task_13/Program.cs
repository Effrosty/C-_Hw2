// Задание 13

using static System.Console;

Clear();

Console.Write("Введи число: ");

int ThirdNumber = Convert.ToInt32(Console.ReadLine());

string StringNumber = Convert.ToString(ThirdNumber);

if (StringNumber.Length > 2)
{
  Console.WriteLine("третья цифра - " + StringNumber[2]);
}

else 
{
  Console.WriteLine("третьей цифры нет ");
}





