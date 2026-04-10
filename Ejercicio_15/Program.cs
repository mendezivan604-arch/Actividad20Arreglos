Console.WriteLine("Ejercicio #10");
int[] numeros = { 5, 7, 8, 8 };
Console.WriteLine("Números pares:");
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine(numeros[i]);
    }
}

Console.WriteLine("Números impares:");
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.WriteLine(numeros[i]);
    }
}
