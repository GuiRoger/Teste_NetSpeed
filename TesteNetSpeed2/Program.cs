
int codigoAluno = 0;
decimal nota1 = 0, nota2 = 0, nota3 = 0, media = 0; ;
bool valorValidado = false;
bool continuar = false;
string valorDigitado =  String.Empty, statusAluno = String.Empty;
while (!continuar)
{

    
    Console.WriteLine("Digite o codigo do aluno e suas 3 notas.(separados por espaço)");

    while (!valorValidado)
    {
         valorDigitado = Console.ReadLine();
        if (!String.IsNullOrWhiteSpace(valorDigitado))
            valorValidado = true;
        else
            Console.WriteLine("Erro ao calcular as notas do aluno, digite algum valor:");

    }


    valorValidado = false;

    var informacoes = valorDigitado.Split(" ");

    codigoAluno = Convert.ToInt32( informacoes[0]);
    if (codigoAluno == 0)
    {
        break;
    }

   
    



    nota1 = Convert.ToDecimal(informacoes.Count() >= 2 ? informacoes[1].Replace(".",",") : 0);
    nota2 = Convert.ToDecimal(informacoes.Count() >= 3 ? informacoes[2].Replace(".", ",") : 0);
    nota3 = Convert.ToDecimal(informacoes.Count() >= 4 ? informacoes[3].Replace(".", ",") : 0);


    Console.WriteLine("=====================[RESULTADO]==========================");
    Console.WriteLine($"Aluno com o Código:{codigoAluno}");
    Console.WriteLine("Possuí as notas:");
    Console.WriteLine($"Primeira nota fornecida:{nota1}");
    Console.WriteLine($"Segunda nota fornecida:{nota2}");
    Console.WriteLine($"Terceira nota fornecida:{nota3}");
    media = Math.Round(Math.Round(nota1 + nota2 + nota3,3)/3,2);
    Console.WriteLine($"Sua média entre as 3 notas fornecidas é:{media}");
    statusAluno = media >= 6 ? "APROVADO" : "REPROVADO";
    Console.WriteLine($"Com base em sua média, o aluno foi {statusAluno}");
    Console.WriteLine("==========================================================");





}

