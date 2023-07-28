// Clase "Gotenks" que extiende a "FusionDeco" y a su vezactúa como decorador.
public class DecoradorGt : FusionDeco
{
    public DecoradorGt(Personaje personaje1, Personaje personaje2) : base(personaje1, personaje2, $"{personaje1.ObtenerNombre()} + {personaje2.ObtenerNombre()} => Gotenks")
    {
    }
}