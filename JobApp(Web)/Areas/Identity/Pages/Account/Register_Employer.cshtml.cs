using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using JobApp_Web_.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace JobApp_Web_.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class Register_EmployerModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;


        public Register_EmployerModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger)

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;

        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Company Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

          
            [Required]
            [DataType(DataType.Text)]
            [Display(Name ="Company Name")]
            public string Company_name { get; set; }


            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Company Background ")]
            public string Company_background { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Company Locatiion ")]
            public string Company_locatiion { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = " Campany Contact Number ")]
            public string Campany_contact_number { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = " Workforce Number ")]
            public int Workforce_number { get; set; }

            public string Company_Email { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = " Industry Type ")]
            public string Industry_type { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new Employer { UserName = Input.Company_name, Email = Input.Email,Company_name=Input.Company_name.Trim(),Company_background=Input.Company_background,Workforce_number=Input.Workforce_number,Company_locatiion=Input.Company_locatiion,Industry_type=Input.Industry_type,Campany_contact_number=Input.Campany_contact_number };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Employer").Wait();
                    _logger.LogInformation("User created a new account with password.");


                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);

                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
