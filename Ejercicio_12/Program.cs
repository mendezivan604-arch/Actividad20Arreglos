Console.WriteLine("Ejercicio #12");

int cantidadnumeros;


while (true)
{
    Console.Write("Ingrese la cantidad de números: ");
    if (int.TryParse(Console.ReadLine(), out cantidadnumeros) && cantidadnumeros > 0)
    {
        break;
    }
    Console.WriteLine("Cantidad inválida");
}

int[] numeros = new int[cantidadnumeros];
for (int i = 0; i < numeros.Length; i++)
{
    while (true)
    {
        Console.Write($"Ingrese número: ");
        if (int.TryParse(Console.ReadLine(), out numeros[i]))
        {
            break;
        }
        Console.WriteLine("Número inválido");
    }
}


Console.WriteLine("Números positivos:");
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] > 0)
    {
        Console.WriteLine(numeros[i]);
    }
}