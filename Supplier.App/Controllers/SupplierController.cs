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
        public IActionResult Delete(int SupplierID)
        {
                var supp = con.SuppliersINV.Find(SupplierID);
                con.Set<supplier>().Remove(supp);
                con.SaveChanges();

                return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return RedirectToAction("Index");

            var supp = con.SuppliersINV.Find(id);

            return View(supp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(supplier model)
        {
            con.Update(model);
            con.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
