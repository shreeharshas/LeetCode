public class Solution {
    public static void main(String[] args){
        int[][] coordinates = {{-4,-3},{1,0},{3,-1},{0,-1},{-5,2}};
        //int[][] coordinates = {{1,0},{3,-1},{0,-1},{-5,2}};
        System.out.println(checkStraightLine(coordinates));
    }

    public static boolean checkStraightLine(int[][] coordinates) {
        float slope  = -1;
        for(int i=1;i<coordinates.length;i++){
            //System.out.println(coordinates[i][0] + "," + coordinates[i][1]);
            float localSlope = (float)(coordinates[i][1] - coordinates[i-1][1])/(float)(coordinates[i][0] - coordinates[i-1][0]);
            //System.out.println(localSlope);
            if(slope==-1) slope = localSlope;
            if(slope!=localSlope) return false;
        }        
        return true;
    }
}