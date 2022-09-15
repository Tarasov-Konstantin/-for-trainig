Console.Clear();
Console.Write("Enter 3-digit number ");
int num = int.Parse(Console.ReadLine());

if (num < 100 || num > 999)
{Console.WriteLine("Number is not 3-digit");
return;}
int res = num%10;
Console.WriteLine($"The last digit is {res}");

