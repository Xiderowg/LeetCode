public class Solution {
    public int MySqrt (int x) {
        if (x <= 1)
            return x;
        double assume = x / 2, err = 0.01;
        while (Math.Abs (Math.Pow (assume, 2) - x) > err) {
            assume = (assume + x / assume) / 2;
        }
        return (int) Math.Floor (nearx);
    }
}