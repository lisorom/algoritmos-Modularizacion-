
using System;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            { 5, 8, 3 },
            { 2, 9, 4 },
            { 7, 1, 6 }
        };

        int fila = 1;
        int columna = ColumnaDelMaximo(matriz, fila);
        Console.WriteLine($"En la fila {fila}, el maximo esta en la columna {columna}");
    }

    static int ColumnaDelMaximo(int[,] matriz, int fila)
    {
        int maximo = matriz[fila, 0];
        int columnaMax = 0;

        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            if (matriz[fila, j] > maximo)
            {
                maximo = matriz[fila, j];
                columnaMax = j;
            }
        }

        return columnaMax;
    }
}

