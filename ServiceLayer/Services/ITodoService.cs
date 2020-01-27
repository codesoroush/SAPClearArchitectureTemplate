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
        Task<TodoList> CreateTodo(TodoList todo);
        Task Update(TodoList todo);
        void DeleteTask(TodoList todo);

        

    }
}
