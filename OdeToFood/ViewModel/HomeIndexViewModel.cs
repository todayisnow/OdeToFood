using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewModel
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Resturant> Resturants { get; set; }
        public string Message { get; set; }
    }
}
