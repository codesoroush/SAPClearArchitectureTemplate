using BussinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface ITodoService
    {

        List<TodoList> GetAllTodoes(string userId);
        List<TodoItem> GetAllTodoItemsnLastDays(string userId,int dayCount);


        
        Task<TodoList> CreateTodo(TodoList todo);
        Task Update(TodoList todo);
        void DeleteTask(TodoList todo);


    }
}
