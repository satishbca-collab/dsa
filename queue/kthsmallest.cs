//{ Driver Code Starts
//Initial Template for Java

import java.util.*;
import java.lang.*;
import java.io.*;
class GFG
{
    public static void main(String[] args) throws IOException
    {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int T = Integer.parseInt(br.readLine().trim());
        while(T-->0)
        {
            String num = br.readLine().trim();
            int k = Integer.parseInt(br.readLine().trim());
            Solution ob = new Solution();
            String ans = ob.kthSmallestNumber(num, k);
            System.out.println(ans);            
        }
    }
}

// } Driver Code Ends


//User function Template for Java

class Solution
{
    public String kthSmallestNumber(String num, int k)
    {
        // Code here
        int[] freq = new int[10];
        StringBuilder finalNum = new StringBuilder();

        Arrays.fill(freq, 0); // Initialize frequency array
        int n = num.length();

        // Calculate digit frequencies
        for (int i = 0; i < n; i++) {
            freq[num.charAt(i) - '0']++;
        }

        // Find the smallest digit greater than '0'
        char smallestDigit = getSmallDgtGreaterThanZero(num, n);
        finalNum.append(smallestDigit);

        freq[smallestDigit - '0']--;

        // Build the remaining digits in ascending order
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < freq[i]; j++) {
                finalNum.append((char) (i + '0'));
            }
        }

        // Generate the k-th smallest permutation
        for (int i = 1; i < k; i++) {
            nextPermutation(finalNum);
        }

        return finalNum.toString();
    }
    
    // Helper method to generate the next lexicographical permutation
    private static void nextPermutation(StringBuilder num) {
        int n = num.length();
        int i = n - 2;

        // Find the first decreasing element from the right
        while (i >= 0 && num.charAt(i) >= num.charAt(i + 1)) {
            i--;
        }

        if (i >= 0) {
            // Find the next larger element to swap
            int j = n - 1;
            while (num.charAt(j) <= num.charAt(i)) {
                j--;
            }

            swap(num, i, j);
        }

        // Reverse the remaining elements
        reverse(num, i + 1, n - 1);
    }
    
    // Helper method to swap two characters in the StringBuilder
    private static void swap(StringBuilder num, int i, int j) {
        char temp = num.charAt(i);
        num.setCharAt(i, num.charAt(j));
        num.setCharAt(j, temp);
    }

    // Helper method to reverse a portion of the StringBuilder
    private static void reverse(StringBuilder num, int start, int end) {
        while (start < end) {
            swap(num, start++, end--);
        }
    }
    
    // Method to get the smallest digit greater than '0'
    public static char getSmallDgtGreaterThanZero(String num, int n) {
        char smallestDigit = '9';

        for (int i = 0; i < n; i++) {
            if (num.charAt(i) < smallestDigit && num.charAt(i) != '0') {
                smallestDigit = num.charAt(i);
            }
        }

        return smallestDigit;
    }
}