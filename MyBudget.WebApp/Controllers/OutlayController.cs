using Microsoft.AspNetCore.Mvc;
using MyBudget.DAL.Entities;

namespace MyBudget.WebApp.Controllers
{
    public class OutlayController : Controller
    {
        public IActionResult Index()
        {
            List<Outlay> outlays = new List<Outlay>();

            outlays.Add(new Outlay() { Id = 1,Money=200,Category=null, Description="Test outlay 1"});
            outlays.Add(new Outlay() { Id = 2,Money=2123,Category=null, Description="Test outlay 2"});
            outlays.Add(new Outlay() { Id = 3,Money=1233,Category=null, Description="Test outlay 3"});
            outlays.Add(new Outlay() { Id = 4,Money=1235343,Category=null, Description="Test outlay 4"});

            return View(outlays);
        }

        public IActionResult AddOutlay()
        {
            return View();
        }
        //public IActionResult AddOutlay(Outlay outlay)
        //{
        //    return View();
        //}
    }
}
