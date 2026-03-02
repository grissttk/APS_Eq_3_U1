namespace Clase_ICDIA.Telefonos;

public class OrdenamientoModelo : IComparer<Telefonos>
{
    public int Compare(Telefonos? x, Telefonos? y)
    {
        int v = x.Modelo.CompareTo(y.Modelo); // orden ascendente
        //int v = x.Modelo.CompareTo(y.Modelo) * -1; // orden descendente
        return v;
    }
}