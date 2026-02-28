namespace Clase_ICDIA.NumComplejos;

public class ProgramOpNumComplejos
{
    public ProgramOpNumComplejos()
    {
        NumeroComplejo z1 = new  NumeroComplejo(2, 3);
        NumeroComplejo z2 = new NumeroComplejo(3, 4);

        NumeroComplejo zr = z1.Suma(z2); // Suma
        NumeroComplejo zr2 = z1.Resta(z2); // Resta
        NumeroComplejo zr3 = z1.Multiplicacion(z2); // Multiplicación
        NumeroComplejo zr4 = z1.Division(z2); // Disión
        
        Console.WriteLine(zr);
        Console.WriteLine(zr2);
        Console.WriteLine(zr3);
        Console.WriteLine(zr4);
    }
}