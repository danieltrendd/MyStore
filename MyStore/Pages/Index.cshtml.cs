﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyStore.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Username.Equals("admin") && Password.Equals("123"))
            {
                //HttpContext.Session.SetString("username", Username);
                return RedirectToPage("/Clients/Index");
            }
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }
    }
}