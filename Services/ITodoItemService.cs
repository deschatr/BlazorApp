public interface ITodoItemService
{
    Task<IEnumerable<TodoItem>> GetTodoItems();
    Task<IEnumerable<TodoItem>> AddTodoItem(TodoItem todoItem);
    Task<IEnumerable<TodoItem>> DeleteTodoItem(TodoItem todoItem);
    Task<IEnumerable<TodoItem>> SetTodoItem( TodoItem todoItem );
}