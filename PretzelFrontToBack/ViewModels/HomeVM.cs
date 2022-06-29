using PretzelFrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PretzelFrontToBack.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> sliders { get; set; }
    }
}
