// See https://aka.ms/new-console-template for more information
//Сложность алгоритма O(n^2)

namespace Algorithms.SelectionSort
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
			List<int> sortedList = SelectionSort(originalList);
			Console.WriteLine("\nSorted List count elements: {0}", sortedList.Count);
			foreach (var value in sortedList)
			{
				Console.Write(value+" ");
			}
		}

		private static List<int> SelectionSort(List<int> originalList)
		{
			List<int> sortedList = new List<int>();

			while (originalList.Count!=0)
			{
				int smallest = 100;
				for (int j = 0; j <= originalList.Count-1; j++)
				{
					if (originalList[j] < smallest) smallest = originalList[j];
				}
				sortedList.Add(smallest);
				originalList.Remove(smallest);
			}

			return sortedList;
		}
	}
}