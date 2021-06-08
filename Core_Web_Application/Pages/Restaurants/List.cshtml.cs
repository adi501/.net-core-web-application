using Core_Web_Application.Data;
using Core_Web_Application.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Core_Web_Application.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantsData restaurantsData;
        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public ListModel(IConfiguration config, IRestaurantsData restaurantsData)
        {
            this.config = config;
            this.restaurantsData = restaurantsData;
        }
        public void OnGet()
        {
            Message = config["Message"];
            Restaurants = restaurantsData.GetAll();
        }
    }
}
