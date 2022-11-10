//  Принять на ввод число N и выдать таблицу кубов от 1 до N. Выполнить в методе. 

Console.WriteLine("Введите число N");
bool isDigit = int.TryParse(Console.ReadLine(), out int n);

if(!isDigit)
{
    Console.WriteLine("Ошибка! Вы ввели не то что нужно. ПереВВедите!");
    return;
}

int [] result = GetTabCube(n);

PrintArrayCube(result);

void PrintArrayCube(int [] array)
{
    for(int i = 0; i < n; i++)
    {
        Console.WriteLine($"Куб {i + 1} равен {array[i]}");
    }
}

int [] GetTabCube(int n)
{
    int [] array = new int [n];
    for (int i = 0; i < n; i++)
    {
        array [i] = (i + 1)*(i + 1)*(i + 1);
    }
    return array;
}