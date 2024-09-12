using System.Text;

string A = " hello   world ";
string[] words = A.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


var str = new StringBuilder();
for (int i = words.Length - 1; i >= 0; i--)
{
    str.Append(words[i]);
    if (i > 0)
    {
        str.Append(" ");
    }
}
Console.WriteLine("d:" + str.ToString() + ":d");