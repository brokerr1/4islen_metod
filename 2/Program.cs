// методом хорд найти наименьший положительный корень уравнения x^0.5 - cos(0.387x) = 0 с точность 0,0001. 
// Для решения задачи предварително построить график функции и выполнить отделение корней
double x0 = 1;
double x1 = 2;
double e = 0.0001;
double x = method_chord(x0, x1, e);
Console.WriteLine("Результат: {0}",x);
double method_chord(double x_prev, double x_curr, double e)
{
    double x_next = 0;
    double tmp;

    do
    {
        tmp = x_next;
        x_next = x_curr - f(x_curr) * (x_prev - x_curr) / (f(x_prev) - f(x_curr));
        x_prev = x_curr;
        x_curr = tmp;
    } while (Math.Abs(x_next - x_curr) > e);

    return x_next;
}
double f(double x)
{
    return Math.Pow(x,0.5) - Math.Cos(0.387 * x);
}