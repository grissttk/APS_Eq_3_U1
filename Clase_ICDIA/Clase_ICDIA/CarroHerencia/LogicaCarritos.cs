namespace Clase_ICDIA.CarroHerencia;

public class LogicaCarritos
{
    public LogicaCarritos()
    {
        Carro carro1 = new CarroAutomatico(23);
        Carro carro2 = new CarroManual(53);
        Carro carro3 = new CarroAutomatico(28);
        Carro carro4 = new CarroAutomatico(24);
        
        carro1.Arrancar();
        carro2.Arrancar();
        carro3.Arrancar();
        carro4.Arrancar();
    }
}