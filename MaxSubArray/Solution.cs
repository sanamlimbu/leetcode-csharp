/*
    Given an integer array nums, find the subarray
    which has the largest sum and return its sum.
    
    Example 1: 
        Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
        Output: 6
        Explanation: [4,-1,2,1] has the largest sum = 6.

    Example 2:
        Input: nums = [1]
        Output: 1
    
    Example 3:
        Input: nums = [5,4,-1,7,8]
        Output: 23
*/

// Using divide and conquer algorithm
// Time complexity: O(n log n)
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int right = nums.Length - 1;
        return FindMaxSubArray(nums, 0, right);
    }

    int FindMaxSubArray(int[] nums, int left, int right)
    {
        if (left == right)
        {
            return nums[left];
        }
        int mid = (left + right) / 2;
        int leftMax = FindMaxSubArray(nums, left, mid);
        int rightMax = FindMaxSubArray(nums, mid + 1, right);
        int crossingMax = MaxCrossing(nums, left, right, mid);

        return Max(leftMax, rightMax, crossingMax);
    }

    int Max(params int[] values)
    {
        int maxValue = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] > maxValue)
            {
                maxValue = values[i];

            }

        }
        return maxValue;
    }

    int MaxCrossing(int[] nums, int left, int right, int mid)
    {
        int leftSum = int.MinValue;
        int rightSum = int.MinValue;

        int sum = 0;
        for (int i = mid; i >= left; i--)
        {
            sum += nums[i];
            leftSum = Max(leftSum, sum);
        }

        sum = 0;
        for (int i = mid + 1; i <= right; i++)
        {
            sum += nums[i];
            rightSum = Max(rightSum, sum);
        }

        return leftSum + rightSum;
    }
}