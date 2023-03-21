// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Random r = new Random();
int[] ArrayForOutput = new int[8];
for (int i=0;i<8;i++)
{
  ArrayForOutput[i]=r.Next(1,100);
  Console.Write("{0} ", ArrayForOutput[i]);
}
