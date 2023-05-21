using Microsoft.AspNetCore.Mvc;
using PerfectFit.Data;

namespace PerfectFit.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var ObjProductsList = _db.Product.ToList();
            return View();
        }
    }
}
