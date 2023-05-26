﻿namespace exercicio_02;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuri cj = new ContratoPessoaJuri();

        cf.Telefone = "48228922";
        cf.Email = "danitrindade@gmail.com";
        cf.Nome = "Danielle";
        cf.Idade = 16;
        cf.Cpf = 24356870923;
        cj.Nome = "Etec";
        cj.Email = "etec3546@gmail.com";
        cj.Telefone = "12345678";
        cj.Cnpj = 35473859407621;
        cj.Inscricao = 243657890345;

        Console.WriteLine(cf.MostraDados());
        Console.WriteLine(cj.MostraDados());
    }
} 
