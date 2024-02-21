int A = 52;
string S = A.ToString();
int result = 1;
int d = 0;
List<string> list = new List<string>();
for (int i = 0; i < S.Length; i++)
{
    list.Add(S[i].ToString());



}
int da = 0;
for(int i = 0;i < list.Count;i++)
{
    da= Int32.Parse(list[i]);
    result *= da;
}
Console.WriteLine(result);