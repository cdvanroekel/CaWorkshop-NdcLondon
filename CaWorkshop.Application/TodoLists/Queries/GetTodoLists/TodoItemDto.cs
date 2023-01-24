using AutoMapper;
using CaWorkshop.Domain.Entities;

namespace CaWorkshop.Application.TodoLists.Queries.GetTodoLists;

[AutoMap(typeof(TodoItem))]
public class TodoItemDto
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }

    public int Priority { get; set; }

    public string? Note { get; set; }

    //public void Mapping(Profile profile)
    //{
    //    profile.CreateMap<TodoItem, TodoItemDto>()
    //        .ForMember(d => d.Priority, opt =>
    //            opt.MapFrom(s => (int)s.Priority));
    //}
}
