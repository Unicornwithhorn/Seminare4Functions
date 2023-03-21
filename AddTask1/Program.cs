// Дана последовательность из N целых чисел и число K.
// Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если
//  K – положительное и влево, если отрицательное.

int[] CreateArray( int N, int a, int b) // создаём массив из N случайных целых чисел в промежутке от a до b
{
  int[] array = new int[N];
  Random RandomNumber = new Random();
  for (int i = 0; i < N; i++)
  {
    array[i] = RandomNumber.Next(a,b);
    System.Console.Write("{0} ",array[i]);
  }
  return array;
}

int[] ShiftArray(int[] array, int shift)
{
  int[] ShiftedArray = new int[array.Length];
  int realshift = shift%array.Length;
  for (int i = 0; i < ShiftedArray.Length; i++)
  {
    if (realshift>=0)
    {
      if (i >= realshift) ShiftedArray[i] = array[i - realshift];
      else ShiftedArray[i] = array[i - realshift + ShiftedArray.Length];
    }
    else
    {
      if (i < ShiftedArray.Length + realshift) ShiftedArray[i] = array[i - realshift];
      else ShiftedArray[i] = array[i - realshift - ShiftedArray.Length];
    }
    System.Console.Write("{0} ",ShiftedArray[i]);
  }
    return ShiftedArray;
}

System.Console.WriteLine("Создаём массив. Введите число элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение элемента массива");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение элемента массива");
int b = Convert.ToInt32(Console.ReadLine());

int[] myarray = CreateArray(N,a,b);

System.Console.WriteLine("Введите количество элементов, на которое нужно сдвинуть массив");
int shift = Convert.ToInt32(Console.ReadLine());

int[] newarray = ShiftArray(myarray, shift);