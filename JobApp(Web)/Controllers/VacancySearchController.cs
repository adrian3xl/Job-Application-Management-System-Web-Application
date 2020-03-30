using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JobApp_Web_.Controllers
{
    public class VacancySearchController : Controller
    {
        private readonly IVacancySearchRepository _VacancySearchRepositoryRepo;
       private readonly IMapper _mapper;
        private readonly UserManager<Jobseeker> _userManager;

        VacancySearchController(IVacancySearchRepository VacancySearchRepositoryRepo, IMapper mapper, UserManager<Jobseeker> userManager)
        {
            _VacancySearchRepositoryRepo = VacancySearchRepositoryRepo;
            _mapper = mapper;
            _userManager = userManager;
        }


        // GET: VacancySearch
        public ActionResult Index()
        {
            return View();
        }

        // GET: VacancySearch/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VacancySearch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VacancySearch/Create
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

        // GET: VacancySearch/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VacancySearch/Edit/5
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

        // GET: VacancySearch/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VacancySearch/Delete/5
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