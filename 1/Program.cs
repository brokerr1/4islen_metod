//На отрезке [1,2] методом бинарного деления найти корень уравнения -x^3 - x^2 + 10 = 0 с точность 0,001
Equa(0,1,0.001);
void Equa(double a, double b, double eps)
{
    double c, count = 0;
    if (b < a)
    {
        double temp = b;
        b = a;
        a = temp;
    }
    while (Math.Abs(b - a) > eps)
    {
        count = count + 1;
        c = (a + b) / 2;
        if (f(a) * f(c) < 0)
        {
            b = c;
        }
        else
        {
            a = c;
        }
    }
    Console.WriteLine("Значение: {0}",(a + b) / 2);
    Console.WriteLine("Количество итерации: {0}",count);
}
double f(double x)
{
    return Math.Pow(x, 4) + 2 * (Math.Pow(x, 3)) - x - 1;
}