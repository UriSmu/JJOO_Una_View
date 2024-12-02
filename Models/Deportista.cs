using System;
namespace JJOO_Una_View.Models;

public class Deportista
{

    public string Apellido {get; set;}
    
    public string Nombre {get; set;}

    public DateTime FechaNacimiento {get; set;}

    public string Foto {get; set;}

    public int IdPais {get; set;}
    
    public int IdDeportes {get; set;}

    public int IdDeportistas {get; set;}
    public int CalificacionOlimpica {get; set;}
    public Deportista () {}

    public Deportista (string apellido, string nombre, DateTime fechanacimiento, string foto, int pais, int deporte, int id, int calificacion)
    {
        Apellido = apellido;
        Nombre = nombre;
        FechaNacimiento = fechanacimiento;
        Foto = foto; 
        IdPais = pais;
        IdDeportes = deporte;
        IdDeportistas = id;
        CalificacionOlimpica = calificacion;
    }
}