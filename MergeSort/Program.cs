// See https://aka.ms/new-console-template for more information

namespace Algorithms.MergeSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}

		private static List<int> MergeSort(List<int> originalList)
		{
			if (originalList.Count < 2) return originalList;
			List<int> firstList = originalList.Take(originalList.Count / 2).ToList();
			List<int> secondList = originalList.Take(new Range(originalList.Count / 2 + 1, originalList.Count - 1))
				.ToList();
			if (firstList[0] > secondList[0])
			{
				s
			}
			
		}
	}
}