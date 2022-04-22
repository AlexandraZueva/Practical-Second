// 5. Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

int a=3;
int b=9;

if(a==b*b)
{
    Console.WriteLine("yes");
}
else
{
    if(b==a*a)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}
