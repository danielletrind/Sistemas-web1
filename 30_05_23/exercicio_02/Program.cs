namespace exercicio_02;
class Program
{
    static void Main(string[] args)
    {
        //Instância de cada classe filha
        Estadual prodEstadual = new Estadual();
        Nacional prodNacional = new Nacional();
        Importado prodImport = new Importado();

        //Instanciado valores 
        Console.WriteLine("Digite a descrição do Prod Estadual");
        prodEstadual.Descrição = Console.ReadLine();
        Console.WriteLine("Digite o Valor do Prod Estadual");
        prodEstadual.Valor = Convert.toDouble(Console.ReadLine());
        Console.WriteLine("Digite o Valor do Imposto Prod Estadual");
        prodEstadual.Imposto = Convert.toDouble(Console.ReadLine());

        Console.WriteLine("Valor do produto calculado com Imposto");
        Console.WriteLine(prodEstadual.calculaValor());

        //Instanciando valores para produtos Nacional
        Console.WriteLine("Digite a descrição do Prod Nacional");
        prodEstadual.Descrição = Console.ReadLine();
        Console.WriteLine("Digite o Valor do Prod Nacional");
        prodEstadual.Valor = Convert.toDouble(Console.ReadLine());
        Console.WriteLine("Digite o Valor do Imposto Prod Nacional");
        prodEstadual.Imposto = Convert.toDouble(Console.ReadLine());

        Console.WriteLine("Valor do produto calculado com Imposto");
        Console.WriteLine(prodEstadual.calculaValor());

    }
}
