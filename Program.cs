Console.WriteLine("digite os seus gastos mensais");
decimal gastos = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("digite a porcentagem");
double porcentagem = Convert.ToDouble(Console.ReadLine());
decimal final=gastos  / Convert.ToDecimal(porcentagem/100);
Console.Write($"voce precisa ter um valor investido de ${final}");