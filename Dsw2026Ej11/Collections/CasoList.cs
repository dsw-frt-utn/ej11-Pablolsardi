using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> _alumno = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        _alumno.Add(alumno);
    }

    public List<Alumno> ObtenerLista()
    {
        return _alumno;
    }

    public Alumno? BuscarAlumno(string nombre)
    {
        return _alumno.Find(a => a.Nombre == nombre);
    }

    public void EliminarAlumno(Alumno alumno)
    {
        _alumno.Remove(alumno);
    }

    public void EliminarPosicion(int posicion)
    {
        _alumno.RemoveAt(posicion);
    }
}
