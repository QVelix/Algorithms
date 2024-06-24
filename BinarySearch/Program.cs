// See https://aka.ms/new-console-template for more information
//Данная сортировка работает только с отсортированными списками!
//Сложность алгоритма O(logn)
namespace Algorithms.BinarySearch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] a = new int[101];

			for (int i = 0; i <= 100; i++)
			{
				a[i] = i;
			}
			
			int needFind = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(RecursiveBinarySearch(a, needFind));
		}

		private static int BinarySearch(int[] originalArray, int needFind)
		{
			int left = originalArray[0];
			int rigth = originalArray[originalArray.Length - 1];
			int middle = originalArray.Length/2;
			while (left<=rigth)
			{
				Console.WriteLine($"Left={left}, Rigth={rigth}, Middle={middle}");
				if (originalArray[middle] < needFind)
				{
					left = middle+1;
				}
				else
				{
					rigth = middle - 1;
				}

				middle = left + (rigth - left)/2;
			}

			if (middle != needFind)
			{
				return -1;
			}
			return middle;
		}

		private static int RecursiveBinarySearch(int[] originalArray, int needFind)
		{
			if (originalArray.Length == 1) return originalArray[0];
			int left = 0;
			int right = originalArray.Length - 1;
			int middle = left + (right - left) / 2;
			Console.WriteLine(originalArray.Length);
			if (originalArray[middle] <= needFind)
			{
				return RecursiveBinarySearch(originalArray.Take(new Range(middle, right)).ToArray(), needFind);
			}
			else
			{
				return RecursiveBinarySearch(originalArray.Take(middle).ToArray(), needFind);
			}
		}
	}
}
