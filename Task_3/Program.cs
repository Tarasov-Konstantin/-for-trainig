Console.Clear();
Console.Write("Enter the day of week number form 1 to 7: ");
int day = int.Parse(Console.ReadLine());
if (day == 1)
{Console.WriteLine("It is Monday");}
if (day == 2)
{Console.WriteLine("It is Tuesday");}
if (day == 3)
{Console.WriteLine("It is Wednesday");}
if (day == 4)
{Console.WriteLine("It is Thursday");}
if (day == 5)
{Console.WriteLine("It is Friday");}
if (day == 6)
{Console.WriteLine("It is Saturday");}
if (day == 7)
{Console.WriteLine("It is Sunday");}
if (day > 7 || day < 1)
{Console.WriteLine("Error. There only 7 days in a week");}