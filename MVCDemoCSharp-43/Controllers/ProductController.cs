﻿using Microsoft.AspNetCore.Mvc;

namespace MVCDemoCSharp_43.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _repo;
        public ProductController(IProductRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var products = _repo.GetAllProducts();
            return View(products);
        }
    }
}
