Console.Write("Enter your name ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Woohoo! It's Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}