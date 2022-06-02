using System.Collections.Generic;
using WebUI.Models;

namespace WebUI.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public Summary Summary { get; set; }
    }
}
