//using FrequencyofCharacters;
//string data = "asdfrea";



//Solver solver = new Solver();
//solver.CalculateVal(data);
//foreach(var i in solver.ints)
//{
//    Console.WriteLine(i);
//}
////Console.WriteLine(solver.ints);
///



using FrequencyofCharacters;
///
List<int> solve(string A)
{
    List<int> ints = new List<int>()
{
    0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
};

    char[] charArray = A.ToCharArray();
    foreach (char ch in charArray)
    {
        if (ch >= 'a' && ch <= 'z')
        {
            int index = ch - 'a';  // Get the position in the alphabet
            ints[index]++;
        }
    }



    return ints;
}
solve("TAZIMUL");


//public List<int> solve(string A)
//{
//}