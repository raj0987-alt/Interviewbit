int solve(List<int> A, int B, int C)
{
    int result = 0;
    int day = B % 2;
    for (int i = 0; i < A.Count; i++)
    {
        if (A[i] % 2 != day)
        {
            result++;
        }
    }
    return result * C;
}

List<int> list = new List<int>();
//list.Add(0);
list.Add(1);
list.Add(2);
list.Add(3);
int B = 31;
int C = 100;
Console.WriteLine(solve(list, B, C));
