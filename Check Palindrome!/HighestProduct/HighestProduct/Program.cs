List<int> A = new List<int>();

A.Add(4);
A.Add(5);
A.Add(1);
A.Add(2);
A.Add(3);

A.Sort();
int n = A.Count;

int m1 = A[n - 1] * A[n - 2] * A[n-3];
int m2 = A[0] * A[1] * A[n - 1];

Console.WriteLine(Math.Max(m1, m2));