class Solution {
    public int singleNonDuplicate(int[] nums) {
        int x = nums[0];
        for(int i=1;i<nums.length;i++){
            x ^=nums[i];
        }
        return x;
    }
}