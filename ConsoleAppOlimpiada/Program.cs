using static System.Runtime.InteropServices.JavaScript.JSType;


Console.Write("Введи число N = ");

ushort i = 0;
ushort j = 1;
ushort p = 0;

ushort n = ushort.Parse(Console.ReadLine());


for (; ; )
{
    if (n <= 1 || n >= 100) break;
    if (p == 3)
    {
        //j = i;
        i -= 2;
        p = 0;
    }

    i += 1;
    p++;
    j++;
    //Console.Write(i + ", \n");
    if (n == i)
    {
        Console.Write($"Число  {n}, индекс {j - 1}\n\n");
    }
    if (i == 100) break;
}


try
{

    ushort n = ushort.Parse(Console.ReadLine());
    bool B = false;

    foreach (ushort x in nums)
    {
        if (x == n)
        {
            B = true;
            break;
        }
    }

    for (int i = 0; i < nums.Length; i++)
    {
        if (!B)
        {
            Console.WriteLine("Нету числа");
            break;
        }
        if (n >= 1 && n <= 100)
        {
            if (nums[i] == n) Console.WriteLine($"Индексы значений: {i + 1} \t числа {n}");
        }
    }
}
catch
{
    Console.WriteLine("Что-то пошло не так Денис Леонтьевич!");
}
finally
{
    Console.WriteLine("Lesson 1 completed");
}



//Lesson 2

uint foo(uint x)
{
    uint i = 1;
    uint j = 9;
    uint res = 0;

    for (; i * j < x; j *= 10, i++)
    {
        x -= j * i;
        res += j;
    }
    return res + x / i;
}

Console.Write("введи число: ");
try
{
    uint x = uint.Parse(Console.ReadLine());
    if (x > 1 && x < 10000) Console.WriteLine(foo(x + 3));
    else Console.WriteLine("Не соотв. условию");
}
catch
{
    Console.WriteLine("Ошибка");
}
finally
{
    Console.WriteLine("Lesson 2 completed");
}


////string s = x.ToString();

////for (int i = 0; i < s.Length; i++)
////{
////    Console.WriteLine(s[i]);

////}



////Lesson 4

string[] color = new string[] { "красный", "желтый", "зеленый", "желтый" };

string green = "зеленый";

try
{
    Console.Write("Вводи: ");
    ushort i = ushort.Parse(Console.ReadLine());
    ushort j = 0;

    ushort red = 0;
    ushort yellow = 0;
    while (i > 0)
    {
        //if (i <= 1 || i >= 100) break; // Not work
        if (j >= color.Length)
        {
            j = 0;
        }

        if (green == color[j]) i -= 1;

        if (color[j] == "красный") red += 1;

        if (color[j] == "желтый") yellow += 1;


        j++;
    }

    Console.WriteLine($"Кол-во красных = {red} \nКол-во желтых = {yellow}");
}

catch
{
    Console.WriteLine("ОШибка");
}



