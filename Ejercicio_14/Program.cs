Console.WriteLine("Ejercicio #14");

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

for (int i = 0; i < numeros.Length - 1; i++)
{
    for (int j = i + 1; j < numeros.Length; j++)
    {
        if (numeros[i] > numeros[j])
        {
            
            int temp = numeros[i];
            numeros[i] = numeros[j];
            numeros[j] = temp;
        }
    }
}

Console.WriteLine("Arreglo ordenado de menor a mayor:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
