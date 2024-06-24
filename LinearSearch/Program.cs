// See https://aka.ms/new-console-template for more information

//Данный алгоритм имеет асимптотическую сложность O(n), т.е. чем больше элементов, тем соответственно больше время на обработку
//Можно применять и не к отсортированным спискам, скорость не изменится, но к большим спискам лучше подходить с сортировкой и бинарным поиском

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algorithms.LinearSearch
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
			Console.WriteLine(RecursiveLinearSearch(a, needFind));
			
		}
		
		private static int LinearSearch(int[] originalArray, int needFind)
		{
			int finded = -1;
			foreach (var s in originalArray)
			{
				if (s != needFind) continue;
				finded = s;
				return finded;
			}

			return finded;
		}

		private static int RecursiveLinearSearch(int[] originArray, int needFind)
		{
			if (originArray.Length < 2) return originArray[0];
			if (originArray[0] == needFind) return originArray[0];
			return RecursiveLinearSearch(originArray.Take(new Range(1, originArray.Length)).ToArray(), needFind);
		}
	}
}