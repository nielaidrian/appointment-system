using Microsoft.AspNetCore.Mvc;
using SbcCapstone.Contracts;
using SbcCapstone.Data;

namespace SbcCapstone.Controllers
{
    public class AppointmentController : BaseController
    {
        private readonly IBaseRepository<Appointments> _repo;
        public AppointmentController(IBaseRepository<Appointments> repo)
        {
            _repo = repo;
        }
        public IActionResult Create()
        {
            return View(new Appointments());
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Appointments appointments)
        {
            if(!ModelState.IsValid)
            {
                return View(appointments);
            }
            await _repo.Create(appointments);
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Index()
        {
            var appointments = await _repo.GetAll();
            return View(appointments);
        }
        public IActionResult Edit(int id)
        {
            var entity = _repo.GetOne(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }
        public IActionResult Delete(int id)
        {
            var entity = _repo.GetOne(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity); 
        }
    }
}
