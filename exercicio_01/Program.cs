namespace exercicio_01;

class Program
{
    static void Main(string[] args)
    {
        Animal A = new Animal();
        Homem H = new Homem();
        Gato G = new Gato();
        Cão C = new Cão();

        Console.WriteLine("A fala do homem é: " + h.Fala());
        Console.WriteLine("A fala do cão é: " + c.Fala());
        Console.WriteLine("A fala do gato é: " + g.Fala());
        
    }
}
