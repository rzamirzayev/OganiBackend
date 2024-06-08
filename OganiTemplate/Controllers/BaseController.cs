using Microsoft.AspNetCore.Mvc;
using OganiTemplate.Models.Contexts;
using OganiTemplate.Models.Entities;

namespace OganiTemplate.Controllers
{
    public class BaseController : Controller
    {
        private readonly DataContext db;

        public BaseController(DataContext db)
        {
            this.db = db;
        }
        [HttpPost]
        public IActionResult Subscribe(string subscribe)
        {
            var post = new SubscribePost { Subscribe = subscribe };
            db.SubscribePosts.Add(post);
            db.SaveChanges();
            return Json(new
            {
                error = false,
                message = "Qebul olundu"
            });
        }
    }
}
