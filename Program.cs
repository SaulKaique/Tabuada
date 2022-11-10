    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Magenta;


    Console.Write("......Tabuada do número.....:");
    int numero = Convert.ToInt32(Console.ReadLine());

    int vezes = 0;

    int resultado;
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkGreen;


while ( vezes <= 10 )
{
    resultado = numero * vezes ;

    Console.Write($"{numero} X {vezes} = {resultado}\n");
    vezes += 1;
};




    Console.ResetColor();


