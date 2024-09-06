using System.Text;

int solve(int A)
{
    int result = 0;
    var str = A.ToString();
    int len = str.Length;
    for (int i = 0; i < len; i++)
    {

        int digit = str[i] - '0';
        result += (int)Math.Pow(digit, len);
    }
    if (result == A)
    {
        return 1;  // Armstrong number
    }
    else
    {
        return 0;  // Not an Armstrong number
    }
}


Console.WriteLine(solve(371));