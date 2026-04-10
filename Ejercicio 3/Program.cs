Console.WriteLine("Ejercicio #3");
int cantidadnumeros;
int suma = 0;
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

Console.WriteLine($"La suma de los números ingresados es: {suma}");