using Microsoft.AspNetCore.Mvc;

//you need to give the controllers namespace access to your models
using fa22ModelPractice1.Models;

namespace fa22ModelPractice1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Example()
        {
            //create a new instance of the product class
            Product product = new Product();

            //set the properties of the object
            product.ProductID = 100042;
            product.ProductName = "An example product";
            product.ProductCost = 5.99m;
            product.InventoryOnHand = 1000;

            //call methods to calculate properties
            product.CalculateValueOfInventory();
            
            //return the object to the view
            return View(product);
        }

        public IActionResult Index()
        {
            //TODO: Create a new instance of the job posting class

            
            //TODO: Set the properties of the object
            

            //TODO: Call methods to calculate properties


            //TODO: Update the return statement to include the object
            return View();
        }

        
    }
}
