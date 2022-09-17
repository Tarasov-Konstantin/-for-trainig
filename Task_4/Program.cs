Console.Clear();
Console.Write("Enter any number: ");
int N = int.Parse(Console.ReadLine());
int Nstart = 0;
int Nend = 0;
if (Math.Abs(N) == N*(-1))
{Nstart = N;
Nend = N*(-1);}
else {Nstart = N*(-1);
Nend = N;}

while (Nstart <= Nend)
{
    Console.Write($"{Nstart} ");
    Nstart ++;
}
