// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
    int numero = 0;
    int positivo = 0;
    int negativo = 0;
    

    {
        Console.WriteLine("Ingrese un numero.");
        numero = Int32.Parse(Console.ReadLine());
       
        {

            
            if (numero > 0)
            {
                positivo = positivo + 1;
                Console.WriteLine("Su numero es positivo.");
                numero = Int32.Parse(Console.ReadLine());
            }
            else
            {
                negativo = negativo - 1;
                Console.WriteLine("Su numero es negativo.");
                numero = Int32.Parse(Console.ReadLine());
            }
            
                
                
                Console.ReadKey();
            
        }
    }
}

              


    


