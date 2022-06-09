using Microsoft.AspNetCore.Mvc;
using Supplier.DataModel;

namespace Supplier.App.Controllers
{
    public class SupplierController : Controller
    {
        private readonly AppDbContext con;
        public SupplierController(AppDbContext context)
        {
            con = context;
        }

        public IActionResult Index()
        {
            return View(con.SuppliersINV.ToList());
        }

        public IActionResult Add()
        {
            return View(new supplier());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(supplier model)
        {
            con.Add(model);
            con.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var supplier = con.SuppliersINV.Find(id);
            con.Set<supplier>().Remove(supplier);
            con.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
