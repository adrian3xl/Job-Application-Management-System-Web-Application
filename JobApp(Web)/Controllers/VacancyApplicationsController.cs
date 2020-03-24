using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
using JobApp_Web_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobApp_Web_.Controllers
{
    public class VacancyApplicationsController : Controller
    {
        private readonly IVacancyApplicationRepository _repo;
        private readonly IMapper _mapper;
        public VacancyApplicationsController(IVacancyApplicationRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }
        // GET: Vacancy_Applications
        public ActionResult Index()
        {
            var Vacancy_Applications = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Vacancy_Application>, List<Vacancy_ApplicationVM>>(Vacancy_Applications);
            return View(model);
        }


        // GET: VacancyApplications/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VacancyApplications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VacancyApplications/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VacancyApplications/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VacancyApplications/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VacancyApplications/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VacancyApplications/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}