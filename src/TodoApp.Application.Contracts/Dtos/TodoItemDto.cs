using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace TodoApp.Dtos
{
    public class TodoItemDto:IEntityDto
    {
        public  Guid Id { get; set; }
        public string Text { get; set; }
    }
}
