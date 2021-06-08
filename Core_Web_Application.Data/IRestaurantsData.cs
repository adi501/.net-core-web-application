using System;
using System.Collections.Generic;
using System.Text;
using Core_Web_Application.Core;
using System.Linq;

namespace Core_Web_Application.Data
{
    public interface IRestaurantsData
    {
        IEnumerable<Restaurant> GetAll();

    }
    public class InMomoryRestaurantData : IRestaurantsData
    {
        List<Restaurant> restaurants;
        public InMomoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id=1,Name="ABC Restaurant", Location="Bangalore", Cuisine=CuisineType.Indian},
                new Restaurant {Id=2,Name="XYZ Restaurant", Location="Anantapur", Cuisine=CuisineType.Mexican},
                new Restaurant {Id=3,Name="Adi Restaurant", Location="Tadipatri", Cuisine=CuisineType.Italian}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
