class Solution {
    public List<String> letterCombinations(String digits) {
        Queue<String> q = new LinkedList<>();
        if(digits == null || digits.isEmpty()) return (List) q;
        
        Map<Character, String> hm = new HashMap<Character, String>(){{
            put('2', "abc");
            put('3', "def");
            put('4', "ghi");
            put('5', "jkl");
            put('6', "mno");
            put('7', "pqrs");
            put('8', "tuv");
            put('9', "wxyz");
        }};
        char ch = digits.charAt(0);
        for(char c : hm.get(ch).toCharArray()){
            q.add(Character.toString(c));
        }
        
        char[] ca = (digits.substring(1)).toCharArray();
        //debug 
        //for(int k=0;k<ca.length;k++) System.out.println(ca[k]);
        
        for(int i=0;i<ca.length;i++){
            String s= hm.get(ca[i]);
            int qlen = q.size();
            for(int j=0;j<qlen;j++){
                String a = q.remove();
                char[] cs = s.toCharArray();
                for(int l=0;l<cs.length;l++){
                    q.add(a + cs[l]);
                }
            }
        }
        
        return (List) q;
    }
}
