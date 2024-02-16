int A = 100;
List<int> list = new List<int>();
for(int i  = 0; i <= A; i++)
{
    if(i<2)
    {
        list.Add(0);
    }
    else
    {
        list.Add(1);
    }
    
}
for(int i=2; i < list.Count; i++)
{
    if (list[i] != 1)
    {
        continue;
    }
    for (int j = i + i; j < list.Count; j += i)
    {
        list[j] = 0;
    }
}
List<int> ss = new List<int>();
for(int i = 0; i < list.Count; i++)
{
    if (list[i] == 1)
    {
        ss.Add(i);
    }
}

for (int i = 0;i<ss.Count;i++)
{
    Console.WriteLine(i+": "+ss[i]);
}