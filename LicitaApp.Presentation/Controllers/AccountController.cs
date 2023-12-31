﻿using Microsoft.AspNetCore.Mvc;

namespace LicitaApp.Presentation.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Método para abrir a página /Account/Login
        /// </summary>
        public IActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// Método para abrir a página /Account/Register
        /// </summary>
        public IActionResult Register()
        {
            return View();
        }
        /// <summary>
        /// Método para abrir a página /Account/ForgotPassword
        /// </summary>
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
