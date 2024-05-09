/*
* LeetCode link: https://leetcode.com/problems/merge-sorted-array/description/
*/
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // if nums2 is empty, nothing to do
        if (n == 0) { return; }
        
        // pointer to the end of the nums1 array
        int endIndex = nums1.Length - 1;

        // initial loop
        while (n > 0 && m > 0) {

            // if end of nums2 is greater than or equal to end of nums1
            if (nums2[n-1] >= nums1[m-1]) {
                // insert nums2 value to the end of nums1
                nums1[endIndex] = nums2[n-1];
                // decrease n
                n--;
            }
            else {  // if nums1 is greater than nums2
                // insert nums1 value to the end of nums1
                nums1[endIndex] = nums1[m-1];
                // decrease m
                m--;
            }

            // decrease end pointer
            endIndex--;

        }

        // loop used if nums2 is not finished (n > m)
        while (n > 0) {
            // add the rest of the digits into nums1
            nums1[endIndex] = nums2[n-1];
            n--;
            endIndex--;
        }

        return;

    }
}