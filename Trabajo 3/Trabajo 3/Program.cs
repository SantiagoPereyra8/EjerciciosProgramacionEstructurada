// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// De 10 numeros ingresados indicar cuantos son mayores a cero y cuantos son menores a cero.

int numero;
int may = 0, men = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un numero: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
    {
        may = may + 1;

        //Console.WriteLine("Numeros mayor que 0: " + numero);

    }
    else
    {
        men = men + 1;
        //Console.WriteLine("Numero menor que 0: " + numero);
    }
}


Console.WriteLine("Numeros mayores que 0: " + may + " Numeros menores que 0: " + men);
Console.ReadKey();