using Pokh_Design.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokh_Design.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductsOfTheWeek { get; set; }

    }
}
