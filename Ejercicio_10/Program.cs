Console.WriteLine("Ejercicio #10");
int[] numeros = { 5, 7, 8, 8};
int buscado;
Console.Write("Ingrese el valor a contar: ");
buscado = int.Parse(Console.ReadLine());

int contador = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == buscado)
    {
        contador++;
    }
}

Console.WriteLine($"El número {buscado} se repite {contador} veces");
