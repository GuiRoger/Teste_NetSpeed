
int a = 0, b = 0, c = 0;
string mens = String.Empty, valorInformado = string.Empty;



try
{
    Console.WriteLine("==========================================================");
    Console.WriteLine("Informe os lados do triângulo(Apenas números serão aceitos)");
    Console.WriteLine("==========================================================");

    Console.WriteLine("Informe o valor de (a):");
    a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o valor de (b):");
    b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o valor de (c):");
    c = Convert.ToInt32(Console.ReadLine());

    if ((a < b + c) && (b < a + c) && (c < a + b))
    {
        if (a == b && b == c)
        {
            mens = "Triângulo Equilátero.";
        }
        else
        {
            if (a == b || b == c || a == c)
            {
                mens = "Triângulo Isósceles.";
            }
            else
            {
                mens = "Triângulo Escaleno.";
            }
        }
    }
    else
    {
        mens = "Não é possivel formar um triângulo";
    }

    Console.WriteLine(mens);

}
catch (Exception ex)
{
    Console.WriteLine("Erro, valor invalido.");

}

// Testes e Respostas
// A -> "Não é possivel formar um triângulo"
// B -> "Triângulo Escaleno"
// C -> "Não é possível  formar um triângulo"
// D -> "Triângulo Equilátero"
// E -> "Triângulo Isósceles"


