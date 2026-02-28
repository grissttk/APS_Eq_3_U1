using Clase_ICDIA.EjemMascotas;

namespace Clase_ICDIA.EjemPersona;

public class Persona
{
    private int ssn;
    private string nombre;
    private int edad;
    private bool tiene_mascota;
    private Mascotas mascota;

    #region CONSTRUCTORES

    public Persona()
    {

    }

    public Persona(int ssn, string nombre, int edad, bool tiene_mascota)
    {
        this.ssn = ssn;
        this.nombre = nombre;
        this.edad = edad;
        this.tiene_mascota = tiene_mascota;
    }

    // Constructor para comparaciones
    public Persona(int ssn)
    {
        this.ssn = ssn;
    }

    #endregion
    
    #region PROPIEDADES
public int Ssn
    {
        get => ssn;
        set => ssn = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Edad
    {
        get => edad;
        set => edad = value;
    }

    public bool TieneMascota
    {
        get => tiene_mascota;
        set => tiene_mascota = value;
    }

    public Mascotas Mascota
    {
        get => mascota;
        set => mascota = value;
    }
    #endregion

    public override string ToString()
    {
        string cad = "("+ssn+")-" + nombre + ". Tiene Mascota?: " + tiene_mascota;
        return cad;
    }
}