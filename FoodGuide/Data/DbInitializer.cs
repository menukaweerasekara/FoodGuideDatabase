using FoodGuide.Models;
using System;
using System.Linq;



namespace FoodGuide.Data
{
    public class DbInitializer
    {
        public static void Initialize(FoodContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
            new Employee{EmployeeName = "Menuka Weerasekara",DOB=DateTime.Parse("2004-08-27"),Role="Worker",HireDate=DateTime.Parse("2022-03-18"),Address="Home is Cool",ReportsToID= 2,RestaurantID = 1 },
            new Employee{EmployeeName = "Ben Dover",DOB=DateTime.Parse("2005-12-07"),Role="Owner",HireDate=DateTime.Parse("2002-05-28"),Address="Home Cool", RestaurantID = 1} 

            };
            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();

            var restuarants = new Restaurant[]
           {
             new Restaurant{RestaurantID=1,RestaurantType="Fast Food",RestaurantName="Mc Donalds",DateOfRegistration=DateTime.Parse("1979-05-12"),RestaurantRating= "5"},
             new Restaurant{RestaurantID=2,RestaurantType="Japanese",RestaurantName="Ichiraku Ramen",DateOfRegistration=DateTime.Parse("1998-04-08"),RestaurantRating= "5"},

           };
            foreach (Restaurant r in restuarants)
            {
                context.Restaurants.Add(r);
            }
            context.SaveChanges();


        }



    }
}
