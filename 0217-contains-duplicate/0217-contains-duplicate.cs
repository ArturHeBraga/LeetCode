public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        //Variable declaring
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
