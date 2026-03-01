namespace Clase_ICDIA.CarroHerencia;

public class CarroManual : Carro
{
    public CarroManual(int num_serie) : base(num_serie)
    {
        
    }

    public override void Arrancar()
    {
        Console.WriteLine("Carro Manual Arranca...");
    }
}