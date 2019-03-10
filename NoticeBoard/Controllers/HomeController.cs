using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoticeBoard.Models;

namespace NoticeBoard.Controllers
{
    public class HomeController : Controller
    {
        private readonly INoteRepository _noteRepository;

        public HomeController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }
        public IActionResult Index()
        {
            var notes = _noteRepository.GetAllNotes().OrderBy(p => p.Date);

            return View(notes);
        }

        [Authorize]
        public IActionResult Create()
        {
            
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Note note)
        {
            if(ModelState.IsValid)
            {
                _noteRepository.AddNote(note);
                return RedirectToAction("Index");
            }
            return View(note);
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
