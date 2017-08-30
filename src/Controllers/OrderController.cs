namespace todo.Controllers
{
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Models;

    public class OrderController : Controller
    {
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync()
        {
            var items = await DocumentDBRepository<Order>.GetItemsAsync(d => !d.Deleted);
            return View(items);
        }
        [ActionName("Create")]
        public async Task<ActionResult> CreateAsync()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync([Bind(Include = "Id,OrderNumber,TotalPrice,Deleted")] Order order)
        {
            if (ModelState.IsValid)
            {
                await DocumentDBRepository<Order>.CreateItemAsync(order);
                return RedirectToAction("Index");
            }

            return View(order);
        }

    

        [HttpPost]
        [ActionName("Edit")]
        
        public async Task<ActionResult> EditAsync(Order order)
        {
            if (ModelState.IsValid)
            {
                await DocumentDBRepository<Order>.UpdateItemAsync(order.Id, order);
                return RedirectToAction("Index");
            }

            return View(order);
        }
        

        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(string id)
        {
            Order order = await DocumentDBRepository<Order>.GetItemAsync(id);
            return View(order);
        }
    }
}