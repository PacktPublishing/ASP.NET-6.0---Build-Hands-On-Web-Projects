using ASPNETCoreWebApplication.Models;
using System.Collections.Generic;

namespace ASPNETCoreWebApplication.Services
{
    public class ToDoService
    {
        List<ToDoListModel> toDoLists = new List<ToDoListModel>();

        public List<ToDoListModel> GetItemsForCategory(string category)
        {
            if(category != null)
            {
                toDoLists.Add(new ToDoListModel {Id=1, Name="Homework" });
                toDoLists.Add(new ToDoListModel { Id = 1, Name = "Do dishes" });
                toDoLists.Add(new ToDoListModel { Id = 1, Name = "Visit Market" });
            }
            return toDoLists;
        }

    }
}
