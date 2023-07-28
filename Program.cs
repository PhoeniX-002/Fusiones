// Programa principal
public class Program {
    public static void Main()
    {
        SonGoku goku = new SonGoku();
        ReyVegeta vegeta = new ReyVegeta();
        SonGohan gohan = new SonGohan();
        Trunks trunks = new Trunks();
  
        // Se muestran los personajes presentes.
        Console.WriteLine("Nombre de los personajes:");
        Console.WriteLine("Personaje 1º => " + goku.ObtenerNombre());    // Goku
        Console.WriteLine("Personaje 2º => " + vegeta.ObtenerNombre());  // Vegeta
        Console.WriteLine("Personaje 3º => " + gohan.ObtenerNombre());   // Gohan
        Console.WriteLine("Personaje 4º => " + trunks.ObtenerNombre());  // Trunks
  
        // Proceden a realizar sus épicas fusiones.
        DecoradorGg gogeta = new DecoradorGg (goku, vegeta);
        DecoradorGt gotenks = new DecoradorGt (gohan, trunks);
  
        // Se procede a mostrar las fusiones de los personajes.
        Console.WriteLine("\nNombres de las fusiones:");
        Console.WriteLine(gogeta.ObtenerNombre());  // GokuVegeta => Gogeta
        Console.WriteLine(gotenks.ObtenerNombre()); // GohanTrunks => Gotenks
    }
}