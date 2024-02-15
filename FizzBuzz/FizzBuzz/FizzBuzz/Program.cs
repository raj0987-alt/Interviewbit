int A = 15;
List<string> list = new List<string>();

for (int i = 1; i <= A; i++)
{
  
    if(i%15 == 0)
    {
        list.Add("FizzBuzz");
    }
    else if(i%3 == 0)
    {
        list.Add("Fizz");
    }
    else if(i%5 == 0) {
        list.Add("Buzz");

    }
    else
    {
        list.Add(i.ToString());
    }
}

for(int i = 0;i < list.Count;i++)
{
    Console.WriteLine(list[i]);
}