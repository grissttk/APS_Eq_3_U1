namespace Clase_ICDIA.CarroHerencia;

public class Carro
{
    private int numSerie;

    public int NumSerie
    {
        get { return numSerie; }
        set
        {
            if (value > 0)
            {
                numSerie = value;
            }
            else
            {
                
            }
        }
    }

    public Carro(int numSerie)
    { 
        NumSerie = numSerie;
    }

    public virtual void Arrancar()
    {
        Console.WriteLine("Arrancando...");
    }
}