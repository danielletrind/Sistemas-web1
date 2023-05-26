namespace exercicio_01;
class Program
{
 static void Main(string[] args)
    {
       Animal a = new Animal();
        Homem h = new Homem();
          Cao c = new Cao();
         Gato g = new Gato();


        Console.WriteLine("Homem é: " + h.Fala());
        Console.WriteLine("Cão é: " + c.Fala());
        Console.WriteLine("Gato é: " + g.Fala());
    }
}