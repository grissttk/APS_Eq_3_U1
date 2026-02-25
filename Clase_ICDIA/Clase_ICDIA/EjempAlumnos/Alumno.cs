namespace Clase_ICDIA.EjempAlumnos;

public class Alumno
{
    private int matricula;
    private string nombre;
    private double promedio;

    #region Constructores
    public Alumno()
    {
        
    }

    public Alumno(int matricula)
    {
        this.matricula = matricula;
    }

    public Alumno(int matricula, string nombre, double promedio)
    {
        this.matricula = matricula;
        this.nombre = nombre;
        this.promedio = promedio;
        
    }
    #endregion

    public int Matricula
    {
        get => matricula;
        set => matricula = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public double Promedio
    {
        get => promedio;
        set => promedio = value;
    }

    public override string ToString()
    {
        string cad = "(" + matricula + ") " + nombre + " Promedio: " + promedio;
        return cad;
    }
}