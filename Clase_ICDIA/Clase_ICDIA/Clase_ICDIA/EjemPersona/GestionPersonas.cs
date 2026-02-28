using Clase_ICDIA.EjemMascotas;

namespace Clase_ICDIA.EjemPersona;

public class GestionPersonas
{
    public GestionPersonas()
    {
        Persona pp1 = new Persona();

        pp1.Ssn = 1234;
        pp1.Nombre = "John Doe";
        pp1.Edad = 16;
        pp1.TieneMascota =  true;

        Mascotas mascotita = new Mascotas(1, "Martina", "Perra", "Chihuahua", true,
            "Griselda", 8, true, 2.5, 30, "Tranquila");
    }
}