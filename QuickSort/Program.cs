// See https://aka.ms/new-console-template for more information
//Сложность алгоритма O(nlongn)
namespace Algorithms.QuickSort
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

			List<int> sortedList = QuickSort(originalList);
			Console.WriteLine("\nSorted List count elements: {0}", sortedList.Count);
			foreach (var value in sortedList)
			{
				Console.Write(value+" ");
			}
		}

		private static List<int> QuickSort(List<int> originList)
		{
			if (originList.Count < 2)
			{
				return originList;
			}

			int pivot = originList[originList.Count/2];
			List<int> less = originList.Where(e => e < pivot).ToList();
			List<int> greater = originList.Where(e => e > pivot).ToList();
			List<int> returned = QuickSort(less);
			returned.Add(pivot);
			returned.AddRange(QuickSort(greater));
			return returned;
		}
		
		//Из 
	}
}