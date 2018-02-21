using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Interface;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repo)
        {
            _repository = repo;
        }
        public IActionResult List()
        {
            return View(_repository.Products);
        }
    }
}