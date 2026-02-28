namespace Clase_ICDIA.Carros;

public class CarroOrdenamientoModelo : IComparer<Carro>
{
    public int Compare(Carro? x, Carro? y)
    {
        int v = x.Modelo - y.Modelo;
        //int v = x.Modelo.CompareTo(y.Modelo) * -1; // Los ordena alreves
        return v;
    }
}