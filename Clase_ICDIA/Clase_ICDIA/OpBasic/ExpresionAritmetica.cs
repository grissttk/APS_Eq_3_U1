namespace Clase_ICDIA.OpBasic;

public class ExpresionAritmetica
{
    private int a;
    private int b;

    public ExpresionAritmetica(int  a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public int Suma()
    {
        return this.a + this.b;
    }

    public int Resta()
    {
        return this.a - this.b;
    }

    public int Multiplicacion()
    {
        return this.a * this.b;
    }

    public int Division()
    {
        return this.a / this.b;
    }
}