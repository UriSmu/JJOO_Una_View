using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JJOO_Una_View.Models;

namespace JJOO_Una_View.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

/*
CREAR UNA VIEW QUE MUESTRE TODOS LOS DEPORTES, QUE SE PUEDAN VER MAS DETALLES DE CADA UNO.
EN + DETALLES, SE DEBEN MOSTRAR LOS DEPORTISTAS, DE LOS CUALES DEBE PODER VERSE + INFORMACION.
EN ESTA INFORMACIÓN, DEBE PODERSE ELIMINAR EL DEPORTISTA.
SE DEBE PODER AGREGAR UN DEPORTISTA EN LA VIEW INICIAL. EN SU FORMULARIO SE DEBE COMPROBAR 2 COSAS:
    1. QUE SU FECHA NACIMIENTO SEA ANTERIOR A HOY
    2. QUE TENGA UNA CALIFICACIÓN OLÍMPICA ENTRE 1 Y 10
*/
    public IActionResult Index()
    {
        ViewBag.ListaDeportes = BD.ListarDeportes();
        return View();
    }

    public IActionResult VerDetalleDeporte(int IdDeporte)
    {
        ViewBag.Deporte = BD.VerInfoDeporte(IdDeporte);
        ViewBag.ListaDeportistas = BD.ListarDeportistasPorDeporte(IdDeporte);
        return View("Index");
    }

    public IActionResult VerDetalleDeportista(int IdDeportista)
    {
        ViewBag.Deportista = BD.VerInfoDeportista(IdDeportista);
        return View("Index");
    }

    public IActionResult EliminarDeportista(int IdDeportista)
    {
        BD.EliminarDeportista(IdDeportista);
        return RedirectToAction("Index");
    }

    public IActionResult AgregarDeportista()
    {
        ViewBag.ListaPaises = BD.ListarPaises();
        ViewBag.ListaDeportes = BD.ListarDeportes();
        return View("Index");
    }

    public IActionResult GuardarDeportista(string apellido, string nombre, DateTime fechaNacimiento, int calificacion, string foto, int idPais, int idDeporte)
    {
        BD.AgregarDeportista(apellido, nombre, fechaNacimiento, foto, idPais, idDeporte, calificacion);
        return RedirectToAction("Index");
    }
}
