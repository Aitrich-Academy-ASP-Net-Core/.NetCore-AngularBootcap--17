using Microsoft.AspNetCore.Mvc;
using SampleMVC.Models;

namespace SampleMVC.Controllers
{
    public class StudentController:Controller
    {
      
              private static List<Student> students = new List<Student>
        {
            
                new Student { id = 1, Name = "Alice", Age = 20 },
                new Student { id = 2, Name = "Bob", Age = 22 },
                new Student { id = 3, Name = "Charlie", Age = 19 }
            };
        public IActionResult Index()
        { 
            return View(students);
        }
        // GET: /Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Student/Create
        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.id = students.Count > 0 ? students.Max(s => s.id) + 1 : 1;
            students.Add(student);
            return RedirectToAction("Index");
        }

        // GET: /Student/Edit/1
        public IActionResult Edit(int id)
        {
            var student = students.FirstOrDefault(s => s.id == id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: /Student/Edit/1
        [HttpPost]
        public IActionResult Edit(Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.id == updatedStudent.id);
            if (student == null)
                return NotFound();

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;

            return RedirectToAction("Index");
        }

        
        // GET: /Student/Delete/1
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.id == id);
            if (student == null)
                return NotFound();

            return View(student); // Confirm before deleting
        }

        // POST: /Student/Delete/1
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = students.FirstOrDefault(s => s.id == id);
            if (student != null)
            {
                students.Remove(student);
            }

            return RedirectToAction("Index");
        }

    }
}
