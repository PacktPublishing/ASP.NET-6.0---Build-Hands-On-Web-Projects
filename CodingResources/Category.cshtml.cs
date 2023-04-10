using System.Collections.Generic;
using ASPNETCoreWebApplication.Models;
using ASPNETCoreWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreWebApplication.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly ToDoService _service;
        public CategoryModel(ToDoService service)
        {
            _service = service;
        }
        
        public ActionResult OnGet(string category)
        {
            category = "todolist";
            Items = _service.GetItemsForCategory(category);
            return Page();
        }
        public List<ToDoListModel> Items { get; set; }
    }
}