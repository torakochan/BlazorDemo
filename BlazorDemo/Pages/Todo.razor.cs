using BlazorDemo.Model;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages
{
    public partial class Todo : ComponentBase
    { 
        private List<TodoItem> todos = new List<TodoItem>();
        private string? newTodo;

        private void AddToDo()
        {
            if(!string.IsNullOrEmpty(newTodo))
            {
                todos.Add(new TodoItem() { Title = newTodo });
                newTodo = string.Empty;
            }    
        }
    }
}
