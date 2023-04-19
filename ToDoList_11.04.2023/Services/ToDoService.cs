using ToDoList_11._04._2023.Data;
using ToDoList_11._04._2023.Models;
using ToDoList_11._04._2023.Services.Interfaces;

namespace ToDoList_11._04._2023.Services
{   
    public class ToDoService : IToDoService
    {
        private readonly AppDbContext appDbContext;

        public ToDoService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        public List<ToDo> GetToDoList() 
        {
            var toDoList = appDbContext.ToDo.ToList();
            return toDoList;
        }
        public void AddToDo(ToDo toDo) 
        {
            toDo.Date = DateTime.Now;
            toDo.isDone = false;
            appDbContext.ToDo.Add(toDo);
            appDbContext.SaveChanges();
        }

        public void ChageIsDone(int id, bool isDone)
        {
            var item = appDbContext.ToDo
                .Find(id);

            if (item != null)
            {
                item.isDone = isDone;
                appDbContext.SaveChanges();
            }
        }
    }
}
