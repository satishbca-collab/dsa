public class Solution {
    public int MaxPoints(int[][] points) {
        int n = points.Length;
        if (n <= 2)
            return n;

        int ans = 0;

        foreach (var point1 in points)
        {
            Dictionary<double, int> slopeMap = new Dictionary<double, int>();
            double x1 = point1[0], y1 = point1[1];

            foreach (var point2 in points)
            {
                if (point2 == point1)
                    continue;

                double x2 = point2[0], y2 = point2[1];
                double slope;

                if (x2 - x1 == 0)
                {
                    // Vertical line, slope is treated as infinity
                    slope = double.MaxValue;
                }
                else
                {
                    // Calculate slope
                    slope = (y2 - y1) / (x2 - x1);
                }

                // Update slope frequency in the map
                if (!slopeMap.ContainsKey(slope))
                    slopeMap[slope] = 1;

                slopeMap[slope]++;
                ans = Math.Max(ans, slopeMap[slope]);
            }
        }

        return ans; // Add 1 to account for the initial point
    }
}