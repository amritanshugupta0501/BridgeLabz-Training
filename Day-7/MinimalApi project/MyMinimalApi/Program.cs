var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var tasks = new List<TodoList>();
app.MapGet("/tasks", () => tasks);
app.MapGet("/tasks/{id}", (int id) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);
    return task is not null ? Results.Ok(task) : Results.NotFound();
}
);
app.MapPost("/tasks", (TodoList task) =>
{
    task.Id = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;
    tasks.Add(task);
    // Returns code 201 : Task Created status
    return Results.Created($"/tasks/{task.Id}", task);
});
app.MapPut("/tasks/{id}", (int id, TodoList updatedTask) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);
    if (task is null)
    {
        return Results.NotFound();
    }
    task.Name = updatedTask.Name;
    task.IsComplete = updatedTask.IsComplete;
    // Returns code 204 : No Content status
    return Results.NoContent();
}
);
app.MapDelete("/tasks/{id}", (int id) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);
    if (task == null)
    {
        return Results.NotFound();
    }
    tasks.Remove(task);
    return Results.NoContent();
});
app.Run();