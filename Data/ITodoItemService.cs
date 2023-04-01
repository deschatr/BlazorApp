public interface ITodoItemService
{
    Task<IEnumerable<TodoItem>> GetTodoItems();
    Task<bool> AddTodoItem(TodoItem todoItem);
    Task<bool> DeleteTodoItem(TodoItem todoItem);
    Task<bool> SetTodoItem( TodoItem todoItem );
}