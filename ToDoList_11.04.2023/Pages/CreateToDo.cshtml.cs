using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList_11._04._2023.Models;
using ToDoList_11._04._2023.Services;

namespace ToDoList_11._04._2023.Pages
{
    public class CreateToDoModel : PageModel
    {
        private readonly ToDoService _toDoService;

        public CreateToDoModel(ToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost(ToDo toDo)
        {
            _toDoService.AddToDo(toDo);
            return RedirectToPage("Index");
        }
    }
}
