int A = 51;
List<string> list = new List<string>();
int t = 0;
for (int i = 0; i < A; i++)
{
    t = i + 1;
    if(t%3 == 0 && t%5 == 0)
    {
        list.Add("FizzBuzz");
    }
    else if(t%3 == 0)
    {
        list.Add("Fizz");
    }
    else if(t%5 == 0) {
        list.Add("Buzz");

    }
    else
    {
        list.Add(t.ToString());
    }
}

for(int i = 0;i < list.Count;i++)
{
    Console.WriteLine(list[i]);
}