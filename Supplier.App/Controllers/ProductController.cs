using AutoMapper;
using Huerto___ENTPROG___OTIS1;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Supplier.App.Models;
using Supplier.App.Models.Repository;

namespace Supplier.App.Controllers
{
    [Authorize]
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

        public IActionResult Add()
        {
            return View(new productVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(productVM model)
        {
            if (ModelState.IsValid)
            {
                await repo.AddAsync(mapper.Map<product>(model));

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int ProductID)
        {
            await repo.DeleteAsync(ProductID);

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit (int? id)
        {
            if (id == null) return RedirectToAction("Index");
            productVM prod = mapper.Map<productVM>(await repo.GetAsync((int)id));
            
            return View(prod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(productVM model)
        {
            if (ModelState.IsValid)
            {
                await repo.UpdateAsync(mapper.Map<product>(model));

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
