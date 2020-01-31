using BussinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories.DedicatedRepository.Todo
{
    public interface ITodoListItemRepository
    {
        List<TodoList> GetAllWithTodoesChilds(string userId);
        List<TodoItem> GetAllTodoItemsInLastDays(string userId, int dayCount);
    }
}
