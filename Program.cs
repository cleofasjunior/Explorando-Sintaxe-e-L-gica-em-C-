using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double peso, valorPorQuilo;

        // Tenta ler e validar o peso. A entrada deve ser um número positivo.
        if (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out peso) || peso <= 0)
        {
            Console.WriteLine("Peso inválido. Insira um valor positivo.");
            return;
        }

        // Tenta ler e validar o valor por quilo. A entrada deve ser um número positivo.
        if (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out valorPorQuilo) || valorPorQuilo <= 0)
        {
            Console.WriteLine("Valor do frete por quilo inválido. Insira um valor positivo.");
            return;
        }

        // Calcula o valor total do frete.
        double total = peso * valorPorQuilo;
        
        // Exibe o resultado formatado com duas casas decimais.
        Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
    }
}
