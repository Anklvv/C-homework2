// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int a;
Console.Write($"Введите трехзначное число: ");
int.TryParse(Console.ReadLine(), out a);

int a1 = (a /10) % 10;


Console.WriteLine($"{a} -> {a1}");


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int a;
Console.Write($"Введите цифру, обозначающую день недели: ");
int.TryParse(Console.ReadLine(), out a);

if (a == 6 || a == 7)
{
    Console.WriteLine($"Выходной день");
}
else
{
 Console.WriteLine($"Будний день");
}


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write($"Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

string NumberText = Convert.ToString(Number);

if (NumberText.Length > 2)
{
    Console.WriteLine("Третья цифра -> " + NumberText[2]);
}
else
{
    Console.WriteLine("-> Третьей цифры нет, введите число =>100");
}