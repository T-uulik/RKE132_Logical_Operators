// math >= 90 OR chem >= 90 OR bio >= 90

int math, bio, chem;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chem = Int32.Parse(Console.ReadLine());

if((math >= 90 && bio  >= 90) || (math >= 90 && chem >= 90) || (chem >= 90 && bio >= 90))
    {
        Console.WriteLine("Congratulations! You've been accepted!");
    }
    else
    {
        Console.WriteLine("You didn't qualify for enrollment.");
    }
Console.WriteLine("Have a nice day!");