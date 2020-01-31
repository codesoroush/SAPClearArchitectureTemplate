﻿using BussinessLayer.Entities;
using DataLayer.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class TodoService:ITodoService
    {
        private UnitOfWork _uow;

        public TodoService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }

        public async Task<TodoList> CreateTodo(TodoList todo)
        {
            var result = await _uow.TodoList.AddAsync(todo);
            await _uow.CommitAsync();
            return result;
        }

        public void DeleteTask(TodoList todo)
        {
            _uow.TodoList.Delete(todo);
            _uow.Commit();
        }

        public List<TodoList> GetAllTodoes(string userId)
        {

            return _uow.TodoList.GetAllWithTodoesChilds(userId);
        }

        public List<TodoItem> GetAllTodoItemsnLastDays(string userId, int dayCount)
        {
            var todoItems = _uow.TodoList.GetAllTodoItemsInLastDays(userId,dayCount);

            // No need to sort sites first
            var grouped = todoItems.OrderBy(x => x.DueDate)
                               .Where(w => w.DoneDate.HasValue ).GroupBy(x => x.DoneDate.Value.Date);

            return todoItems;

        }

        public async Task Update(TodoList todo)
        {
          
         
             _uow.TodoList.Update(todo);
             await _uow.CommitAsync();
        }
    }
} 
