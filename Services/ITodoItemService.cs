public interface ITodoItemService
{
    Task<IEnumerable<TodoItem>> GetTodoItems();
}