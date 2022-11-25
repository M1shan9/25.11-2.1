using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11_2._1
{
 internal class Program
 {
  static void Main(string[] args)
  {
   int[] a = new int[5] { 3, 2, 1, 5, 4 };
   int[] b = new int[5] { 2, 5, -2, -1, 3 };
   Array.Sort(a); //По возрастанию
   foreach (int i in a)
   {
    Console.Write("{0} ", i);
   }
   Console.WriteLine();

   Array.Sort(b, SortDescending); //По убыванию
   foreach (int i in b)
   {
    Console.Write("{0} ", i);
   }
   Console.WriteLine();
   int[] c = ConcatArrays(a, b); //объединили массивы
   foreach (int i in c)
   {
    Console.Write($"{i} ");
    Console.ReadLine();
   }
  }

  static int SortDescending(int x, int y)
  {
   if (x < y)

    return 1;

   if (x == y)

    return 0;

   return -1;
  }

  static int[] ConcatArrays(int[] a, int[] b)
  {
   int[] c = new int[a.Length + b.Length]; 
   for (int i = 0; i < a.Length; i++) 
    c[i] = a[i];
   for (int i = a.Length; i < a.Length + b.Length; i++) 
    c[i] = b[i - a.Length]; 
   return c;

  }
 }
 }
    

