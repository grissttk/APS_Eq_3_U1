namespace Clase_ICDIA.OpBasic;

public class ProgramOpA
{
    public ProgramOpA()
    {
        ExpresionAritmetica expr; //Declara el objeto
        expr = new ExpresionAritmetica(6, 2);
        
        int resultado = expr.Suma();
        Console.WriteLine(resultado);
        
        int resultado2 = expr.Resta();
        Console.WriteLine(resultado2);
        
        int resultado3 = expr.Multiplicacion();
        Console.WriteLine(resultado3);
        
        int resultado4 = expr.Division();
        Console.WriteLine(resultado4);
    }
}