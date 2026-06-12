using System;

int[,] matriz = new int[3 , 3];
int numeros = 2;


for (int i = 0; i < matriz.GetLength(0); i++) 
{
    for (int j = 0; j < matriz.GetLength(0); i++) 
    {

        matriz [i,j] = numeros;
        numeros++;

        if (j % 2 != 0)
        {
            matriz[i, j] = numeros++;
            numeros++;
        }
    }
}


