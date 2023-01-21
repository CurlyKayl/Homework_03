// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
string numberStr = Console.ReadLine();

if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
{
	Console.WriteLine("Число является палиндромом.");
}
else
{
	Console.WriteLine("Число не является палиндромом.");
}