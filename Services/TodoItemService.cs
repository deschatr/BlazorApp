using System.Net.Http.Json;

namespace TodoItemManagement;

public class TodoItemService : ITodoItemService
{
    private readonly HttpClient httpClient;

    public TodoItemService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<IEnumerable<TodoItem>> GetTodoItems()
    {
        var results = await httpClient.GetFromJsonAsync<TodoItem[]>("api/TodoItems");
        return results;
    }
}