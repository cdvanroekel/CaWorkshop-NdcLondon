using AutoMapper;
using CaWorkshop.Domain.Entities;

namespace CaWorkshop.Application.TodoLists.Queries.GetTodoLists;

[AutoMap(typeof(TodoList))]
public class TodoListDto
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public IList<TodoItemDto> Items { get; set; }
        = new List<TodoItemDto>();
}
