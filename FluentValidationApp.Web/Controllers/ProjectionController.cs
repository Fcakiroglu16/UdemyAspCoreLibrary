using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidationApp.Web.DTOs;
using FluentValidationApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationApp.Web.Controllers
{
    public class ProjectionController : Controller
    {
        private readonly IMapper _mapper;

        public ProjectionController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EventDateDto eventDateDto)
        {
            EventDate eventDate = _mapper.Map<EventDate>(eventDateDto);

            ViewBag.date = eventDate.Date.ToShortDateString();

            return View();
        }
    }
}