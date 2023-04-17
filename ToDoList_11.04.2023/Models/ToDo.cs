using System.ComponentModel.DataAnnotations;

namespace ToDoList_11._04._2023.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите название")]
        public string Title { get; set; }
        public bool isDone { get; set; }
        public DateTime Date { get; set; }
    }
}
