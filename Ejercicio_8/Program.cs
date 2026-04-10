Console.WriteLine("Ejercicio #8");
int[] numeros = { 5, 7, 8, 9};
int contadorImpares = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 != 0)
    {
        contadorImpares++;
    }
}

Console.WriteLine($"Cantidad de números impares: {contadorImpares}");
