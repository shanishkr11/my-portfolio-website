using Microsoft.AspNetCore.Mvc;
using TiffinService.Models;

namespace TiffinService.Controllers;

public class HomeController : Controller
{
    private const string WhatsAppNumber = "919876543210";

    public IActionResult Index()
    {
        var vm = new HomeViewModel
        {
            WhatsAppUrl = $"https://wa.me/{WhatsAppNumber}?text=Hi!%20I%20want%20to%20order%20tiffin.",

            MenuItems = new List<MenuItem>
            {
                new() { Emoji = "🍽️", Name = "Veg Thali",       Desc = "Dal, sabzi, rice, chapati, salad & papad. A complete balanced meal.",          Price = "₹80", Per = "/plate", Tag = "Best Seller"      },
                new() { Emoji = "🍚", Name = "Dal Rice",         Desc = "Toor dal tadka with steamed basmati rice, pickle & papad.",                      Price = "₹50", Per = "/plate", Tag = "Simple & Filling" },
                new() { Emoji = "🫓", Name = "Chapati Curry",    Desc = "4 soft chapatis with seasonal vegetable curry & dal.",                           Price = "₹60", Per = "/plate", Tag = "Homestyle"        },
                new() { Emoji = "🥞", Name = "Breakfast Combo",  Desc = "Idli/Dosa with sambar, coconut chutney & filter coffee.",                        Price = "₹45", Per = "/plate", Tag = "Morning Delight"  },
                new() { Emoji = "🍛", Name = "Special Biryani",  Desc = "Fragrant veg biryani with raita, boiled egg optional.",                          Price = "₹90", Per = "/plate", Tag = "Weekend Special"  },
                new() { Emoji = "🥣", Name = "Upma / Poha",      Desc = "Light morning snack with peanuts, veggies & lemon.",                             Price = "₹30", Per = "/plate", Tag = "Light Bite"       },
            },

            Testimonials = new List<Testimonial>
            {
                new() { Text = "Very tasty and hygienic food. I have been eating here for 3 months and never felt disappointed. Feels like home cooking!",  Name = "Ravi Kumar",    Role = "Software Engineer, Gayatri Nagar", Avatar = "RK", Color = "#E8892A" },
                new() { Text = "Best for bachelors! The monthly plan is unbeatable value. Fresh food delivered on time every single day without fail.",       Name = "Priya Sharma",  Role = "Student, JNTU Hostel",             Avatar = "PS", Color = "#3A6B35" },
                new() { Text = "I shifted here last year and this tiffin service made my life so easy. Dal rice is amazing — just like my mom makes!",       Name = "Suresh Reddy",  Role = "Bank Employee, Hyderabad",         Avatar = "SR", Color = "#C0522A" },
            }
        };

        return View(vm);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View();
}
