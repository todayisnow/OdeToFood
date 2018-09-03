using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryResturantData :IResturantData
    {
        List<Resturant> _Resturant;
        public InMemoryResturantData()
        {
            _Resturant = new List<Resturant>();
            _Resturant.Add(new Resturant { Id = 1, Name = "A" });
            _Resturant.Add(new Resturant { Id = 2, Name = "B" });
            _Resturant.Add(new Resturant { Id = 3, Name = "C" });
        }

        public IEnumerable<Resturant> GetResturants()
        {
            return _Resturant;
        }
    }
}
