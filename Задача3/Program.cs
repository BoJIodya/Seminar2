int Remains(int num1, int num2)
{
    int result = (num1 % num2);
    return result;
}
int a = 25;
int b = 5;
int Rem = Remains(a, b);

if (Rem == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.Write("Некратно, остаток ");
    Console.WriteLine(Rem);
}