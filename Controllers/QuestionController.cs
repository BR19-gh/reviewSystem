using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reviewProject.Data;
using reviewProject.Models;
using System.Linq;

namespace reviewProject.Controllers
{
    public class QuestionController : Controller
    {
        private readonly ApplicationDbContext _db;
        public QuestionController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: QuestionController
        public ActionResult Index()
        {
            var Questions = _db.Question.ToList();

            return View(Questions);
        }


        // GET: QuestionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Question Model)
        {
            _db.Question.Add(Model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: QuestionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionController/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Question entity)
        { 
            _db.Question.Update(entity);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: QuestionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var Model = _db.Question.SingleOrDefault(x => x.Id == id);
            _db.Question.Remove(Model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
