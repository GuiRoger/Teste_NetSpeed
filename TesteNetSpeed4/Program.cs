

using System.ComponentModel.Design;
using TesteNetSpeed4;

DateTime vencimentoOriginal = new(), vencimentoNovo = new(), dataAtual;
double valorAntigo, valorRecalculado = 0, totalJuros = 0;
int totalDias = 0;

double multa = 2;
double jurosDia = 0.03;



Console.WriteLine("==========================================================");
Console.WriteLine("Informe os valores a seguir, para recalcular o valor do boleto.");
Console.WriteLine("==========================================================");

Console.WriteLine("\n");
Console.WriteLine("Informe a data de vencimentoOriginal (dd/mm/aaaa):");
vencimentoOriginal = DateTime.Parse(Console.ReadLine());

Console.WriteLine("\n");
Console.WriteLine("Informe a data de vencimentoOriginalNovo (dd/mm/aaaa):");
vencimentoNovo = DateTime.Parse(Console.ReadLine());

Console.WriteLine("\n");
Console.WriteLine("Informe o valor do boleto:");
valorAntigo = Convert.ToDouble(Console.ReadLine());

totalDias = Convert.ToInt32((vencimentoNovo - vencimentoOriginal).TotalDays);


if (vencimentoNovo < vencimentoOriginal)
{
    totalJuros = 0;
}else if (Validacoes.VerificaFeriado(vencimentoOriginal) || Validacoes.VerificaFinalDeSemana(vencimentoOriginal))
{
    if (vencimentoNovo.DayOfWeek == DayOfWeek.Monday  )
    {
        if (Validacoes.VerificaFeriado(vencimentoOriginal))
        {

            if (vencimentoOriginal.DayOfWeek == DayOfWeek.Friday && vencimentoNovo.DayOfWeek == DayOfWeek.Monday)
            {
                totalJuros = 0;
            }
            else
            {
                totalJuros = 0;

            }
        }
        else
        {

            totalJuros = 0;
        }
    }
    else
    {
        if (Validacoes.VerificaFinalDeSemana(vencimentoOriginal))
        {
            totalJuros = totalDias * jurosDia + jurosDia;
        }


        if (Validacoes.VerificaFeriado(vencimentoOriginal) && vencimentoNovo >= vencimentoOriginal.AddDays(2))
        {

            totalJuros = totalDias * jurosDia;
        }

        
    }


}
else
{
    totalJuros = totalDias * jurosDia;
}


if (totalJuros == 0)
{
    valorRecalculado = valorAntigo;

}
else
{
    valorRecalculado = valorAntigo + totalJuros + multa;
}


Console.WriteLine("Valor do boleto recalculado: R$ " + valorRecalculado);

if (totalJuros >0)
{
    Console.WriteLine("Valor total dos juros do período: R$ " + totalJuros);
    Console.WriteLine("Valor Multa: R$ " + multa);

}
else
{
    Console.WriteLine("Nenhum juros ou multa foi aplicado");
}


