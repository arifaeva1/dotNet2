using Mid.DB;
using System.Linq;
using System.Web.Mvc;

namespace Mid.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult Index()
        {
            var db = new MidDataEntities1();
            //var foods = db.Foods.ToList();

            var foods = (from fd in db.Foods
                       where  fd.Status== "Distributed" ||
                       fd.Status== "Collected" ||
                       fd.Status == "Pending"
                         select fd).ToList();
            return View(foods);
        }

        public ActionResult Pending()
        {
            var db = new MidDataEntities1();
            //var foods = db.Foods.ToList();

            var foods = (from fd in db.Foods
                         where fd.Status == "Assigned" 
                         select fd).ToList();
            return View(foods);
        }
        
        public ActionResult Collected(Food f)
        {
            var db = new MidDataEntities1();
            var foods = (from fd in db.Foods
                       where fd.Id== f.Id &&
                       fd.Status == "Assigned" 
                         select fd).SingleOrDefault();
            foods.Status = "Collected";
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create() { 
            return View(); 
        }
        [HttpPost]
        public ActionResult Create(Food fd)
        {

            var db = new MidDataEntities1();
            fd.Status = "Pending";
                db.Foods.Add(fd);
                db.SaveChanges();
            
            return RedirectToAction("Index");
        }

        public ActionResult Details(int Id)
        {
            var db = new MidDataEntities1();

            var foods = (from fd in db.Foods

                       where fd.Id == Id

                       select fd).SingleOrDefault();

            return View(foods);
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var db = new MidDataEntities1();

            var foods = (from fd in db.Foods
                         where fd.Id == Id
                         select fd).SingleOrDefault();
            return View(foods);
        }
        [HttpPost]
        public ActionResult Delete(Food f)
        {

            var db = new MidDataEntities1();

            var foods = (from fd in db.Foods

                         where fd.Id == f.Id

                         select fd).SingleOrDefault();

            db.Foods.Remove(foods);

            db.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}