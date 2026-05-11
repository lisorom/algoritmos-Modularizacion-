using System;

class Program
{
    static void Main()
    {
        double saldo;
        double saca;

        Console.WriteLine("Cuanto saldo posee: ");
        saldo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese cantidad a retirar: ");
        saca = double.Parse(Console.ReadLine());

        Retirar(ref saldo, saca, out double plata);

        if (saldo < 0)
        {
            Console.WriteLine("Error al retirar un monto");
        }
        else
        {
            Console.WriteLine($"Su saldo actual es de {saldo}");
        }
    }
    static bool Retirar(ref double saldoActual, double montoRetirar, out double CantidadPlata)
    {
        if (montoRetirar <= saldoActual)
        {
            saldoActual -= montoRetirar;
            CantidadPlata = montoRetirar;
            Console.WriteLine($"La operacion fue exitosa, recibiste {montoRetirar} en billetes");
            return true;
        }
        else
        {
            CantidadPlata = 0;
            Console.WriteLine("sin plata");
            return false;
        }
    }
}
