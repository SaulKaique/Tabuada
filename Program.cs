
Console.WriteLine("......Tabuada do número.....:");
int numero = Convert.ToInt32(Console.ReadLine());

int vezes = 0;

int resultado;

while ( vezes <= 10 )
{
    resultado = numero * vezes ;

    Console.Write($"{numero} X {vezes} = {resultado}\n");
    vezes += 1;
};


