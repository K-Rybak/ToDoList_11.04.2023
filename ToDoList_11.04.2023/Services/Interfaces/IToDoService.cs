using ToDoList_11._04._2023.Models;

namespace ToDoList_11._04._2023.Services.Interfaces
{
    public interface IToDoService
    {
        public List<ToDo> GetToDoList();
        public void AddToDo(ToDo toDo);
    }
}
