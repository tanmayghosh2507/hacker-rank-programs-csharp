using System;

namespace InterviewPractice.Sorting
{
    public class QuickSort
    {
        public void QSort(int[] nums)
        {
            if(nums.Length <= 1)
            {
                return;
            }

            Partition(nums, 0, nums.Length-1);
        }

        private void Partition(int[] nums, int start, int end)
        {
            if(start >= nums.Length || start < 0 || end >= nums.Length || end < 0 || start > end) {
                return;
            }

            int pivotValue = nums[start];
            int current = start;
            int right = end;

            while(current <= right) {
                while(current < nums.Length && nums[current] <= pivotValue)
                {
                    current++;
                }

                while(right >= 0 && nums[right] > pivotValue)
                {
                    right--;
                }

                if(current < right) {
                    Swap(nums, current, right);
                    current++;
                    right--;
                }
            }

            Swap(nums, start, right);
            Partition(nums, start, right-1);
            Partition(nums, right+1, end);
        }

        private void Swap(int[] nums, int firstIndex, int otherIndex)
        {
            int temp = nums[firstIndex];
            nums[firstIndex] = nums[otherIndex];
            nums[otherIndex] = temp;
        }
    }
}