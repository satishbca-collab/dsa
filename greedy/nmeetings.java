class Solution {
    // Function to find the maximum number of meetings that can
    // be performed in a meeting room.
    public int maxMeetings(int start[], int end[]) {
        // add your code here
        int n = start.length;

        // Step 1: Create an array of meeting intervals
        int[][] meetings = new int[n][2];
        for (int i = 0; i < n; i++) {
            meetings[i][0] = start[i]; // Start time
            meetings[i][1] = end[i];   // End time
        }

        // Step 2: Sort meetings by end time (ascending order)
        Arrays.sort(meetings, Comparator.comparingInt(a -> a[1]));

        // Step 3: Greedy selection of non-overlapping meetings
        int count = 0;
        int lastEndTime = -1; // Start with an invalid end time

        for (int[] meeting : meetings) {
            if (meeting[0] > lastEndTime) { // Strictly greater condition
                count++;
                lastEndTime = meeting[1]; // Update last meeting end time
            }
        }

        return count;
    }
}
