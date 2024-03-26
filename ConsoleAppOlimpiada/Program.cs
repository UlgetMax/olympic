using static System.Runtime.InteropServices.JavaScript.JSType;

//int[] nums = new int[] { 1, 2, 3, 2, 3, 4, 3, 4, 5, 4, 5, 6, 5, 6, 7 };

//Console.Write("Введи число N = ");

//try
//{
//    uint n = uint.Parse(Console.ReadLine());

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] == n)
//        {
//            Console.WriteLine($"Индексы значений: {i + 1} \t числа {n}");
//        }

//    }
//}
//catch
//{
//    Console.WriteLine("Что-то пошло не так Денис Леонтьевич!");
//}



//Lesson 2

//uint foo (uint x)
//{
//    uint i = 1;
//    uint j = 9;
//    uint res = 0;

//    for (; i * j < x; j *= 10, i++) 
//    {
//        x -= j * i;
//        res += j;
//    }
//    return res + x / i;
//}

//Console.Write("введи число: ");
//try
//{
//    uint x = uint.Parse(Console.ReadLine());

//    Console.WriteLine(foo(x + 3));
//}
//catch
//{
//    Console.WriteLine("Ошибка");
//}


//string s = x.ToString();

//for (int i = 0; i < s.Length; i++)
//{
//    Console.WriteLine(s[i]);

//}



//Lesson 4

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



