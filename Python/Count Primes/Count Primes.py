class Solution:
    def countPrimes(self, n: int) -> int:
        chk_prime = [True for i in range(n-1)]
        chk_prime.insert(0, False)
        for i in range(2, n):
            if(not chk_prime[i]):
                continue
            j = i*i
            while(j < n):
                chk_prime[j] = False
                j += i
        p_count = 0
        for i in range(n):
            if(chk_prime[i]):
                p_count += 1
        return p_count
