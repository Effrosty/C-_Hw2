// Задание 15

using static System.Console;

Clear();

Write("Введите число дня недели - ");

int day = Convert.ToInt32(ReadLine());


void DayNumber (int day)
{
    if (day == 6 || day == 7)
    {
        WriteLine("Да, этот день выходной!!!");
    }

    else if (day < 1 || day > 7)
    {
        WriteLine("Это число не день недели)))");
    }

    else 
    {
        WriteLine("Нет, данный день недели не является выходным");
    }
}

DayNumber(day);
