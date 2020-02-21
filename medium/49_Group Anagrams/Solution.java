class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        List<List<String>> retList = new ArrayList<List<String>>();
        if(strs==null || strs.length==0) return retList;
                
        Map<Long, List<String>> hm = new HashMap<Long, List<String>>();
        
        for(String s: strs){
            long hashCode = GetAnagramHashCode(s);
            List<String> temp;
            if(hm.containsKey(hashCode))
                temp = hm.get(hashCode);
            else
                temp = new ArrayList<String>();
            temp.add(s);
            hm.put(hashCode, temp);
        } 
        
        for(Map.Entry<Long, List<String>> entry : hm.entrySet()){
            retList.add(entry.getValue());
        }
        return retList;
    }
    
    private long GetAnagramHashCode(String s){
        int[] primeAlpha = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101};
        long hCode = 1;
        for(char c : s.toCharArray()){
            hCode *= primeAlpha[((int)c) - 97];
        }
        return hCode;
    }
}