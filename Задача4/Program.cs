int prov(int num1)
{
    int kratnost = 0;
    int result1 = num1 % 7;
    int result2 = num1 % 23;
    if (result1 == 0 && result2 == 0)
    {
        kratnost = 1;
    }
    else
    {
        kratnost = 0;
    }
    return kratnost;
}

int a = 161;

int kratnost = prov(a);

if (kratnost == 1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}