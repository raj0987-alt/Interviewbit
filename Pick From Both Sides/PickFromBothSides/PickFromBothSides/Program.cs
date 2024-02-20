

List<int> A = new List<int>();
A.Add(5);
A.Add(-2);
A.Add(3);
A.Add(1);
A.Add(2);

int B = 3;

int max_sum = 0;
int current_sum = 0;

for(int i = 0;i<B;i++)
{
    current_sum += A[i];
}
max_sum = current_sum;

for (int i = B - 1, j = A.Count - 1; i >= 0; i--, j--)
{
    current_sum = current_sum - A[i] + A[j];
    max_sum = Math.Max(max_sum, current_sum);
}


Console.WriteLine(max_sum);