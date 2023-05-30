namespace exercicio_02;
class Produto
{
  public string? Descriçao {get;set}  
  public string? Valor {get;set}  
  public string? Imposto {get;set}  

  public virtual double calculaValor(){
    double imp = (1+(this.Valor/100));
    return this.Valor*imp;
  }
}
