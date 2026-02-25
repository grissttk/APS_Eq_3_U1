namespace Clase_ICDIA.EjempAlumnos;

public class ProgramAlumno
{
    public ProgramAlumno()
    {
        Alumno nuevoAlumno = new Alumno();
        nuevoAlumno.Nombre = "Juan";
        nuevoAlumno.Matricula = 2;
        nuevoAlumno.Promedio = 6;
        
        Console.WriteLine(nuevoAlumno);
    }
}