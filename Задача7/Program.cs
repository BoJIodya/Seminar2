int schetNumbers(int num1) //преобразование логарифма в цельночисловой тип и подсчет значности числа
{
    int Count = (int)Math.Log10(num1) + 1;
    return Count;
}

int TherdNumbers(int num1, int num2) //нахождение первых трёх цифр числа
{
    int result = num1 / (int)Math.Pow(10, (num2 - 3));
    return result;
}

int a = 5725;

if (a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int Count = schetNumbers(a);
    int result = TherdNumbers(a, Count);

    int itog = result % 10; //это покажет третью цифру числа

    Console.WriteLine(itog);
}