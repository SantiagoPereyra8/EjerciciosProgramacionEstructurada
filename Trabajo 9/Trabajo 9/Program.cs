// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
    int numero;
    Console.WriteLine("ingrese un  numero.");
    numero = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i < numero ; i++)
    {
        if (i % 3 == 0)
            Console.Write(" {0} ", i);
        
    }
    Console.ReadKey();
    {
         
    }
}