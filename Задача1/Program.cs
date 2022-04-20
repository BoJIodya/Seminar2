int N = new Random().Next(10, 100);
int a = N / 10;
int b = N % 10;

System.Console.WriteLine($"a = {a} b = {b} N = {N}");

int max = a;
if (b > max)
{
    max = b;
}
Console.WriteLine($"maximum = {max}");