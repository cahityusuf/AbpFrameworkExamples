using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Dtos;
using Volo.Abp.Application.Services;

namespace TodoApp.Abstractions.Services
{
    public interface ITodoAppService:IApplicationService
    {
        Task<List<TodoItemDto>> GetListAsync();
        Task<TodoItemDto> CreateAsync(TodoItemDto todoItem);
        Task DeleteAsync(Guid id);

    }
}
