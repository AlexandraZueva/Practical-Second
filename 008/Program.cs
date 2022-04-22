// 8 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int a = 7;

if (a >= 1 && a <= 7)
{
    if (a == 6 || a == 7)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}
else
{
    Console.WriteLine("error");
}
