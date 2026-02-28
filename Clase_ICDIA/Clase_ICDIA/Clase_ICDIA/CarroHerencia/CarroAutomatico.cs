namespace Clase_ICDIA.CarroHerencia;

public class CarroAutomatico : Carro
{
    public CarroAutomatico(int nSerie) : base(nSerie)
    {
        
    }

    public override void Arrancar()
    {
        Console.WriteLine("Carro Automatico Arranca...");
    }
    
}