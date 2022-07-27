string[] name = { "akshay", "shreedhar", "pramod", "surya", "hari", "goutham", "simran", "arshit" };
foreach (string var in name)
{
    if (var.Contains("s") == true)
    {
        Console.WriteLine(var);
    }
}

int minLength = name.Min(y => y.Length);
var shortest = name.FirstOrDefault(x => x.Length == minLength);
Console.WriteLine(shortest);

string[] words1 = { "believe", "relief", "receipt", "field" };
foreach (string word in words1)
{
    Console.WriteLine(word + "--" + word.Length);
}

foreach (string var in words1)
{
    if (var.Contains("ie") == true)
    {
        Console.WriteLine(var);
    }
}
var result = name.Reverse();
Console.WriteLine(result);
foreach (var val in result)
{
    Console.WriteLine(val);
}

for (int i = 0; i < name.Length; i++)
{
    if(i%2 ==0)
    {
        Console.WriteLine(name[i]);
    }
}