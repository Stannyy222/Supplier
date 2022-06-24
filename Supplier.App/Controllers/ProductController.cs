using AutoMapper;
using Huerto___ENTPROG___OTIS1;
using Microsoft.AspNetCore.Mvc;
using Supplier.App.Models;
using Supplier.App.Models.Repository;

namespace Supplier.App.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo repo;
        private readonly IMapper mapper;
        public ProductController(IProductRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(mapper.Map<List<productVM>>(await repo.GetAllAsync()));
        }
    }
}
