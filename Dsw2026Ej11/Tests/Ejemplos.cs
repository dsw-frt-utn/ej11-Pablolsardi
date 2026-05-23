using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Collections;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList _lista = new();
        _lista.AgregarAlumno(new Alumno(1, "Diego Luna", 9.1));
        _lista.AgregarAlumno(new Alumno(2, "Fabrizzio Lopez", 8.6));
        _lista.AgregarAlumno(new Alumno(3, "Ignacio Litninsky", 7.8));

        Console.WriteLine("=== LISTADO DE ALUMNOS ===");
        foreach (Alumno a in _lista.ObtenerLista())
            Console.WriteLine(a);

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Buscar: Diego Luna ===");
        Alumno? encontrado = _lista.BuscarAlumno("Diego Luna");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Buscar: Pablo Sardi ===");
        Alumno? noEncontrado = _lista.BuscarAlumno("Pablo Sardi");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Eliminar a: Diego Luna ===");
        _lista.EliminarAlumno(encontrado!);
        foreach (Alumno a in _lista.ObtenerLista())
            Console.WriteLine(a);
        
        Console.WriteLine("\n---------------------------------------------------------");
        
        Console.WriteLine("\n=== Eliminar pimera posición ===");
        _lista.EliminarPosicion(0);
        foreach (Alumno a in _lista.ObtenerLista())
            Console.WriteLine(a);

        Console.WriteLine("\n---------------------------------------------------------");

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary _dictionario = new();
        _dictionario.AgregarAlumno(56037, new Alumno(1, "Diego Luna", 9.1));
        _dictionario.AgregarAlumno(56450, new Alumno(2, "Fabrizzio Lopez", 8.6));
        _dictionario.AgregarAlumno(56710, new Alumno(3, "Ignacio Litninsky", 7.8));

        Console.WriteLine("=== LISTADO DE ALUMNOS ===");
        foreach (var par in _dictionario.ObtenerDiccionario())
            Console.WriteLine($"Legajo: {par.Key}: {par.Value}");

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Buscar legajo 56037 ===");
        Alumno? encontrado = _dictionario.BuscarAlumno(56037);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Buscar legajo 56123 ===");
        Alumno? noEncontrado = _dictionario.BuscarAlumno(56123);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Eliminar legajo 56710 ===");
        _dictionario.EliminarAlumno(56710);
        Console.WriteLine("\nLegajo 56710 eliminado");

        Console.WriteLine("\n\n=== LISTADO DE ALUMNOS ===");
        foreach (var par in _dictionario.ObtenerDiccionario())
            Console.WriteLine($"Legajo: {par.Key}: {par.Value}");

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq _linq = new();

        Console.WriteLine("=== Primer libro ===");
        Console.WriteLine(_linq.GetPrimero().Titulo);

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Último libro ===");
        Console.WriteLine(_linq.GetUltimo().Titulo);

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Total de precios ===");
        Console.WriteLine(_linq.GetTotalPrecios().ToString("C"));

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Promedio de precios ===");
        Console.WriteLine(_linq.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Libros con Id > 15 ===");
        foreach (Libro l in _linq.GetListById())
            Console.WriteLine($"{l.Id} - {l.Titulo}");

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Libros con título y precio ===");
        foreach (string s in _linq.GetLibros())
            Console.WriteLine(s);

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Libro más caro ===");
        Console.WriteLine(_linq.GetMayorPrecio());

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Libro más barato ===");
        Console.WriteLine(_linq.GetMenorPrecio());

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Libros con precio mayor al promedio ===");
        foreach (Libro l in _linq.GetMayorPromedio())
            Console.WriteLine($"{l.Titulo} - {l.Precio:C}");

        Console.WriteLine("\n---------------------------------------------------------");

        Console.WriteLine("\n=== Libros ordenados por título descendente ===");
        foreach (Libro l in _linq.GetLibrosDescendentes())
            Console.WriteLine(l.Titulo);
    }
}
