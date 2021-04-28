﻿using HealthAppGCU.DbManagers;
using HealthAppGCU.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.Controllers
{
    public class CyclingController : Controller
    {
        private readonly PhysicalDbManager dbManager;

        public CyclingController(PhysicalDbManager dbManager)
        {
            this.dbManager = dbManager;
        }

        [HttpGet]
        public IActionResult CyclingCounter()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult CyclingCounter(PhysicalActivityViewModel viewModel, DateTime startedDate, string startedHour, DateTime endedDate, string endedHour)
        {

            startedDate = startedDate.AddHours(double.Parse(startedHour.Substring(0, 2)));
            startedDate = startedDate.AddMinutes(double.Parse(startedHour.Substring(3)));

            endedDate = endedDate.AddHours(double.Parse(endedHour.Substring(0, 2)));
            endedDate = endedDate.AddMinutes(double.Parse(endedHour.Substring(3)));

            var username = this.User.Identity.Name;
            viewModel.Name = "Cycling";
            viewModel.TimeStarted = startedDate;
            viewModel.TimeEnded = endedDate;
            this.dbManager.RecordActivity(viewModel, username);

            return this.View();
        }
    }
}
