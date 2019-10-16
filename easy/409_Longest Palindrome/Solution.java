class Solution {
    public int longestPalindrome(String s) {
        int[] counts = new int[128];
        int sum=0;
        boolean isOddPresent = false;
        
        for(int i=0;i<s.length();i++){
            counts[s.charAt(i)]++;
        }
        
        for(int j=0;j<counts.length;j++){
            if(counts[j]%2==0){
                sum+=counts[j];
            }
            else
            {
                sum+=counts[j]-1;
                isOddPresent = true;
            }
        }
        return sum+(isOddPresent?1:0);
    }
}