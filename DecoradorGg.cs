// Clase con las fusiones usando Decorator y la clase Gogeta que como actua como Decorador.
public class DecoradorGg : FusionDeco
{
    public DecoradorGg(Personaje personaje1, Personaje personaje2) : base(personaje1, personaje2, $"{personaje1.ObtenerNombre()} + {personaje2.ObtenerNombre()} => Gogeta")
    {
    }
}