using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controllers
{
    public class NoteController : Controller
    {

        private readonly ApplicationDbContext _db;

        public NoteController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: NoteController
        public ActionResult Index()
        {
            List<Note> notes = _db.Notes.ToList();
            return View(notes);
        }

        // GET: NoteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NoteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NoteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Note note)
        {
            note.createdAt = DateTime.Now;
            _db.Notes.Add(note);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: NoteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NoteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NoteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NoteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
