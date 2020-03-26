using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
using JobApp_Web_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobApp_Web_.Controllers
{
    [Authorize (Roles="Employer")]
    public class VacanciesController : Controller
    {

        private readonly IVacancyRepository _repo;
        private readonly IMapper _mapper;
        public VacanciesController(IVacancyRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }
        // GET: Vacancies
        public ActionResult Index()
        {
            var Vacancies = _repo.FindAll().ToList();
            var model = _mapper.Map<List<vacancy>, List<VacancyVM>>(Vacancies);
            return View(model);
        }

        // GET: Vacancies/Details/5
        public ActionResult Details(int id)
        {
            if (!_repo.IsExist(id))
            {
                return NotFound();
            }
            var Vacancy = _repo.FindById(id);
            var model = _mapper.Map<VacancyVM>(Vacancy);
            return View(model);
        }

        // GET: Vacancies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vacancies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VacancyVM model)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                model.EmployerId = "";



                var vacancy = _mapper.Map<vacancy>(model);
                var isSucess = _repo.Create(vacancy);
                if (!isSucess)
                {
                    ModelState.AddModelError("", "Something went wrong...");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Something went wrong...");
                return View(model);
            }
        
         }

        // GET: Vacancies/Edit/5
        public ActionResult Edit(int id)
        {
        if (!_repo.IsExist(id))
        {
            return NotFound();
        }
        var vacancy = _repo.FindById(id);
        var model = _mapper.Map<VacancyVM>(vacancy);
        return View(model);
    }

        // POST: Vacancies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VacancyVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var Vacancy = _mapper.Map<vacancy>(model);
                var isSucess = _repo.Update(Vacancy);
                if (!isSucess)
                {
                    ModelState.AddModelError("", "Something went wrong...");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Something went wrong...");
                return View(model);
            }
        }

        // GET: Vacancies/Delete/5
        public ActionResult Delete(int id)
        {
            var vacancy = _repo.FindById(id);
            if (vacancy == null)
            {
                return NotFound();
            }
            var isSucess = _repo.Delete(vacancy);
            if (!isSucess)
            {

                return BadRequest();
            }

            return RedirectToAction(nameof(Index));
        }

        // POST: Vacancies/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, VacancyVM model)
        {
            try
            {
                var vacancy = _repo.FindById(id);
                if (vacancy == null)
                {
                    return NotFound();
                }
                var isSucess = _repo.Delete(vacancy);
                if (!isSucess)
                {

                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}