/*
* LeetCode Link: https://leetcode.com/problems/remove-element/description/
*/
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        // pointer used to point to the front of the index
        // in the end, it will point to the last index of the new array to be considered
        int k = 0;

        // loop through array checking if a num is not equal to the val
        // if it isn't move it to index k, increase k and move on
        // if it is equal to val, move past it and k will point at that index to replace it
        foreach (var num in nums) {
            if (num != val) {
                nums[k] = num;
                k++;
            }
        }

        return k;
    }
}