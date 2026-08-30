public class Solution {
    public bool hasDuplicate(int[] nums) {

        HashSet<int> exists = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++){
            if(exists.Contains(nums[i])){
                return true;
            }

            exists.Add(nums[i]);
        }

        return false;
        
    }
}