/*
    @Date                 : 24.03.2024
    @Author               : Stein Lundbeck
    @Description          : null
*/

using Microsoft.AspNetCore.Mvc;

namespace SL.Home.Happy.Controllers
{
    public class SLController : Controller
    {
        public SLController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("SL/SetCulture/{culture}")]
        public IActionResult SetCulture([FromRoute(Name = "culture")] string culture)
        {
            this.HttpContext.Session.SetString("Culture", culture);

            return RedirectToActionPermanent("Index", "SL");
        }

        public IActionResult CV() => View();
    }
}
