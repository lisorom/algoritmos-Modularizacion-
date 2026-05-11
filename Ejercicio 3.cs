Console.WriteLine("Ponga su medida para calcular el area de su circulo:");

double radio = Convert.ToDouble(Console.ReadLine());

double resultArea = CalcularAreaCirculo(radio);

ImprimirResultado("del area", resultArea);

static double CalcularAreaCirculo(double radio)
{
    return 3.14159 * radio * radio;
}

static void ImprimirResultado(string resultado, double area)
{
    Console.WriteLine($"--- El resultado {resultado} es: {area} ---");
}
