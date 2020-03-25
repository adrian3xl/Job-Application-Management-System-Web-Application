using AutoMapper;
using JobApp_Web_.Contracts;
using JobApp_Web_.Data;
using JobApp_Web_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace JobApp_Web_.Controllers
{
    [Authorize(Roles = "Jobseeker")]
    public class ResumesController : Controller
    {

        private readonly IResumeRepository _repo;
        private readonly IMapper _mapper;

        public ResumesController(IResumeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }
        // GET: Resumes
        public ActionResult Index()
        {
            var Resumes = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Resume>, List<ResumeVM>>(Resumes);
            return View(model);
        }

        // GET: Resumes/Details/5
        public ActionResult Details(int id)
        {
            if (!_repo.IsExist(id))
            {
                return NotFound();
            }
            var resume = _repo.FindById(id);
            var model = _mapper.Map<ResumeVM>(resume);
            return View(model);
        }

        // GET: Resumes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resumes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ResumeVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var resume = _mapper.Map<Resume>(model);
             // var Jobseeker_Id = resume.Jobseeker.Id;
                var isSucess = _repo.Create(resume);
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

        // GET: Resumes/Edit/5
        public ActionResult Edit(int id)

        {
            if (!_repo.IsExist(id))
            {
                return NotFound();
            }
            var resume = _repo.FindById(id);
            var model = _mapper.Map<ResumeVM>(resume);
            return View(model);
        }

        // POST: Resumes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ResumeVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var resume = _mapper.Map<Resume>(model);
           
               
                var isSucess = _repo.Update(resume);
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

        // GET: Resumes/Delete/5
        public ActionResult Delete(int id)
        {
            var resume = _repo.FindById(id);
            if (resume == null)
            {
                return NotFound();
            }
            var isSucess = _repo.Delete(resume);
            if (!isSucess)
            {

                return BadRequest();
            }

            return RedirectToAction(nameof(Index));
        }

        // POST: Resumes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ResumeVM model)
        {
            try
            {
                var resume = _repo.FindById(id);
                if (resume == null)
                {
                    return NotFound();
                }
                var isSucess = _repo.Delete(resume);
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