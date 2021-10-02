using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private string[] saludos = {"Buenos días", "Buenas tardes", "Buenas noches", "Hasta mañana", "Como estás", "Hola", "Adios"};

        public List<string> ListaSaludos{get; set;}

        public void OnGet()
        {
            ListaSaludos = new List<string>();
            ListaSaludos.AddRange(saludos);
        }
    }
}
