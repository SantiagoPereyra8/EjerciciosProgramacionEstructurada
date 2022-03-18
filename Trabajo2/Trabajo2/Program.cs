// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Ingresar un numero y mostrar la potencial al cuadrado del mismo. El numero debe ser mayor que cero, en caso de error que aparezca el mensaje "ERROR.Reingresar numero"


int numero;

Console.WriteLine("ingrese un numero: ");
numero = int.Parse(Console.ReadLine());


if (numero < 1)
{
    Console.WriteLine("ERROR.Reingresar numero.");
}
else
{
    Console.Write("El numero: " + numero + " elevado al cuadrado es: ");
    Console.WriteLine(Math.Pow(numero, 2));
}

Console.ReadKey();


    




