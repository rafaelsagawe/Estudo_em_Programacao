﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuloGestãoUsuarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloGestãoUsuarios.Controllers
{

    [Authorize(Roles = "SuperAdmin")]

    public class UsuarioRegraController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsuarioRegraController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        private async Task<List<string>> PegarUsuarioRegra(ApplicationUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var UsuarioRegraViewModel = new List<UsuarioRegraViewModel>();
            foreach (ApplicationUser user in users)
            {
                var thisViewModel = new UsuarioRegraViewModel();
                thisViewModel.UserId = user.Id;
                thisViewModel.Email = user.Email;
                thisViewModel.PrimeiroNome = user.PrimeiroNome;
                thisViewModel.Sobrenome = user.SobreNome;
                thisViewModel.Regra = await PegarUsuarioRegra(user);
                UsuarioRegraViewModel.Add(thisViewModel);
            }
            return View(UsuarioRegraViewModel);
        }

        // Adição do Usuário a Regra

        public async Task<IActionResult> Gerenciar (string userId)
        {
            ViewBag.userId = userId;
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }
            ViewBag.UserName = user.UserName;
            var model = new List<GerenciamentoRegraUsuarioViewModel>();
            foreach (var role in _roleManager.Roles.ToList())
            {
                var userRolesViewModel = new GerenciamentoRegraUsuarioViewModel
                {
                    RegraId = role.Id,
                    RegraNome = role.Name
                };
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.Selecao = true;
                }
                else
                {
                    userRolesViewModel.Selecao = false;
                }
                model.Add(userRolesViewModel);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Gerenciar (List<GerenciamentoRegraUsuarioViewModel> model, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View();
            }
            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }
            result = await _userManager.AddToRolesAsync(user, model.Where(x => x.Selecao).Select(y => y.RegraNome));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }
            return RedirectToAction("Index");
        }
    }
}
