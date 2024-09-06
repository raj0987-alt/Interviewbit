class Solution
{
    public int solve(List<int> A)
    {
        int count = 0;
        int N = A.Count;

        for (int i = 0; i < N; i++)
        {
            int j = A[i] - 1;  // Person i's best friend (0-indexed)
            if (i != j && A[j] - 1 == i)
            {
                count++;
            }
        }

        return count / 2;
    }
}
