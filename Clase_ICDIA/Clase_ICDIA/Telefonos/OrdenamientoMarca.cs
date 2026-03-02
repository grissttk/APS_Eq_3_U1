namespace Clase_ICDIA.Telefonos;

public class OrdenamientoMarca : IComparer<Telefonos>
{
    public int Compare(Telefonos? x, Telefonos? y)
    {
        int v = x.Marca.CompareTo(y.Marca); // orden ascendente
        //int v = x.Marca.CompareTo(y.Marca) * -1; // orden descendente
        return v;
    }
}