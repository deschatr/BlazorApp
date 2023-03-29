public interface ITodoItemService
{
    Task<IEnumerable<TodoItem>> GetTodoItems();
    Task<IEnumerable<TodoItem>> AddTodoItem(TodoItem todoItem);
}