﻿using AutoMapper;
using JobApp_Web_.Data;
using JobApp_Web_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApp_Web_.Mappings
{
    public class Mapper: Profile
    {
        public Mapper()
        {
            CreateMap<vacancy, VacancyVM>().ReverseMap();
            CreateMap<vacancy, CreateVacancyVM>().ReverseMap();

            CreateMap<Jobseeker, JobseekerVM>().ReverseMap();
            CreateMap<Resume, ResumeVM>().ReverseMap();
            CreateMap<Employer, EmployerVM>().ReverseMap();
            CreateMap<Vacancy_Application, Vacancy_ApplicationVM>().ReverseMap();
        }
    }
}
