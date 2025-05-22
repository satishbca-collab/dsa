public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount < 0){
            return -1;
        }
        if(amount == 0){
            return 0;
        }
        int minCoins = int.MaxValue;
        foreach (int coin in coins)
        {
            int res = CoinChange(coins, amount - coin);
            if (res != -1)
                minCoins = Math.Min(minCoins, res + 1);
        }
        return minCoins == int.MaxValue ? -1 : minCoins;
    }
}