using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    public class SelectionSort
    {
        public void Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                int min = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Less(nums, i, j))
                    {
                        Swap(nums, i, j);
                    }
                }

                Debug.Assert(IsSorted(nums,0,i));
            }

            Debug.Assert(IsSorted(nums));
        }

        private bool IsSorted(int[] nums)
        {
            return IsSorted(nums,0,nums.Length);
        }

        private bool IsSorted(int[] nums, int low, int high)
        {
            if (low < high)
            {
               Swap(ref low, ref high);
            }

            if (high-low == 0) return true;

            for (int i = low+1; i <=high; i++)
            {
                if(Less(nums,i,i-1)) return false;
            }

            return true;
        }

        private void Swap(int[] nums, int i, int j)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }

        private void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        private bool Less(int[] nums, int i, int j)
        {
            if (nums[j] < nums[i]) return true;
            return false;
        }
    }
}
