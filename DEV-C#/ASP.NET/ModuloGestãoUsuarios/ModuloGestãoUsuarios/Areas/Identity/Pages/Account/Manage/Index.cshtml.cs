﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModuloGestãoUsuarios.Models;

namespace ModuloGestãoUsuarios.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            // Campos customizados

            [Required]
            [Display(Name = "PrimeiroNome")]
            public string PrimeiroNome { get; set; }

            [Required]
            [Display(Name = "SobreNome")]
            public string SobreNome { get; set; }

            [Display(Name = ("Nome do usuário"))]
            public string UserName { get; set; }

            [Display(Name = "Foto do perfil")]
            public byte[] FotoPefil { get; set; }

            // -------------

            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var primeironome = user.PrimeiroNome;
            var sobrenome = user.SobreNome;
            var FotoPerfil = user.FotoPefil;
            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                UserName = userName,
                PrimeiroNome = primeironome,
                SobreNome = sobrenome ,
                FotoPefil = FotoPerfil
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var PrimeiroNome = user.PrimeiroNome;
            var SobreNome = user.SobreNome;
            if (Input.PrimeiroNome != PrimeiroNome)
            {
                user.PrimeiroNome = Input.PrimeiroNome;
                await _userManager.UpdateAsync(user);
            }
            if (Input.SobreNome != SobreNome)
            {
                user.SobreNome = Input.SobreNome;
                await _userManager.UpdateAsync(user);
            }
            // Adição de foto
            if (Request.Form.Files.Count > 0)
            {
                IFormFile file = Request.Form.Files.FirstOrDefault();
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    user.FotoPefil = dataStream.ToArray();
                }
                await _userManager.UpdateAsync(user);
            }
            // -------

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
