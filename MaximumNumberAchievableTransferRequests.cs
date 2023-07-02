using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberAchievableTransferRequests
{
	internal class MaximumNumberAchievableTransferRequests
	{
		private int maximumRequests = 0;

		private void MaximumRequests(int[][] requests, int[] indegree, int n, int index, int count)
		{
			if (index == requests.Length)
			{
				for (int i = 0; i < n; ++i)
				{
					if (indegree[i] != 0)
					{
						return;
					}
				}
				maximumRequests = Math.Max(maximumRequests, count);
				return;
			}
			indegree[requests[index][0]] -= 1;
			indegree[requests[index][1]] += 1;
			MaximumRequests(requests, indegree, n, index + 1, count + 1);
			indegree[requests[index][0]] += 1;
			indegree[requests[index][1]] -= 1;
			MaximumRequests(requests, indegree, n, index + 1, count);
		}

		public int MaximumRequests(int n, int[][] requests)
		{
			maximumRequests = 0;
			int[] dp = new int[n];
			MaximumRequests(requests, dp, n, 0, 0);
			return maximumRequests;
		}
	}
}
