public class Solution {
    public class TrieNode
    {
        public TrieNode[] Children = new TrieNode[2]; // 0 and 1
    }

    public int FindMaximumXOR(int[] nums)
    {
        TrieNode root = new TrieNode();

        // Helper function to insert numbers into the Trie
        void Insert(int num)
        {
            TrieNode node = root;
            for (int i = 31; i >= 0; i--)
            {
                int bit = (num >> i) & 1; // Extract i-th bit
                if (node.Children[bit] == null)
                {
                    node.Children[bit] = new TrieNode();
                }
                node = node.Children[bit];
            }
        }

        // Helper function to find the maximum XOR for a number
        int GetMaxXOR(int num)
        {
            TrieNode node = root;
            int maxXOR = 0;
            for (int i = 31; i >= 0; i--)
            {
                int bit = (num >> i) & 1; // Extract i-th bit
                int oppositeBit = 1 - bit; // Try to maximize XOR
                if (node.Children[oppositeBit] != null)
                {
                    maxXOR = (maxXOR << 1) | 1; // Add 1 to maxXOR
                    node = node.Children[oppositeBit];
                }
                else
                {
                    maxXOR = (maxXOR << 1); // Add 0 to maxXOR
                    node = node.Children[bit];
                }
            }
            return maxXOR;
        }

        // Build the Trie
        foreach (int num in nums)
        {
            Insert(num);
        }

        // Find the maximum XOR for all pairs
        int result = 0;
        foreach (int num in nums)
        {
            result = Math.Max(result, GetMaxXOR(num));
        }

        return result;
    }
}
