using System.Text;

string solve(string A)
{
    StringBuilder result = new StringBuilder();
    int len = A.Length;

    for (int i = 0; i < len; i++)
    {
        if (char.IsLower(A[i]))
        {
            result.Append(char.ToUpper(A[i]));
        }
        else
        {
            result.Append(char.ToLower(A[i]));
        }
    }

    return result.ToString();
}