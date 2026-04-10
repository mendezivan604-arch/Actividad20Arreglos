Console.WriteLine("Ejercicio #1");
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

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}