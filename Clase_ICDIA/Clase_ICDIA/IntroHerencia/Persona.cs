namespace Clase_ICDIA.IntroHerencia;

public class Persona
{
    private string nombre;

    public Persona(string nombre)
    {
        this.nombre = nombre;
    }
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public void Saludar()
    {
        Console.WriteLine("Saludo como Persona");
    }
}