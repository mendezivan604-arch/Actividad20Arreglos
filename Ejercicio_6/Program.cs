Console.WriteLine("Ejercicio #6");
int cantidadnumeros;

while (true)
{
    Console.Write("Ingrese cantidad de numeros: ");
    if (int.TryParse(Console.ReadLine(), out cantidadnumeros) && cantidadnumeros > 0)
    {
        break;
    }
    Console.WriteLine("Cantidad de numeros inválida");
}

int[] numeros = new int[cantidadnumeros];
for (int i = 0; i < numeros.Length; i++)
{
    while (true)
    {
        Console.Write("Ingrese numero: ");
        if (int.TryParse(Console.ReadLine(), out numeros[i]) && numeros[i] > 0)
        {
            break;
        }
        Console.WriteLine("Número inválida");
    }

}

int menor = numeros[0];
for (int i = 1; i < numeros.Length; i++)
{
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}
Console.WriteLine($"Menor: {menor}");
