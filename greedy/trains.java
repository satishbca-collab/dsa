// User function Template for Java

class Solution {
    // Function to find the minimum number of platforms required at the
    // railway station such that no train waits.
    static int findPlatform(int arr[], int dep[]) {
        // add your code here
        Arrays.sort(arr);
        Arrays.sort(dep);

        int n = arr.length;
        int platformsNeeded = 1, maxPlatforms = 1;
        int i = 1, j = 0;
        // Tracking platform count using departure times
        while (i < n && j < n) {
            if (arr[i] <= dep[j]) {
                platformsNeeded++;
                i++;
            } else {
                platformsNeeded--;
                j++;
            }
            maxPlatforms = Math.max(maxPlatforms, platformsNeeded);
        }

        return maxPlatforms;
    }
}
