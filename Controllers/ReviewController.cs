﻿using Microsoft.AspNetCore.Mvc;
using reviewProject.Data;
using reviewProject.Models;
using System.Linq;
using reviewProject.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

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

            var questions = _db.Question.ToList();
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
        public IActionResult Index([FromBody] List<PostReviewViewModel> result)
        {
            int i = 0;
            
            foreach (var item in result)
            {
                var obj = new Review();
                obj.QuesId = int.Parse(result[i].QuesId);
                obj.RangeResult = int.Parse(result[i].Range);
                _db.Review.Add(obj);
                _db.SaveChanges();
                i++;
            }

            var html = "<h1>Thank You</h1>";
            return new ContentResult
            {
                Content = html,
                ContentType = "text/html"
            };
        }

      
    }
}
