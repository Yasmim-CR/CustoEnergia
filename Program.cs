            double consumo = 0;
            double usoDiario = 0;
            double custoEnergia = 0;
            double custoMes = 0;

Console.WriteLine("Vamos Calcular seu Custo de Energia");

Console.WriteLine($"Digite Consumo do Aparelho (em kWh/mês): ");
     consumo = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine($"Digite as horas de uso por dia: ");
     usoDiario = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine($"Digite o Custo da Energia (em R$/kWh): ");
     custoEnergia = Convert.ToDouble(Console.ReadLine()!);

     custoMes = usoDiario * consumo * custoEnergia;
   Console.WriteLine($"Custo estimado (R$): {custoMes:C2}");