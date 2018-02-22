using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Interface;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        public int PageSize { get; set; } = 4;

        public ProductController(IProductRepository repo)
        {
            _repository = repo;
        }
        public IActionResult List(int productPage = 1)
        {

            return View(new ProductListViewModel
            {

                Products = _repository.Products
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = _repository.Products.Count()
                }
            });
           
        }
    }
}