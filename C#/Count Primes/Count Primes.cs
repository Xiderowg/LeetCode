public class Solution {
    public int CountPrimes (int n) {
        int primeCount = 0;
        for (int i = 1; i < n; i++)
            if (IsPrime (i)) primeCount++;
        return primeCount;
    }

    public bool IsPrime (int n) {
        if (n <= 1) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }
}