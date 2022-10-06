/* Задача 10: Напишите программу, которая 
принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
if (99 < number & number < 1000)
{
string numberString = number.ToString();
int result = int.Parse(numberString[1].ToString());
Console.WriteLine($"Вторая цифра трехзначного числа: {result}");
}
else
Console.WriteLine("Введено не трехзначное число!");


