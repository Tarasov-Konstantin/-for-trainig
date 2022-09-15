Console.Clear();
int A = int.Parse(Console.ReadLine());
int res = A * A;
Console.Write($"{A} square is: ");
Console.WriteLine($"result 1 is {res}");
int sqr1 = Convert.ToInt32(Math.Pow(A,2));
Console.WriteLine($"result 2 is {sqr1}");