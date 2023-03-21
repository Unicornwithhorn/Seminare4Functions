// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, причём таких разложений может быть несколько.
//  Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах.

// Требуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного чётного числа.
// Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.

int Createnumber() //создаём случайное чётное число от 4 до 998
{
  Random RandomNumber = new Random();
  int Namber = RandomNumber.Next(2,450);
  return Namber*2;
}
  
  Createnumber();

string[] words = { "apple", "strawberry", "grape", "peach", "banana" };
var wordQuery = from word in words
                where word[0] == 'g'
                select word;

// Because each element in the sequence is a string,
// not an anonymous type, var is optional here also.
foreach (string s in wordQuery)
{
    Console.WriteLine(s[2]);
    Console.WriteLine("хуй"[1]);
}