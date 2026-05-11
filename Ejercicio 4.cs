Console.WriteLine("Ingrese el primer número:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero:");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer numero:");
double num3 = double.Parse(Console.ReadLine());


double max = ObtenerMaximo(num1, num2, num3);

Console.WriteLine($"El numero mas grande es: {max}");


static double ObtenerMaximo(double num1, double num2, double num3)
{
    if (num1 >= num2 && num1 >= num3)
    {
        return num1;
    }
    else if (num2 >= num3)
    {
        return num2;
    }
    else
    {
        return num3;
    }
}
