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
    public class ResumesController : Controller
    {

        private readonly IResumeRepository _repo;
        private readonly IMapper _mapper;

        public ResumesController(IResumeRepository repo , IMapper mapper)
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
            if (_repo.IsExist(id))
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
        public ActionResult Create(IFormCollection model)
        {
            try
            {
              if (!ModelState.IsValid)
                {
                    return View(model);
                }
              
                var resume = _mapper.Map<Resume>(model);
              var isSucess=  _repo.Create(resume);
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

        // GET: Resumes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Resumes/Delete/5
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