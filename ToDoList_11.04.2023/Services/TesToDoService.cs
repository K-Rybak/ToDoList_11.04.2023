using ToDoList_11._04._2023.Models;
using ToDoList_11._04._2023.Services.Interfaces;

namespace ToDoList_11._04._2023.Services
{
    public class TesToDoService : IToDoService
    {
        private List<ToDo> toDos = new List<ToDo>() { new ToDo
        {
            Id = 1,
            Title = "First Work",
            Date = DateTime.Now,
            isDone = false
        },
        new ToDo{
            Id = 2,
            Title = "Second Work",
            Date = DateTime.Now,
            isDone = true
        }
        };

        public void AddToDo(ToDo toDo)
        {
            toDo.Date = DateTime.Now;
            toDos.Add(toDo);
        }

        public List<ToDo> GetToDoList()
        {
            return toDos;
        }
    }
}
