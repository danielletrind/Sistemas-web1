namespace exercicio_02;
class ContratoPessoaJuri:Contrato
{
public long Inscricao {get;set;}

public long Cnpj {get;set;}


public override string MostraDados(){
          string Tudo = this.Nome + "-" + this.Email + "-" + this.Telefone + "-" + this.Cnpj + "-" + this.Inscricao;
          return Tudo;
    }
}