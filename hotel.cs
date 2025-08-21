using System;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

public class Suite
{
    public string Nome { get; set; }
    public double ValorDiaria { get; set; }

    public Suite(string nome, double valorDiaria)
    {
        Nome = nome;
        ValorDiaria = valorDiaria;
    }
}

public class Reserva
{
    public Pessoa Hóspede { get; set; }
    public Suite Suíte { get; set; }
    public int QuantidadeDias { get; set; }

    public Reserva(Pessoa hóspede, Suite suíte, int quantidadeDias)
    {
        Hóspede = hóspede;
        Suíte = suíte;
        QuantidadeDias = quantidadeDias;
    }

    public double CalcularValorTotal()
    {
        double valorTotal = Suíte.ValorDiaria * QuantidadeDias;

        // Aplica o desconto de 10% se a reserva for maior que 10 dias
        if (QuantidadeDias > 10)
        {
            valorTotal *= 0.9;  // Aplica 10% de desconto
        }

        return valorTotal;
    }

    public string ExibirInformacoesReserva()
    {
        return $"Hóspede: {Hóspede.Nome}\n" +
               $"Idade: {Hóspede.Idade}\n" +
               $"Suíte: {Suíte.Nome}\n" +
               $"Valor da Diária: R${Suíte.ValorDiaria:F2}\n" +
               $"Quantidade de dias: {QuantidadeDias}\n" +
               $"Valor Total: R${CalcularValorTotal():F2}";
    }
}

public class Program
{
    public static void Main()
    {
        // Criando uma pessoa (hóspede)
        Pessoa hóspede = new Pessoa("João Silva", 30);

        // Criando uma suíte
        Suite suíte = new Suite("Suíte Luxo", 200.00);

        // Criando uma reserva
        Reserva reserva = new Reserva(hóspede, suíte, 12);  // 12 dias de reserva

        // Exibindo as informações da reserva
        Console.WriteLine(reserva.ExibirInformacoesReserva());
    }
}
