class Solution {
    public ArrayList<Integer> jobSequencing(int[] deadlines, int[] profits) {
        // code here
        int n = deadlines.length;
        Job[] jobs = new Job[n];

        // Step 1: Create job objects and sort them by profit in descending order
        for (int i = 0; i < n; i++) {
            jobs[i] = new Job(deadlines[i], profits[i]);
        }
        Arrays.sort(jobs, (a, b) -> b.profit - a.profit);

        // Step 2: Track available slots and schedule jobs
        boolean[] slot = new boolean[n];  // To track scheduled jobs
        int totalProfit = 0, countJobs = 0;

        for (Job job : jobs) {
            // Find the latest available slot before the deadline
            for (int j = Math.min(n, job.deadline) - 1; j >= 0; j--) {
                if (!slot[j]) {
                    slot[j] = true;   // Schedule job
                    totalProfit += job.profit;
                    countJobs++;
                    break;
                }
            }
        }
        return new ArrayList<>(Arrays.asList(countJobs, totalProfit));
    }
}

class Job {
    int deadline, profit;

    Job(int deadline, int profit) {
        this.deadline = deadline;
        this.profit = profit;
    }
}