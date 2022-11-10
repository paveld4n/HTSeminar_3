// Принять на вход пятизначное число и проверить, является ли оно палиндромом
Console.WriteLine("Введите пятизначное натуральное число");
bool DigitN = int.TryParse(Console.ReadLine(), out int n);

if(!DigitN)
{
    Console.WriteLine("Ошибка! Вы ввели не то! ПереВВедите!");
    return;
}

int [] ara2 = ArrayForward(n);


bool result = CheckNum();
if (result == true)
{
    Console.WriteLine("Таки да, ПОЛИНДРОМ!!!");
}
else
{
    Console.WriteLine("Таки нет, НЕполиндром!!!");
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
    
bool CheckNum()
{
    return ara2[0] == ara2[^1] && ara2[1] == ara2[^2];
}