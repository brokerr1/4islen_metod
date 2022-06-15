// Определить значения кореней системы уравнений методом Гаусса

double s = 0;
int n = 4; //размерность системы
double[,] a = new double[4, 4]{ { 8.2, -3.2, 14.2, 14.8 }, { 5.6, -12, 15, -6.4 }, { 5.7, 3.6, -12.4, -2.3 }, { 6.8, 13.2, -6.3, -8.7 } };
double[] b = new double[4] { -8.4, 4.5, 3.3, 14.3 };
double[] x = new double[n];
for (int i = 0; i < n; i++)
x[i] = 0;
// Console.WriteLine("Введите построчно коэффициенты системы: x1, x2, x3, x4");
// for (int i = 0; i < n; i++)
//     for (int j = 0; j < n; j++)
//     {
//         a[i, j] = double.Parse(Console.ReadLine());
//     }
// Console.WriteLine("Введите свободные коэффициенты: y1, y2, y3");
// for (int i = 0; i < n; i++)
//     b[i] = double.Parse(Console.ReadLine());
for (int k = 0; k < n - 1; k++)
{
    for (int i = k + 1; i < n; i++)
    {
        for (int j = k + 1; j < n; j++)
        {
            a[i, j] = a[i, j] - a[k, j] * (a[i, k] / a[k, k]);
        }
        b[i] = b[i] - b[k] * a[i, k] / a[k, k];
    }
}
for (int k = n - 1; k >= 0; k--)
{
    s = 0;
    for (int j = k + 1; j < n; j++)
        s = s + a[k, j] * x[j];
    x[k] = (b[k] - s) / a[k, k];
}    
Console.WriteLine("Система имеет следующие корни");
for (int i = 0; i < x.Length; i++)
{
    Console.WriteLine("x{0} = {1:0.##}",(i+1), x[i]);
}
