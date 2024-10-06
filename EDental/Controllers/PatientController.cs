using Microsoft.AspNetCore.Mvc;
using EDental.Models;

namespace EDental.Controllers;
public class PatientsControll: Controllers
{
    public IActionResult Index()
    {
        return View();
    }
}