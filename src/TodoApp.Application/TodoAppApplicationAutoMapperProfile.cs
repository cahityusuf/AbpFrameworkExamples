using AutoMapper;
using TodoApp.Dtos;

namespace TodoApp
{
    public class TodoAppApplicationAutoMapperProfile : Profile
    {
        public TodoAppApplicationAutoMapperProfile()
        {
            CreateMap<TodoItem, TodoItemDto>().ReverseMap();
        }
    }
}
