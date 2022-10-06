/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите  число:");
int number = int.Parse(Console.ReadLine());
if (99 < number & number < 1000)
{
string numberString = number.ToString();
int result = int.Parse(numberString[2].ToString());
Console.WriteLine($"Третья цифра заданного числа: {result}");
}
else
Console.WriteLine("Третьей цифры нет!");

