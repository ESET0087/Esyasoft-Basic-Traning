using Day_6.Data;
using Day_6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Day_6.Controllers
{
    [Route("products")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = _repository.GetAll();
            return View(products);
        }


        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            Product product = _repository.GetById(id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product); 
        }
    }
}
