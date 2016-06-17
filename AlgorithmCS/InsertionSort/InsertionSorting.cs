using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSorting
    {
        public void Sort(int[] nums)
        {
            int n = nums.Length;
            for(int i=0;i< n; i++)
            {
                for(int j= i;j>0 && Less(nums, j, j-1); j--)
                {
                    Swap(nums, j - 1, j);
                }
            }
        }

        private void Swap(int[] nums, int v, int j)
        {
            int tmp = nums[v];
            nums[v] = nums[j];
            nums[j] = tmp;
        }

        private bool Less(int[] nums, int v, int j)
        {
            return nums[v] < nums[j];
        }
    }
}
