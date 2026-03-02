namespace Clase_ICDIA.Telefonos;

public class LogicaTelefonos
{
    public LogicaTelefonos()
    {
        List<Telefonos> listaTelefonos = new List<Telefonos>();

        listaTelefonos.Add(new Telefonos(1, "Apple", "iPhone 13 Pro Max", "iOS", 6.7, 4352, true, true, "Space Gray"));
        listaTelefonos.Add(new Telefonos(2, "Samsung", "Galaxy S21 Ultra", "Android", 6.8, 12000, true, true, "Phantom Black"));
        listaTelefonos.Add(new Telefonos(3, "Google", "Pixel 6 Pro", "Android", 6.7, 5000, true, true, "Stormy Black"));
        listaTelefonos.Add(new Telefonos(4, "OnePlus", "OnePlus 9 Pro", "Android", 6.7, 4500, true, true, "Pine Green"));
        listaTelefonos.Add(new Telefonos(5, "Xiaomi", "Mi 11 Ultra", "Android", 6.81, 5000, true, true, "Ceramic White"));
        listaTelefonos.Add(new Telefonos(6, "Sony", "Xperia 1 III", "Android", 6.5, 4500, true, true, "Frosted Black"));

        List<Telefonos> listaTelefonos2 = new List<Telefonos>();

        listaTelefonos2.Add(new Telefonos(1, "Apple", "iPhone 13 Pro Max", "iOS", 6.7, 4352, true, true, "Space Gray"));
        listaTelefonos2.Add(new Telefonos(2, "Samsung", "Galaxy S21 Ultra", "Android", 6.8, 12000, true, true, "Phantom Black"));
        listaTelefonos2.Add(new Telefonos(3, "Google", "Pixel 6 Pro", "Android", 6.7, 5000, true, true, "Stormy Black"));
        listaTelefonos2.Add(new Telefonos(4, "OnePlus", "OnePlus 9 Pro", "Android", 6.7, 4500, true, true, "Pine Green"));
        listaTelefonos2.Add(new Telefonos(5, "Xiaomi", "Mi 11 Ultra", "Android", 6.81, 5000, true, true, "Ceramic White"));
        listaTelefonos2.Add(new Telefonos(6, "Sony", "Xperia 1 III", "Android", 6.5, 4500, true, true, "Frosted Black"));

        Console.WriteLine("Lista de teléfonos:");
        // ordena la lista por marca
        OrdenamientoMarca ordenamiento = new OrdenamientoMarca();
        listaTelefonos.Sort(ordenamiento);
        //ordena la lista por modelo
        OrdenamientoModelo ordenamientoModelo = new OrdenamientoModelo();
        listaTelefonos2.Sort(ordenamientoModelo);

        Console.WriteLine("\nLista de teléfonos ordenada por Marca (ascendente):");

        foreach (Telefonos telefono in listaTelefonos)
        {
            Console.WriteLine(telefono);
        }

        Console.WriteLine("\nLista de teléfonos ordenada por Modelo (ascendente):");
        foreach (Telefonos telefono2 in listaTelefonos2)
        {
            Console.WriteLine(telefono2);
        }

    }
}