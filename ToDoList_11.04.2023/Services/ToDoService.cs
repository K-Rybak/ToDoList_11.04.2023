using ToDoList_11._04._2023.Data;
using ToDoList_11._04._2023.Models;

namespace ToDoList_11._04._2023.Services
{   
    public class ToDoService
    {
        private readonly AppDbContext appDbContext;

        public ToDoService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        //private List<ToDo> toDos = new List<ToDo>() { new ToDo
        //{
        //    Id = 1,
        //    Title = "First Work",
        //    Date = DateTime.Now,
        //    isDone = false
        //},
        //new ToDo{
        //    Id = 2,
        //    Title = "Second Work",
        //    Date = DateTime.Now,
        //    isDone = false
        //}
        //};
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
