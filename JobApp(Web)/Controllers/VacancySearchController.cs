using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
using JobApp_Web_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JobApp_Web_.Controllers
{
    public class VacancySearchController : Controller
    {
        private readonly IVacancySearchRepository _VacancySearchRepositoryRepo;
        private readonly IResumeRepository _ResumeRepositoryRepo;
        private readonly IVacancyApplicationRepository _VacancyApplicationRepositoryRepo;
        private readonly IVacancyRepository _VacancyRepositoryRepo;
        

       private readonly IMapper _mapper;
        private readonly UserManager<Jobseeker> _userManager;

        VacancySearchController(IVacancySearchRepository VacancySearchRepositoryRepo, IResumeRepository ResumeRepositoryRepo, IVacancyRepository VacancyRepositoryRepo, IVacancyApplicationRepository VacancyApplicationRepositoryRepo, IMapper mapper, UserManager<Jobseeker> userManager)
        {
            _VacancySearchRepositoryRepo = VacancySearchRepositoryRepo;
            _ResumeRepositoryRepo = ResumeRepositoryRepo;
            _VacancyRepositoryRepo = VacancyRepositoryRepo;
            _VacancyApplicationRepositoryRepo = VacancyApplicationRepositoryRepo;
            _mapper = mapper;
            _userManager = userManager;
        }


        // GET: VacancySearch
        public ActionResult Index()
        {
            var VacancyRequest = _VacancyRepositoryRepo.FindAll();
            var model = VacancyRequest;
            return View(model);
           
        }

        // GET: VacancySearch/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VacancySearch/Create
        public ActionResult Create()
        {
            var VacancyRequest = _VacancyRepositoryRepo.FindAll();
            var vacancyListItems = VacancyRequest.Select(q => new SelectListItem
            {
                Text = q.Job_title,Value=q.Id.ToString()

            });
            var ResumeRequest = _ResumeRepositoryRepo.FindAll();
            var ResumeListItems = ResumeRequest.Select(q => new SelectListItem
            {
                Text = q.Qualifications,
                Value = q.Id.ToString()
              

            });

            var model = new VacancySearchVM
            {
                Resume_requests = ResumeListItems,
                Vacancy_requests= vacancyListItems


            };

            return View(model);
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