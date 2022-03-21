// See https://aka.ms/new-console-template for more information


int vocales = 0;
int contador_a = 0;
int contador_e = 0;
int contador_i = 0;
int contador_o = 0;
int contador_u = 0;
string texto = string.Empty;

Console.WriteLine("Ingrese una frase.");
texto = Console.ReadLine();


Console.WriteLine("=========================================");

if (texto.Count() <= 20)
{
    for (int i = 0; i < texto.Length; i++)
    {

        Console.WriteLine(texto[i].ToString().ToUpper());

        switch (texto[i].ToString().ToUpper())
        {
            case "A":
                vocales += 1;
                contador_a += 1;
                break;
            case "E":
                vocales += 1;
                contador_e += 1;
                break;
            case "I":
                vocales += 1;
                contador_i += 1;
                break;
            case "O":
                vocales += 1;
                contador_o += 1;
                break;
            case "U":
                vocales += 1;
                contador_u += 1;
                break;
        }
    }


    Console.WriteLine("Contador de A: {0}", contador_a);
    Console.WriteLine("contador de E: {0}  ", contador_e);
    Console.WriteLine("contador de I: {0} ", contador_i);
    Console.WriteLine("contador de O: {0}  ", contador_o);
    Console.WriteLine("contador de U: {0} ", contador_u);
    Console.WriteLine();
    Console.WriteLine("Cantidad de vocales: " + vocales);
}
else
{
    Console.WriteLine("ERROR.",vocales);
}


Console.ReadKey();