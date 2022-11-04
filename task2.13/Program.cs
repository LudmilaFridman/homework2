Console.Write("enter number = ");
int number = int.Parse(Console.ReadLine());

if(number < 100)
{
    Console.WriteLine("there is no third number");
}
else
{  
    string s = number.ToString();
    System.Console.WriteLine($"third number is {s[2].ToString()}");
}