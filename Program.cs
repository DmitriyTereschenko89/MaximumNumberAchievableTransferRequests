namespace MaximumNumberAchievableTransferRequests
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MaximumNumberAchievableTransferRequests requests = new();
            Console.WriteLine(requests.MaximumRequests(5, new int[][]
			{
				new int[] { 0, 1 },
				new int[] { 1, 0 },
				new int[] { 0, 1 },
				new int[] { 1, 2 },
				new int[] { 2, 0 },
				new int[] { 3, 4 }
			}));
			Console.WriteLine(requests.MaximumRequests(3, new int[][]
			{
				new int[] { 0, 0 },
				new int[] { 1, 2 },
				new int[] { 2, 1 }
			}));
			Console.WriteLine(requests.MaximumRequests(4, new int[][]
			{
				new int[] { 0, 3 },
				new int[] { 3, 1 },
				new int[] { 1, 2 },
				new int[] { 2, 0 }
			}));
			Console.WriteLine(requests.MaximumRequests(3, new int[][]
			{
				new int[] { 1, 2 },
				new int[] { 1, 2 },
				new int[] { 2, 2 },
				new int[] { 0, 2 },
				new int[] { 2, 1 },
				new int[] { 1, 1 },
				new int[] { 1, 2 }
			}));
		}
	}
}