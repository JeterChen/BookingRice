using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingRice.Models
{
    public class RiceModel
    {
        public string category { get; set; }
        public List<RiceMenu> Menus { get; set; }
    }

    public class RiceMenu
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}