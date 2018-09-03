using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;
using OdeToFood.ViewModel;

namespace OdeToFood.Controllers
{
    
    public class HomeController : Controller
    {
        private IResturantData _resturantData;
        private IGreeter _greeter;

        public HomeController(IResturantData resturantData, IGreeter greeter)
        {
            _resturantData = resturantData;
            _greeter = greeter;
        }
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Resturants = _resturantData.GetResturants() ;
            model.Message = _greeter.GetMessageOfTheDay();
            
            return View(model);
            

        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}