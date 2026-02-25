namespace Clase_ICDIA.Carros;

public class CarroOrdenamientoMarca : IComparer<Carro>
{
    public int Compare(Carro? x, Carro? y)
    {
        int v = x.Marca.CompareTo(y.Marca);
        //int v = x.Marca.CompareTo(y.Marca) * -1; // Los ordena alreves
        return v;
    }
}