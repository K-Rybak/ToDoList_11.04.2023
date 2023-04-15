using System.ComponentModel.DataAnnotations;

namespace ToDoList_11._04._2023.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        public string Title { get; set; }
        public bool isDone { get; set; }
        public DateTime Date { get; set; }
    }
}
