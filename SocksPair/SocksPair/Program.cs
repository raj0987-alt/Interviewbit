using System.Linq;

 int solve(List<int> A)
{
    int result = 0;

    A.Sort();
    int i = 0;
    while (i< A.Count-1)
    {
        if (A[i] == A[i+1])
        {
            result++;
            i += 2;
        }
        else
        {
            i++; // Move to the next element
        }
    }
    return result;
}
List<int> B = new List<int>();
B.Add(2);
B.Add(2);
B.Add(2);
B.Add(2);
Console.WriteLine(solve(B));