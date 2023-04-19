using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList_11._04._2023.Models;
using ToDoList_11._04._2023.Services;
using ToDoList_11._04._2023.Services.Interfaces;

namespace ToDoList_11._04._2023.Pages
{
    public class CreateToDoModel : PageModel
    {
        private readonly IToDoService _toDoService;

        [BindProperty]
        public ToDo toDo { get; set; }

        public CreateToDoModel(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _toDoService.AddToDo(toDo);
            return RedirectToPage("Index");
        }
    }
}
