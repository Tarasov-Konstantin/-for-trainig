Console.Clear();
Console.WriteLine("Enter two digits A and B to check if B is square of A");
Console.Write("A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("B: ");
int B = int.Parse(Console.ReadLine());
if (B == A*A)
{Console.WriteLine("B is square of A");}
else
{Console.WriteLine("B is NOT square of A");}
