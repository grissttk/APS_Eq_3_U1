namespace Clase_ICDIA.IntroHerencia;

public class Alumno : Persona
{
    public Alumno(string nombre) : base(nombre)
    {
        
    }

    public void Saludar()
    {
        Console.WriteLine("Hola mi nombre es " + Nombre);
    }
}