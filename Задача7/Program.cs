int a = 258713658;

int Count = (int)Math.Log10(a) + 1; //преобразование логарифма в цельночисловой тип

int delit = (int)Math.Pow(10, (Count-3));
//Console.WriteLine(delit);

int result = a / delit;

int itog = result%10; //это покажет третью цифру числа
Console.WriteLine(result);
Console.WriteLine(itog);
//Console.WriteLine("5^4 = " + Math.Pow(5, 4));