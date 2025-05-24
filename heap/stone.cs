public class Solution {

    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int,int>(Comparer<int>.Create((a,b) => b-a));
        foreach(int stone in stones){
            maxHeap.Enqueue(stone, stone);
        }

        while(maxHeap.Count > 1){
            int first = maxHeap.Dequeue();
            int second = maxHeap.Dequeue();

            if(first != second){
                maxHeap.Enqueue(first-second, first-second);
            }
        }
        
        return maxHeap.Count == 0 ? 0 : maxHeap.Dequeue();

    }
}