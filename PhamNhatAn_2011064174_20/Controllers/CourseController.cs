using PhamNhatAn_2011064174_20.Models;
using PhamNhatAn_2011064174_20.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhamNhatAn_2011064174_20.Controllers
{
    public class CourseController : Controller
    {
      
        private readonly ApplicationDbContext _dbContext;
        public CourseController()       
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Course
        public ActionResult Create()

        {
            var viewModel = new CourseViewModel
            {
                Categories= _dbContext.Category.ToList()
            };

            return View(viewModel);
        }
    }
}