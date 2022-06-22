// Методом прямоугольника вычеслить интеграл от 0 до 1,2 (sin(-x^2 + 2)dx)/(2- cos(x^2)) с шагом 0.01
double result = IntegralPr(0, 1.2, 0.01);
Console.WriteLine($"Результат: {result}");
double IntegralPr(double a, double b, double h)
{
	double s = 0;
	for (double i = a; i < b - h; i += h)
    {
		s = s + (Math.Sin(-(f(i)+2))) / (2 - Math.Cos(f(i)));
	}
	return s;
}
double f(double x)
{
	return Math.Pow(x, 2);
}