namespace Clase_ICDIA.Carros;

public class LogicaCarro
{
    public LogicaCarro()
    {
        Carro carro1 = new Carro(25, "Toyota", 2025);
        Carro carro2 = new Carro(30, "Chevrolet", 2026);
        Carro carro3 = new Carro(28, "Suzuki", 2020);

        Console.WriteLine("Resultado: ");
        
        List<Carro> carritos = new List<Carro>();
        carritos.Add(carro1);
        carritos.Add(carro2);
        carritos.Add(carro3);
        
        //carritos.Sort();
        
        //CarroOrdenamientoMarca ordMarca = new  CarroOrdenamientoMarca();
        //carritos.Sort(ordMarca);
        
        CarroOrdenamientoModelo ordModelo = new  CarroOrdenamientoModelo();
        carritos.Sort(ordModelo);
        
        Console.WriteLine("Ordenados por VIN:");
        foreach (Carro c in carritos)
        {
            Console.WriteLine(c);
        }
        
        
    }
}