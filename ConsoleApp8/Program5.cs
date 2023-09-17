double x = 0;
double y = 0;
Console.WriteLine("Input x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y: ");
y = Convert.ToDouble(Console.ReadLine());
double con = (Math.Pow(x, 2) / 9) + (Math.Pow(y, 2) / 1);
if ((con <= 1 && y>=0) || (x >= -1 && x <= 1 && y <= 0 && y >= -2))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}