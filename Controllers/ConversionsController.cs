using Microsoft.AspNetCore.Mvc;
using metricsystem.Models;

namespace metricsystem.Controllers
{
    public class ConversionsController : Controller
    {
        [HttpGet]
        public IActionResult Fahrenheit()
        {
            return View(new TemperatureModel());
        }

        [HttpPost]
        public IActionResult Fahrenheit(TemperatureModel model)
        {
            if (ModelState.IsValid)
            {
                model.Celsius = model.ConvertToCelsius();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Clear()
        {
            ModelState.Clear();
            return RedirectToAction("Fahrenheit");
        }
    }
}