
using Microsoft.AspNetCore.Mvc;
using EDental.Models;

namespace EDental.Controllers;
public class DoctorsController: Controller
{
 public IActionResult Index()
 {
    return view();
 }
}