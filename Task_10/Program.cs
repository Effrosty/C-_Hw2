// Задание 10

Console.Clear();

Console.Write("Введи трёхзначное число: ");

int a = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(a);

Console.WriteLine("вторая цифра этого числа -> " + stringNumber[1]);

