/* 
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру от 1 до 7:");
int number = int.Parse(Console.ReadLine());
if (number == 6 || number == 7)
Console.WriteLine("этот день выходной");
else if (number > 7 || number < 1)
Console.WriteLine("число не соответствует дню недели!");
else
Console.WriteLine("этот день не выходной");

