﻿using BussinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories.DedicatedRepository.Todo
{
    public interface ITodoItemRepository
    {
        List<TodoItem> GetUndoneTodoItemInTomorrow(string userId);
    }
}
