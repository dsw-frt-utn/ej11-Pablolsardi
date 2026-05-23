using Dsw2026Ej11.Domain;
using System.Collections;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private readonly List<Libro> _libros = Libro.CrearLista();

    public Libro GetPrimero() => _libros.First();

    public Libro GetUltimo() => _libros.Last();

    public decimal GetTotalPrecios() => _libros.Sum(l=>l.Precio);

    public decimal GetPromedioPrecios() => _libros.Average(l=>l.Precio);

    public IEnumerable<Libro> GetListById() => _libros.Where(l=>l.Id>15);
    
    public IEnumerable<String> GetLibros() => _libros.Select(l => $"{l.Titulo} - {l.Precio:C}");

    public Libro? GetMayorPrecio() => _libros.MaxBy(l=>l.Precio);
    
    public Libro? GetMenorPrecio() => _libros.MinBy(l => l.Precio);

    public IEnumerable<Libro> GetMayorPromedio() => _libros.Where(l => l.Precio > GetPromedioPrecios());

    public IEnumerable<Libro> GetLibrosDescendentes() => _libros.OrderByDescending(l => l.Titulo);

    // IEnumerable, Vicente dijo de fijarnos si usar eso en vez de crear listas
    // IEnumerable != IEnumerator
}
