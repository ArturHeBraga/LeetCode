public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        //Organizing the array so we can do just one loop
        Array.Sort(nums);
        //Loop to run the array
        for (int i = 0; i < nums.Length-1; i++) {
            if (nums[i] == nums[i + 1]) {
                return true;
                }
            }
        return false;
    }
}
