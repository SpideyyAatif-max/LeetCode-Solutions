public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        int totaltime = 0;
        int gap = 0;
        for(int i=0;i<timeSeries.Length-1;i++)
        {
            gap = timeSeries[i+1] - timeSeries[i];
            totaltime+=Math.Min(duration,gap);
        }
        totaltime += duration;
        return totaltime;
    }
}