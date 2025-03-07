// https://leetcode.com/problems/closest-prime-numbers-in-range/?envType=daily-question&envId=2025-03-07

public class Solution {
    public static bool isPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));
            
        for (int i = 3; i <= boundary; i += 2){
            if (number % i == 0){
                return false;
            }
        }
        
        return true;        
    }


    public int[] ClosestPrimes(int left, int right) {
        int fp = left;
        int sp = left + 1;

        List<int> pnb = new List<int>();
        for(int i = fp; i <= right; i++){
            if(isPrime(i)){
                pnb.Add(i);
            }
        }
        
        

        bool wasFound = false;
        if(pnb.Count >= 2){
            wasFound = true;
            int smallestgap = 0;
            int tmp = pnb[1] - pnb[0];
            for(int i = 0; i < pnb.Count - 1; i++){
                if((pnb[i+1] - pnb[i]) < tmp){
                    tmp = pnb[i+1] - pnb[i];
                    smallestgap = i;
                }
            }
            fp = pnb[smallestgap];
            sp = pnb[smallestgap + 1];
        }

        int[] r = [-1, -1];
        if(wasFound){
            r[0] = fp;
            r[1] = sp;
        }
        return r;
    }
}
