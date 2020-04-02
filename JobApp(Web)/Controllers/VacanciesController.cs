using AutoMapper;
using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
using JobApp_Web_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace JobApp_Web_.Controllers


{

    public class VacanciesController : Controller
    {

        private readonly IResumeRepository _ResumeRepositoryRepo;
        private readonly IVacancyRepository _repo;
        private readonly IMapper _mapper;
        private readonly IVacancyApplicationRepository _VacancyApplicationRepositoryRepo;
        private readonly UserManager<Employer> _empManager;
        private readonly UserManager<Jobseeker> _jobseekerManager;
        public VacanciesController(IVacancyRepository repo,
                                    IVacancyApplicationRepository VacancyApplicationRepositoryRepo,
                                    IResumeRepository ResumeRepositoryRepo,
                                    IMapper mapper,
                                    UserManager<Employer> empManager,
                                    UserManager<Jobseeker> jobseekerManager)
        {
            _repo = repo;
            _mapper = mapper;
            _empManager = empManager;
            _jobseekerManager = jobseekerManager;
            _ResumeRepositoryRepo = ResumeRepositoryRepo;
            _VacancyApplicationRepositoryRepo = VacancyApplicationRepositoryRepo;
          

        }

        public ActionResult Apply(int id)
        {
            if (!_repo.IsExist(id))
            {
                return NotFound();
            }
            var Vacancy = _repo.FindById(id);
            var model = _mapper.Map<VacancyVM>(Vacancy);
            return View(model);
        }

        public ActionResult ApplyNow(int id)
        {
            if (!_repo.IsExist(id))
            {
                return NotFound();
            }
            var username = User.Identity.Name;
            var user = _jobseekerManager.GetUserAsync(User).Result;
            var resume = _ResumeRepositoryRepo.FindAll().FirstOrDefault(q => q.JobseekerId == user.Id);
            var application = new Vacancy_Application
            {
                Resume_requestid = resume.Id,
                Vacancy_requestid = id
            };
            var isSucess = _VacancyApplicationRepositoryRepo.Create(application);
            if (!isSucess)
            {
                ModelState.AddModelError("", "Something went wrong...");
                return RedirectToAction("Apply", new { id });
            }

            return RedirectToAction(nameof(AvailableJobs));
        }


        [Authorize(Roles = "Jobseeker")]
        public ActionResult AvailableJobs()

        {

            var Vacancies = _repo.FindAll().ToList();
            var model = _mapper.Map<List<vacancy>, List<VacancyVM>>(Vacancies);
            return View(model);
        }

        [Authorize(Roles = "Employer")]
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
      
        [Authorize(Roles = "Employer")]
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

                var Employer = _empManager.GetUserAsync(User).Result;

                model.EmployerId = Employer.Id;

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
        [Authorize(Roles = "Employer")]

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