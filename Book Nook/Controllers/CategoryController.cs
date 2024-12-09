using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_Nook.Data;
using Book_Nook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Book_Nook.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categoryList = _context.Categories.ToList();
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                TempData["success"] = "Category successfully created";
                return RedirectToAction("Index");
            }
            return View(category);
            
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            } 

            var categorytoEdit = _context.Categories.FirstOrDefault(x => x.Id == id);
            if(categorytoEdit == null)
            {
                return NotFound();
            }

            return View(categorytoEdit);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if(ModelState.IsValid)
            {
                _context.Categories.Update(category);
                _context.SaveChanges();
                TempData["success"] = "Category successfully updated";

                return RedirectToAction("Index");
            }
            return View(category);
            
        }
        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            } 

            var categorytoDelete = _context.Categories.FirstOrDefault(x => x.Id == id);
            if(categorytoDelete == null)
            {
                return NotFound();
            }

            return View(categorytoDelete);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteFromDb(int? id)
        {
            Category? categorytoDelete = _context.Categories.Find(id);
            if(categorytoDelete == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(categorytoDelete);
            _context.SaveChanges();
            TempData["success"] = "Category successfully deleted";
            return RedirectToAction("Index");
            
        }
    }
}