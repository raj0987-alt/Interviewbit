List<int> A = new List<int>()

int IsPerfect(List<int> D, int v)
{
    for(int j = 0; j < v;j++)
    {
        if (D[j] >=A[v])
        {
            return 0;
        }
    }
    for(int j = v+1; j < D.Count; j++) { 
        if (D[j] <= A[v])
        {
            return 0;
        }
    }
    return 1;
}