﻿namespace FoodGuide.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string? RestaurantType { get; set; }
        public string RestaurantName { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string RestaurantRating { get; set; }
        public Location Location { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
