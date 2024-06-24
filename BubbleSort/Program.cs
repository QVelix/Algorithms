// See https://aka.ms/new-console-template for more information
//Сложность алгоритма O(n), не применяется т.к. считается учебный и у него средняя сложность O(n^2), и есть более совершенные алгоритмы
namespace Algorithms.BubbleSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> originalList = new List<int>();
			while (originalList.Count<100)
			{
				Random rnd = new Random();
				int randomValue = rnd.Next(0,100);
				if(originalList.Contains(randomValue)) continue;
				originalList.Add(randomValue);
			}
			
			Console.WriteLine("Original List count elements: {0}", originalList.Count);
			foreach (var value in originalList)
			{
				Console.Write(value+" ");
			}
			
			BubbleSort(originalList);
			Console.WriteLine("Original List after Sort count elements: {0}", originalList.Count);
			foreach (var value in originalList)
			{
				Console.Write(value+" ");
			}
		}

		private static void BubbleSort(List<int> originalSort)
		{
			for (int i = 0; i < originalSort.Count-1; i++)
			{
				for (int j = 0; j < originalSort.Count-1-i; j++)
				{
					if (originalSort[j] > originalSort[j+1])
					{
						(originalSort[j + 1], originalSort[j]) = (originalSort[j], originalSort[j + 1]); 
						/*
						 * Аналогично записи ниже
						 * int nextElement = originalSort[i + 1];
						 * originalSort[i + 1] = originalSort[i];
						 * originalSort[i] = nextElement;
						 */
					}
				}
			}
		}
	}
}