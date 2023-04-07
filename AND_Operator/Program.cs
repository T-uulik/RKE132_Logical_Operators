Console.WriteLine("Enter your Math result:");
int math, bio, chem;
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chem = Int32.Parse(Console.ReadLine());

if(math >= 90 && bio >= 90 && chem >= 90)
{
    Console.WriteLine("Congratulations! You've been accepted!");
}
else
{
    Console.WriteLine("You didn't qualify for enrollment.");
}
Console.WriteLine("Have a nice day!");
