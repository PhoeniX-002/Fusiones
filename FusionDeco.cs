// Clase "FusionDeco" extiende a la clase Base "Personaje".
public abstract class FusionDeco : Personaje
{
    protected Personaje Personaje1;
    protected Personaje Personaje2;

    public FusionDeco(Personaje personaje1, Personaje personaje2, string fusionName) : base(fusionName)
    {
        this.Personaje1 = personaje1;
        this.Personaje2 = personaje2;
    }
}