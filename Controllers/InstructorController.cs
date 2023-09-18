using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class InstructorController : Controller
{
    private readonly List<Instructor> _instructors = new List<Instructor>
    {
        new Instructor { Id = 1, FirstName = "Vince Albert", LastName = "Juson", IsTenured = true, Rank = "Professor", HiringDate = DateTime.Parse("01-10-2020") },
        new Instructor { Id = 2, FirstName = "Cassandra", LastName = "Lugtu", IsTenured = false, Rank = "AssistantProfessor", HiringDate = DateTime.Parse("04-22-2020") },
        new Instructor { Id = 3, FirstName = "John Daniel", LastName = "De Castro", IsTenured = true, Rank = "AssociateProfessor", HiringDate = DateTime.Parse("07-05-2020") },
        new Instructor { Id = 4, FirstName = "Melfred", LastName = "Fonclara", IsTenured = false, Rank = "Instructor", HiringDate = DateTime.Parse("09-18-2020") },
        new Instructor { Id = 5, FirstName = "Joaquin", LastName = "Valdez", IsTenured = true, Rank = "Professor", HiringDate = DateTime.Parse("02-08-2021") },
        new Instructor { Id = 6, FirstName = "Adam", LastName = "Mangun", IsTenured = false, Rank = "AssistantProfessor", HiringDate = DateTime.Parse("05-30-2021") },
        new Instructor { Id = 7, FirstName = "Jex", LastName = "De Leon", IsTenured = true, Rank = "AssociateProfessor", HiringDate = DateTime.Parse("08-12-2021") },
        new Instructor { Id = 8, FirstName = "Miguel", LastName = "Reyes", IsTenured = false, Rank = "Instructor", HiringDate = DateTime.Parse("11-25-2021") },
    };

    public IActionResult Index()
    {
        return View(_instructors);
    }

    public IActionResult ShowDetails(int id)
    {
        var instructor = _instructors.FirstOrDefault(i => i.Id == id);
        if (instructor == null)
        {
            return NotFound();
        }

        return View(instructor);
    }
}
