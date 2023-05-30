namespace exercicio_02;
class Importado:Produto
{
   public double Taxa {get;set;} 
   public double TaxaImport {get;set;}

    public override double calculaValor()
    {
        double tx = (1+(this.Taxa/100));
        double tximp = (1+(this.TaxaImport/100));
        return base.calculaValor()+(this.Valor*tx)+(this.Valor*tximp);
    }
}