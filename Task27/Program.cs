// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine()!);
int sum = 0;
for (int i = 1; i <= Math.Abs(number); i = i * 10) sum = sum + Math.Abs(number)%(i*10)/i;
System.Console.WriteLine(sum);
