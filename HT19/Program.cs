// Принять на вход пятизначное число и проверить, является ли оно палиндромом

Console.WriteLine("Введите пятизначное натуральное число");
bool DigitN = int.TryParse(Console.ReadLine(), out int n);

if(!DigitN)
{
    Console.WriteLine("Ошибка! Вы ввели не то! ПереВВедите!");
    return;
}

int [] ara1 = ArrayOpposite(n);
int [] ara2 = ArrayForward(n);


int result = CheckNum();
if (result == 0)
{
    Console.WriteLine("Таки да, ПОЛИНДРОМ!!!");
}
else
{
    Console.WriteLine("Таки нет, НЕполиндром!!!");
}

int [] ArrayOpposite(int input)
{
    int[] ara1 = new int[5];
    for (int i = 0; i < 5; i++)
    {
        ara1[i] = input % 10;
        input /=10;
    }
    return ara1 ;
}

int [] ArrayForward(int input)
{
    int[] ara2 = new int[5];
    for (int i = 4; i >= 0; i--)
    {
        ara2[i] = input % 10;
        input /=10;
    }
    return ara2;
}
    
int CheckNum()
{
    int res = 0;
    for(int i = 0; i < 3; i++)
    {
        res = res + ara1[i] - ara2[i];
        // Console.WriteLine(res);
    }
    return res;
}