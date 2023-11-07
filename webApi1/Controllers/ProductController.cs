using Microsoft.AspNetCore.Mvc;
using webApi1.Models;

namespace webApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductController : ControllerBase
    {
        static Product p1 = new Product() { ID = "111", Name = "milk", Price = 5, Category = "milky" };
        static Product p2 = new Product() { ID = "222", Name = "bread", Price = 7, Category = "breads" };
        static Product p3 = new Product() { ID = "333", Name = "chease", Price = 12, Category = "milky" };
        static Product p4 = new Product() { ID = "444", Name = "chocolate", Price = 5, Category = "chocolates" };
        static Product p5 = new Product() { ID = "555", Name = "candy", Price = 2, Category = "candys" };

        static List<Product> allProducts = new List<Product>() { p1, p2, p3, p4, p5 };



        //==1
        [HttpGet("")]
        public ActionResult<List<Product>> GetAllProducts()
        {
            return Ok(allProducts);
        }

        //==2
        [HttpGet("{ID}")]
        public ActionResult<Product> GetProductByID(string ID)
        {
            Product p = new Product();
            p = allProducts.Find(e => e.ID == ID);
            return Ok(p);
        }

        //==3
        [HttpPost("")]
        public void createProduct([FromBody] Product prod)
        {
            allProducts.Add(prod);
            //Console.WriteLine(allProducts);
        }

        //==4
        [HttpPut("")]
        public void updateProduct([FromBody] Product prod)
        {
            Product p = allProducts.Find(e => e.ID == prod.ID);
            if (p != null)
            {
                p.Name = prod.Name;
                p.Price = prod.Price;
                p.Category = prod.Category;
            }
        }
        //==5
        [HttpDelete("{id}")]
        public void deleteProduct(string id)
        {
            Product p = allProducts.Find(e => e.ID == id);
            allProducts.Remove(p);
        }
        //==6
        [HttpGet("search")]// How do you get as query params??
        public ActionResult<Product> GetProductByName(string name)
        {
            Product p = allProducts.Find(e => e.Name == name);
            return Ok(p);
        }
        //==7
        [HttpGet("category{category}")]
        public ActionResult<Product> GetProductByCategory(string category)
        {
            List<Product> p = allProducts.FindAll(e => e.Category == category);
            return Ok(p);
        }
        //==8
        [HttpGet("range")]//[HttpGet("{minPrice,maxPrice}")]
        public ActionResult<Product> GetProductByPriceRange(int minPrice, int maxPrice)
        {
            //try   מקרה קצה אם לא קיים

            List<Product> p = allProducts.FindAll(e => e.Price >= minPrice && e.Price <= maxPrice);
            return Ok(p);

        }


    }
}
