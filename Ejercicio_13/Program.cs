Console.WriteLine("Ejercicio #13");

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

int[] arreglo1 = new int[cantidadnumeros];
int[] arreglo2 = new int[cantidadnumeros];

for (int i = 0; i < arreglo1.Length; i++)
{
    while (true)
    {
        Console.Write($"Ingrese número: ");
        if (int.TryParse(Console.ReadLine(), out arreglo1[i]))
        {
            break;
        }
        Console.WriteLine("Número inválido");
    }
}

for (int i = 0; i < arreglo1.Length; i++)
{
    arreglo2[i] = arreglo1[i];
}


Console.WriteLine("Arreglo original:");
for (int i = 0; i < arreglo1.Length; i++)
{
    Console.WriteLine(arreglo1[i]);
}

Console.WriteLine("Arreglo copia:");
for (int i = 0; i < arreglo2.Length; i++)
{
    Console.WriteLine(arreglo2[i]);
}
