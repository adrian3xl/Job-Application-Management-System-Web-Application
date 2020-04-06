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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JobApp_Web_.Controllers
{
    [Authorize]
    public class VacancyApplicationsController : Controller
    {
        private readonly IVacancyApplicationRepository _VacancyApplicationRepositoryRepo;
        private readonly IMapper _mapper;
        private readonly UserManager<Jobseeker> _userManager;
        public VacancyApplicationsController(IVacancyApplicationRepository VacancyApplicationRepositoryRepo, IMapper mapper, UserManager<Jobseeker> userManager)
        {
            _VacancyApplicationRepositoryRepo = VacancyApplicationRepositoryRepo;
            _mapper = mapper;
            _userManager = userManager;
        }


        [Authorize(Roles ="Employer")]
        // GET: Vacancy_Applications
        public ActionResult Index()
        {
            var Vacancy_Applications = _VacancyApplicationRepositoryRepo.FindAll();
            var Vacancy_ApplicationsModel = _mapper.Map<List<Vacancy_ApplicationVM>>(Vacancy_Applications);
            var model = new VacancyApplicationAdminViewVM
            {
                Vacancy_Applications = Vacancy_ApplicationsModel
            };

            return View(model);
        }

        [Authorize(Roles = "Jobseeker")]
        // GET: Vacancy_Applications for jobseeker
        public ActionResult Statusview()
        {
            var Vacancy_Applications = _VacancyApplicationRepositoryRepo.FindAll();
            var Vacancy_ApplicationsModel = _mapper.Map<List<Vacancy_ApplicationVM>>(Vacancy_Applications);
            var model = new VacancyApplicationJobseekerViewVM
            {
                Vacancy_Applications = Vacancy_ApplicationsModel
            };

            return View(model);
        }






        // GET: VacancyApplications/Details/5
        public ActionResult Details(int id)
        {
            if (!_VacancyApplicationRepositoryRepo.IsExist(id))
            {
                return NotFound();
            }
            var Vacancy_Applications = _VacancyApplicationRepositoryRepo.FindById(id);
            var model = _mapper.Map<Vacancy_ApplicationVM>(Vacancy_Applications);
           

            return View(model);
        }

        // GET: VacancyApplications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VacancyApplications/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vacancy_ApplicationVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var vacancy_Application = _mapper.Map<Vacancy_Application>(model);
                var isSucess = _VacancyApplicationRepositoryRepo.Create(vacancy_Application);
                if (!isSucess)
                {
                    ModelState.AddModelError("", "Something went wrong...");
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Something went wrong...");
                return View(model);
            }
        }

        // GET: VacancyApplications/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_VacancyApplicationRepositoryRepo.IsExist(id))
            {
                return NotFound();
            }
            var vacancy_Application = _VacancyApplicationRepositoryRepo.FindById(id);
            var model = _mapper.Map<Vacancy_ApplicationVM>(vacancy_Application);
            return View(model);
        }

        // POST: VacancyApplications/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Vacancy_ApplicationVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var vacancy_Application = _mapper.Map<Vacancy_Application>(model);
                var isSucess = _VacancyApplicationRepositoryRepo.Update(vacancy_Application);
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

        // GET: VacancyApplications/Delete/5
        public ActionResult Delete(int id)
        {
            var vacancy_Application = _VacancyApplicationRepositoryRepo.FindById(id);
            if (vacancy_Application == null)
            {
                return NotFound();
            }
            var isSucess = _VacancyApplicationRepositoryRepo.Delete(vacancy_Application);
            if (!isSucess)
            {

                return BadRequest();
            }

            return RedirectToAction(nameof(Statusview));
        }

        // POST: VacancyApplications/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Vacancy_ApplicationVM model)
        {
            try
            {
                var Vacancy_Application = _VacancyApplicationRepositoryRepo.FindById(id);
                if (Vacancy_Application == null)
                {
                    return NotFound();
                }
                var isSucess = _VacancyApplicationRepositoryRepo.Delete(Vacancy_Application);
                if (!isSucess)
                {

                    return View(model);
                }

                return RedirectToAction(nameof(Statusview));
            }
            catch
            {
                return View(model);
            }
        }
    }
}