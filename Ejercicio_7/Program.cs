Console.WriteLine("Ejercicio #7");
int[] numeros = {5, 7, 8, 10};
int contadorPares = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        contadorPares++;
    }
}

Console.WriteLine($"Cantidad de números pares: {contadorPares}");
