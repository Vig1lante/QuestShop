﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuestShop.Data;
using QuestShop.Models;
using QuestShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QuestShop.Components
{
    public class StudentExpBar : ViewComponent
    {
        private readonly IStudentRepository _studentRepository;
        public StudentExpBar(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var studentViewModel = new CurrentUserViewModel()
            {
                LoggedInUser = _studentRepository.LoggedInUser,
                UserPoints = _studentRepository.UserPoints,
                UserRank = _studentRepository.UserRank,
                UserRole = _studentRepository.UserRole
            };
            return View(studentViewModel);

        }
    }
}