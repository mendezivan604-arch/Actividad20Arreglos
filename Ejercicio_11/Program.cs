Console.WriteLine("Ejercicio #11");
int[] numeros = { 5, 7, 8, 8 };
int posicion;
while (true)
{
    Console.Write($"Ingrese la posición a reemplazar (0 a {numeros.Length - 1}): ");
    if (int.TryParse(Console.ReadLine(), out posicion) && posicion >= 0 && posicion < numeros.Length)
    {
        break;
    }
    Console.WriteLine("Posición inválida");
}


int nuevoValor;
while (true)
{
    Console.Write("Ingrese el nuevo valor: ");
    if (int.TryParse(Console.ReadLine(), out nuevoValor))
    {
        break;
    }
    Console.WriteLine("Valor inválido");
}


numeros[posicion] = nuevoValor;
Console.WriteLine("Arreglo actualizado:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i] + " ");
}
