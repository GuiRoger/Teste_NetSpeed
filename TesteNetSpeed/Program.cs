
//Variaveis
decimal valor = 0,pagar = 0,abate = 0,desconto = 0;
int ano = 0, carrosAntigos = 0,carrosGeral = 0;
string valorFornecido;
bool continuar = false;

Console.WriteLine("==========================================================");
Console.WriteLine("Forneça os valores requisitados a seguir para continuar.");
while (!continuar)
{
    Console.WriteLine("==========================================================");

    bool valorValido = false;

    
    while (!valorValido)
    {
        Console.WriteLine("Valor do carro:");
        valorFornecido = Console.ReadLine();

        if (String.IsNullOrEmpty(valorFornecido))
        {
            Console.WriteLine("Forneça um valor valido!(Valores decimais e inteiros são aceitos)");
        }
        else
        {
            valor = Convert.ToDecimal(valorFornecido);
            valorValido = true;
        }
    }
    valorValido = false;
    while (!valorValido)
    {

        Console.WriteLine("Ano de fabricação:");
        valorFornecido = Console.ReadLine();

        if (String.IsNullOrEmpty(valorFornecido))
        {
            Console.WriteLine("Forneça um valor valido!(Apenas valores inteiros são aceitos)");

        }
        else
        {
            ano = Convert.ToInt32(valorFornecido);
            valorValido = true;

        }

    }



    desconto = ano <= 2000  ?  12 : 7 ;
    abate =  valor * Math.Round( desconto/100,3);
    pagar = Math.Round(valor - abate,3);

    Console.WriteLine("==========================================================");

    Console.WriteLine($"O valor do desconto: {abate}");
    Console.WriteLine($"O valor total a pagar, com o desconto: {pagar}");

    Console.WriteLine("Calculo finalizado");
    Console.WriteLine("==========================================================");
    if (ano <= 2000)
        carrosAntigos = carrosAntigos + 1;
    else
        carrosGeral = carrosGeral + 1;

    Console.WriteLine("Deseja continuar?");
    continuar = Console.ReadLine().ToUpper() == "N" ? true : false;

   


}

Console.WriteLine("==========================================================");

Console.WriteLine($"Total de carros informados: {carrosGeral}");
Console.WriteLine($"Total de carros fabricados até 2000 informados: {carrosAntigos}");
Console.WriteLine("==========================================================");


