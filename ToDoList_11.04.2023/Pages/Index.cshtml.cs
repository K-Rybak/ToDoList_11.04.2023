using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList_11._04._2023.Models;
using ToDoList_11._04._2023.Services;

namespace ToDoList_11._04._2023.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ToDoService _toDoService;
        
        public List<ToDo> toDoList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ToDoService toDoService)
        {
            _logger = logger;
            _toDoService = toDoService;
        }

        public IActionResult OnGet()
        {
            toDoList = _toDoService.GetToDoList();
            return Page();
        }

        public IActionResult OnPostChangeIsDone([FromBody]int id, [FromBody]bool isDone)
        {
            _toDoService.change(id, isDone);
            return new JsonResult("ok");
        }
    }
}