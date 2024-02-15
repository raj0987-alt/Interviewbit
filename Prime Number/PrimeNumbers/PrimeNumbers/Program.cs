int A = 100; 
int IsPrime(int num)
{
    if(num <2)
    {
        return 0;
    }
    for(int i = 2; i <= Math.Sqrt(num); i++)
    {
        if(num%i == 0)
        {
            return 0;
        }
    }
    return 1;
}
List<int> list = new List<int>();
for(int i = 0; i < A; i++)
{
    if(IsPrime(i) == 1)
    { list.Add(i); }
}

for(int i = 0;i < list.Count;i++)
{
    Console.WriteLine(list[i]);
}