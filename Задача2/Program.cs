int N = 123;
int a = (N / 10) % 10;

if (N >= 100 && N <= 999)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Число не является трёхзначным");
}