Console.Write("enter number from 100 to 999: number = ");
int number = int.Parse(Console.ReadLine());

int result = ((number % 100) / 10) ;

System.Console.WriteLine($"Was {number}, Now {result}");