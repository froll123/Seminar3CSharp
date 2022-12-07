/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

void Polindrome(int number)
{
    if (number >= 10000)
    {
        int division1 = number / 10000;
        int ost1 = number % 10;
        if (division1 == ost1)
        {
            number = number / 10;
            int division2 = (number / 100) % 10;
            int ost2 = number % 10;
            if (division2 == ost2)
            Console.WriteLine("Да");
        }
        else
        Console.WriteLine("Нет");
    }
    else
    Console.WriteLine("Неправильное число: ");
}

Console.WriteLine("Введите значение: ");
int number = Convert.ToInt32(Console.ReadLine());
Polindrome(number);


/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

void Space (int x, int x1, int y, int y1, int z, int z1)
{
    double d = Math.Sqrt(Math.Pow((x1-x), 2) + Math.Pow((y1-y), 2) + Math.Pow((z1-z), 2));
    Console.WriteLine($"Расстояние: {Math.Round(d,3)}");
}
Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Space(x, x1, y, y1, z, z1);

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void Cube (int num)
{
    for (int num1 = 1; num1 <= num; num1++)
    {
        System.Console.Write(num1*num1*num1 + " ");
    }
    System.Console.WriteLine("Введите значение: ");    
}
int user = Convert.ToInt32(Console.ReadLine()); 
Cube(user);


