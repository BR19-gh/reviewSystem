using Microsoft.AspNetCore.Mvc;
using reviewProject.Data;
using System.Linq;
using reviewProject.ViewModels;
using System.Collections.Generic;

namespace reviewProject.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ReviewController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: QuestionController
        public ActionResult Index()
        {

            var questions = _db.Questions.ToList();
            var model = new List<QuestionReviewViewModel>();

            foreach (var question in questions)
            {
                model.Add(new QuestionReviewViewModel()
                {
                    QuesId = question.Id,
                    Questions = question.Questions
                });
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(QuestionReviewViewModel entity)
        {
            return View();
        }
    }
}
