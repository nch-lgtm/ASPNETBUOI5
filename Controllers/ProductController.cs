using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using bai3.Models;
using bai3.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace bai3.Controllers
{
    public class ProductController : Controller
    {
        

        // GET: ProductController
        [HttpGet]

        public ActionResult Index(string? searchString, string? sortOrder, int page = 1)
        {
            ViewData["CurrentFulter"] = searchString;
            ViewData["CurrentSort"] = sortOrder;

            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["PriceSortParm"] = sortOrder == "price_asc" ? "price_desc" : "price_asc";

            var products = DataSeeds.products.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(p =>
                    p.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                    p.Description.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                   
                );
            }

           
            products = sortOrder switch
            {
                "name_desc" => products.OrderByDescending(p => p.Name),
                "price_asc" => products.OrderBy(p=> p.Price),
                "price_desc" => products.OrderByDescending(p=> p.Price),

                _ => products.OrderBy(p => p.Id),
            };

            int size = 6;
            int totalItems = products.Count();
            int pages = (int)Math.Ceiling((double)totalItems / size);

            
           
            var pagedProducts = products
                .Skip((page - 1) * size)
                .Take(size)
                .Select(ToViewModel)
                .ToList();

            ViewData["Pages"] = pages > 0 ? pages : 1;
            ViewData["Page"] = page;
            ViewData["TotalItems"] = totalItems;


            return View(pagedProducts);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = DataSeeds.products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: ProductController/Create
        [HttpGet]
        public ActionResult Create()
        {
			ViewBag.Categories = new SelectList(DataSeeds.categories, "Id", "Name");
			return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            product.Id = DataSeeds.products.Count + 1;
            DataSeeds.products.Add(product);

            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var EditProduct = DataSeeds.products.FirstOrDefault(p => p.Id == id);
            if (EditProduct == null)
            {
                return NotFound();
            }
			ViewBag.Categories = new SelectList(DataSeeds.categories, "Id", "Name", EditProduct.CategoryId);
			return View(EditProduct);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            var existingProduct = DataSeeds.products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Description = product.Description;
            existingProduct.CategoryId = product.CategoryId;
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = DataSeeds.products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var product = DataSeeds.products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            DataSeeds.products.Remove(product);
            return RedirectToAction(nameof(Index));
        }

        private static ProductViewModel ToViewModel (Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CategoryName = DataSeeds.categories.FirstOrDefault(c => c.Id == product.CategoryId)?.Name ?? string.Empty
            };
        }
    }

    
}