using System;

class Program
{
    public static bool EsMayorDeEdad(int edad)
    {
        return edad >= 18;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese su edad: ");
        if (int.TryParse(Console.ReadLine(), out int edad))
        {

            if (edad >= 0)
            {
                bool esMayor = EsMayorDeEdad(edad);

                if (esMayor)
                {
                    Console.WriteLine("Es mayor de 18 años");
                }
                else
                {
                    Console.WriteLine("No es mayor de edad");
                }
            }
        }
    }
}
