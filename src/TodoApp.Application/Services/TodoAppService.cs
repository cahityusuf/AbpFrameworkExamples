using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Abstractions.Services;
using TodoApp.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TodoApp.Services
{
    public class TodoAppService : ApplicationService, ITodoAppService
    {
        private readonly IRepository<TodoItem, Guid> _todoItems;

        public TodoAppService(IRepository<TodoItem, Guid> todoItems)
        {
            _todoItems = todoItems;
        }

        public async Task<List<TodoItemDto>> GetListAsync()
        {
            var result = await _todoItems.GetListAsync();

            return ObjectMapper.Map<List<TodoItem>, List<TodoItemDto>>(result.ToList());

        }

        public async Task<TodoItemDto> CreateAsync(TodoItemDto todoItem)
        {
            var item = ObjectMapper.Map<TodoItemDto, TodoItem>(todoItem);
            var result = await _todoItems.InsertAsync(item);
            return ObjectMapper.Map<TodoItem, TodoItemDto>(result); ;
        }

        public Task DeleteAsync(Guid id)
        {
            _todoItems.DeleteAsync(id);

            return Task.CompletedTask;
        }
    }
}
