using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

public class DoctorsController(IDoctorsRepository doctorsRepository) : Controller
{
    private readonly IDoctorsRepository doctorsRepository = doctorsRepository;   // Dependency Injection (DI)

    [HttpGet]
    public IActionResult Index()
    {
        // Fetch data from doctor table
        // ADO.NET
        // ORM Tool: EF Core, Dapper, NHibernate etc.

        var doctors = doctorsRepository.Get();

        return View(doctors);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Doctor doctor)
    {
        // Save to db
        doctorsRepository.Insert(doctor);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var doctor = doctorsRepository.Get(id);
        return View(doctor);
    }

    [HttpPost]
    public IActionResult Edit(Doctor doctor)
    {
        doctorsRepository.Edit(doctor);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var doctor = doctorsRepository.Get(id);

        return View(doctor);
    }

    [HttpPost]
    public IActionResult Delete(Doctor doctor)
    {
        doctorsRepository.Delete(doctor);

        return RedirectToAction(nameof(Index));
    }
}