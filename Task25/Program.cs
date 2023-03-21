// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.WriteLine("Введите число А");
double A = Convert.ToDouble(Console.ReadLine());
double B = -1;
do
{
Console.WriteLine("Введите натуральное число В");
B = Convert.ToDouble(Console.ReadLine());
if (B <= 0 || B%1 != 0) Console.WriteLine($"{B} не натуральное число");
}
while (B <= 0 || B%1 != 0);

double result = 1;
for (int i = 1; i <= B; i++)
  result=result * A;  
System.Console.WriteLine(result);


