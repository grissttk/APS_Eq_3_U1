namespace Clase_ICDIA.EjemMascotas;

public class Mascotas
{
    private int id_mascota;
    private string nombre;
    private string tipo_mascota;
    private string raza;
    private bool tiene_cartilla;
    private string nombre_cuidador;
    private int edad;
    private bool tiene_chip;
    private double peso;
    private double tamanio;
    private string rasgo_caracteristico;

    public Mascotas(int id_Mascota, string nombre, string tipo_mascota, string raza, bool tiene_cartilla,
     string nombre_cuidador, int edad, bool tiene_chip, double peso, double tamanio, string rasgo_caracteristico)
    {
        this.id_mascota = id_Mascota;
        this.nombre = nombre;
        this.tipo_mascota =  tipo_mascota;
        this.raza = raza;
        this.tiene_cartilla = tiene_cartilla;
        this.nombre_cuidador = nombre_cuidador;
        this.edad = edad;
        this.tiene_chip = tiene_chip;
        this.peso = peso;
        this.tamanio = tamanio;
        this.rasgo_caracteristico = rasgo_caracteristico;
    }

    public override string ToString()
    {
        string temporal = "(" + id_mascota + ")" + nombre + " - Cuidador: " + nombre_cuidador;

        return temporal;
    }

    public int Edad
    {
        get => edad;
        set => edad = value;
    }

    private double Peso
    {
        get => peso;
        set => peso = value;
    }

    private double Tamanio
    {
        get => tamanio;
        set => tamanio = value;
    }
}