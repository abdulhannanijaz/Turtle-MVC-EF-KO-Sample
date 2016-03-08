using System.Linq;
using System.Net;
using System.Web.Mvc;
using ClanNinjaEquipment.DataLayer;
using ClanNinjaEquipment.Web.ViewModels;

namespace ClanNinjaEquipment.Web.Controllers
{
    public class ClansController : Controller
    {
        private TurtleEntities db;

        public ClansController()
        {
            db = new TurtleEntities();
        }

        public ActionResult Index()
        {
            return View(db.Clan.ToList());
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clan clan = db.Clan.Find(id);

            if (clan == null)
            {
                return HttpNotFound();
            }

            ClanViewModel ClanViewModel = new ClanViewModel();

            ClanViewModel.ClanID = clan.ClanID;
            ClanViewModel.Name = clan.Name;
            ClanViewModel.SymbolPic = clan.SymbolPic;
            ClanViewModel.IsEvil = clan.IsEvil;
            ClanViewModel.MessageToClient = "ViewModel from client";


            return View(ClanViewModel);
        }


        public ActionResult Create()
        {
            ClanViewModel clanviewmodel = new ClanViewModel();
            return View(clanviewmodel);
        }

     
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clan clan = db.Clan.Find(id);
            if (clan == null)
            {
                return HttpNotFound();
            }
            ClanViewModel ClanViewModel = new ClanViewModel();

            ClanViewModel.ClanID = clan.ClanID;
            ClanViewModel.Name = clan.Name;
            ClanViewModel.SymbolPic = clan.SymbolPic;
            ClanViewModel.IsEvil = clan.IsEvil;
            ClanViewModel.MessageToClient = "ViewModel from client edit function";


            return View(ClanViewModel);
        }



        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clan clan = db.Clan.Find(id);
            if (clan == null)
            {
                return HttpNotFound();
            }
            return View(clan);
        }

        public JsonResult Save(ClanViewModel clanViewModel)
        {
            Clan clan       = new Clan();
            clan.Name       = clanViewModel.Name;
            clan.SymbolPic  = clanViewModel.SymbolPic;
            clan.IsEvil     = clanViewModel.IsEvil;

            db.Clan.Add(clan);
            db.SaveChanges();

            clanViewModel.MessageToClient = string.Format("{0} is added in db", clan.Name);

            return Json(new { clanViewModel });


        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
//Removed Post methods 


//// POST: Clans/Delete/5
//[HttpPost, ActionName("Delete")]
//[ValidateAntiForgeryToken]
//public ActionResult DeleteConfirmed(int id)
//{
//    Clan clan = db.Clan.Find(id);
//    db.Clan.Remove(clan);
//    db.SaveChanges();
//    return RedirectToAction("Index");
//}

//// POST: Clans/Edit/5
//// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult Edit([Bind(Include = "ClanID,Name,SymbolPic,IsEvil,IsDeleted,CreatedOn,CreatedBy,ClanGUID")] Clan clan)
//{
//    if (ModelState.IsValid)
//    {
//        db.Entry(clan).State = EntityState.Modified;
//        db.SaveChanges();
//        return RedirectToAction("Index");
//    }
//    return View(clan);
//}   
//// POST: Clans/Create
//// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult Create([Bind(Include = "ClanID,Name,SymbolPic,IsEvil,IsDeleted,CreatedOn,CreatedBy,ClanGUID")] Clan clan)
//{
//    if (ModelState.IsValid)
//    {
//        db.Clan.Add(clan);
//        db.SaveChanges();
//        return RedirectToAction("Index");
//    }

//    return View(clan);
//}

