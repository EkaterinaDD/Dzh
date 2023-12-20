// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Введите значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());
void che(int m, int n)
{
if (m > n)
return;
if (m > 0)
{
Console.Write($"{m}, ");
}
che(m+1,n);

}
che(m,n);


//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());

int Akker(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return Akker(m - 1, 1);
else return Akker(m - 1, Akker(m, n - 1));
}

Console.Write($"Функция Аккермана равно {Akker(m, n)} ");


//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
       
int [] array = CreateArray(10,10,0);
System.Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
System.Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array,array.Length-1))}]");
        
static int [] CreateArray (int size, int max, int min){
int [] array  = new int[size];
Random rand = new();
  for (int i = 0; i < size; i++)
     {
 array [i] = rand.Next(min,max+1);
   }    return array;
     }
 static string PrintArray(int [] array)
 {
    return string.Join(", ",array);
  }
 static int [] ArraySwap(int [] array,int index)
 {

 if (index <= 0)
 {
 return array;
 }
 int temp = array[index];
array[index] = array[array.Length - index-1];
array[array.Length - index-1] = temp;
return ArraySwap(array,index -= 2);
}
