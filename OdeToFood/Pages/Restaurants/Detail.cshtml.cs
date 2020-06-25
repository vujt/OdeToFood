using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurantData restaurant;

        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurantData restaurant)
        {
            this.restaurant = restaurant;
        }

        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurant.GetById(restaurantId);

            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }

        
    }
}