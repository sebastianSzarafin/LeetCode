https://leetcode.com/problems/flood-fill/?envType=study-plan&id=algorithm-i

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(image[sr][sc] == color) return image;
        int oldColor = image[sr][sc];
        image[sr][sc] = color;
        if(sr + 1 < image.Length && image[sr + 1][sc] == oldColor) 
            FloodFill(image, sr + 1, sc, color);
        if(sr - 1 >= 0 && image[sr - 1][sc] == oldColor) 
            FloodFill(image, sr - 1, sc, color);
        if(sc + 1 < image[0].Length && image[sr][sc + 1] == oldColor) 
            FloodFill(image, sr, sc + 1, color);
        if(sc - 1 >= 0 && image[sr][sc - 1] == oldColor) 
            FloodFill(image, sr, sc - 1, color);
        return image;
    }
}
