﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) Console.WriteLine("Третьей цифры нет!");
else
{
while (num > 999)
{
  num = num / 10;
}
int num1 = num % 10;
Console.Write(num1);
}
