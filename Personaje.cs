// Como clase Base está "Personaje".
public abstract class Personaje
{
    protected string nombre;
  
    public Personaje (string nombre)
    {
        this.nombre = nombre;
    }
  
    public string ObtenerNombre()
    {
        return this.nombre;
    }
}