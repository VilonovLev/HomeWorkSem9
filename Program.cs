
// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1
Console.WriteLine("Задача 64");
int num = Input("N -> 1\nВведите число N: ");
Console.WriteLine(allNaturalNum(num) + "\n");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Задача 66");
int startNum = Input("Введите первое натуральное число: ");
int EndNum = Input("Введите второе натуральное число: ");
if(EndNum > startNum)
{
    int temp = EndNum;
    EndNum = startNum;
    startNum = temp;
}
Console.WriteLine($"Сумма натуральных чисел от {EndNum} -> {startNum} = {SumNaturalNum(startNum,EndNum)}\n");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
Console.WriteLine("Задача 68");
int first = Input("Введите m: ");
int second = Input("Введите n: ");
Console.WriteLine($"Результат: {AckermannF(first,second)}\n");

//Методы
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

string allNaturalNum(int n)
{
    if(n == 1)
    {
    return "1";
    }
    else
    {
        return n + ", " + allNaturalNum(--n);
    }
}

int SumNaturalNum(int x, int y)
{
    if(x > y)
    {
        return x + SumNaturalNum(--x,y);
    }
    else
    {
        return x;
    }
}

int AckermannF (int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    if(m > 0 && n == 0)
    {
        return AckermannF(--m,1);
    }
    if(m > 0 && n > 0)
    {
        return AckermannF(m-1,AckermannF(m,--n));
    }
    return 1;
}