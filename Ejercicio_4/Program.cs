Console.WriteLine("Ejercicio #4");
int cantidadnumeros;
double suma = 0;
double promedio;
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
    suma += numeros[i];
}
promedio = suma / cantidadnumeros;
Console.WriteLine($"El promedio es: {promedio}");
