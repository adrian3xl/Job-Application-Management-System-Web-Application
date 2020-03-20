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
            return View();
        }

        // GET: Resumes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Resumes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resumes/Create
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

        // GET: Resumes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Resumes/Edit/5
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