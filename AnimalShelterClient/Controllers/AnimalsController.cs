using AnimalShelterClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalShelterClient.Controllers
{
    public class AnimalsController : Controllers
    {
        public IActionResult Index()
        {
            var allAnimals = Animal.GetAnimals();
            return View(allAnimals);
        }

        public ActionResult Details(int id)
        {
            var animal = Animal.GetDetails(id);
            return View(animal);
        }
    }
}