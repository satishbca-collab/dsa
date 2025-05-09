public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
        // Sort people by height in descending order
        // For people with the same height, sort by k value in ascending order
        Array.Sort(people, (a, b) => {
            if (a[0] == b[0]) {
                return a[1] - b[1]; // If heights are equal, sort by k value
            }
            return b[0] - a[0]; // Sort by height in descending order
        });
        
        // Create a list to build our result
        List<int[]> result = new List<int[]>();
        
        // Insert each person at their k position
        foreach (var person in people) {
            result.Insert(person[1], person);
        }
        
        return result.ToArray();
    }
}