using System;
using System.Collections;

namespace Clase_ICDIA.EjemMascotas;
public class ProgramMascotas
{
    public ProgramMascotas()
    {
        ArrayList mascotas = new ArrayList();
        {
            // 1
            mascotas.Add(new Mascotas(1, "Martina", "Perra", "Chihuahua", true, 
                "Griselda", 8, true, 2.5, 30, "Tranquila"));
            
            // 2
            mascotas.Add(new Mascotas(2, "Alita", "Perra", "Mestiza", true,
                "Gloria", 4, true, 4.5, 40, "Brava"));
            
            // 3
            mascotas.Add(new Mascotas(3, "Bobi", "Perro", "Mestizo", false, 
                "Constancio", 7, false, 6, 55, "Docil"));
            
            // 4
            mascotas.Add(new Mascotas(4, "Pancho", "Conejo", "Silvestre", false,
                "Constancio", 2, false, 1.5, 20, "Come pan"));
            
            // 5
            mascotas.Add(new Mascotas(5, "Chesnut", "Perro", "Pastor Belga con Chihuahua", false,
                "Constancio", 6, false, 6, 55, "Fiel"));
            
            // 6
            mascotas.Add(new Mascotas(6, "Roni", "Gato", "Naranja", true,
                "Angel", 3, false, 1.5, 20, "Amigable"));
            
            // 7
            mascotas.Add(new Mascotas(7, "Loreto", "Loro", "Loro Tamaulipeco", false,
                "Domitila", 15, false, 0.6, 20, "Un poco salvaje"));
            
            // 8
            mascotas.Add(new Mascotas(8, "Choco", "Perro", "Mestizo", false,
                "Constancio", 10, false, 6.5, 55, "Come pan y naranja"));
            
            // 9
            mascotas.Add(new Mascotas(9, "Tilin / Rayito", "Perro", "Chihuahua", true,
                "Julieta", 1, false, 3, 30, "Cariñoso"));
            
            // 10
            mascotas.Add(new Mascotas(10, "Yogui", "Perro", "Pastor Aleman", true,
                "Constancio", 5, true, 40, 65, "Fiel"));
        }
        
        foreach (Mascotas mascota in mascotas)
        {
            Console.WriteLine(mascota);
        }
        Console.WriteLine();

        int edadReferencia = 5;
        Console.WriteLine("Mascotas con " + edadReferencia + " de edad");
        foreach (Mascotas mascota in mascotas)
        {
            if (mascota.Edad <= edadReferencia)
            {
                Console.WriteLine(mascota);
            }
        }
        Console.WriteLine();
    }
}