using System.Net.Http.Json;

namespace TodoItemManagement;

public class TodoItemService : ITodoItemService
{
    private readonly HttpClient httpClient;
    private const string endPoint = "api/TodoItems";

    

    public TodoItemService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<IEnumerable<TodoItem>> GetTodoItems()
    {
        var results = await httpClient.GetFromJsonAsync<TodoItem[]>(endPoint);
        return results == null ? Array.Empty<TodoItem>() : results;
    }

    public async Task<IEnumerable<TodoItem>> AddTodoItem( TodoItem todoItem )
    {
        var response = await httpClient.PostAsJsonAsync<TodoItem>(endPoint, todoItem);
        return await GetTodoItems();
    }

    public async Task<IEnumerable<TodoItem>> DeleteTodoItem( TodoItem todoItem )
    {
        var response = await httpClient.DeleteAsync(endPoint + "/" + todoItem.Id);
        return await GetTodoItems();
    }

    public async Task<IEnumerable<TodoItem>> SetTodoItem( TodoItem todoItem )
    {
        todoItem.IsComplete = !todoItem.IsComplete;
        var response = await httpClient.PutAsJsonAsync(endPoint + "/" + todoItem.Id, todoItem);
        return await GetTodoItems();
    }
}