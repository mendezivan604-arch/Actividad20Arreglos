Console.WriteLine("Ejercicio #9");
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

int buscado;
Console.Write("Ingrese el número a buscar: ");
buscado = int.Parse(Console.ReadLine());

bool encontrado = false;


for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == buscado)
    {
        Console.WriteLine($"Número encontrado en la posición {i}");
        encontrado = true;
        break;
    }
}

if (!encontrado)
{
    Console.WriteLine("Número no encontrado");
}
