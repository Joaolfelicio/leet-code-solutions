class Solution {
    public int[] twoSum(int[] nums, int target) {
        
        HashMap<Integer, Integer> hashMap = new HashMap<Integer, Integer>();
        
        for(int i = 0; i < nums.length; i++) {
            
            if(hashMap.containsKey(nums[i])) {
                return new int[]{hashMap.get(nums[i]), i};
            }
            
            hashMap.put(target - nums[i], i);
        }
        
        return null;
    }
}